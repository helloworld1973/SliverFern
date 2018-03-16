using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeMaps
{
    class AzureDataServiceForPins
    {
        public MobileServiceClient MobileClient { get; set; }
        IMobileServiceSyncTable<SPECIES_LA_LONG> pinsTable;

        public async Task Initialize()
        {
            if (MobileClient?.SyncContext?.IsInitialized ?? false)
                return;

            var appUrl = "https://sliverfernmobileapp.azurewebsites.net";



            MobileClient = new MobileServiceClient(appUrl);

            //InitialzeDatabase for path
            var pathPins = InitializeDatabasePins();

            pathPins = Path.Combine(MobileServiceClient.DefaultDatabasePath, pathPins);

            //setup our local sqlite store and intialize our table
            var storePins = new MobileServiceSQLiteStore(pathPins);

            //Define table
            storePins.DefineTable<SPECIES_LA_LONG>();

            //Initialize SyncContext  used to associate the local store with the sync context
            await MobileClient.SyncContext.InitializeAsync(storePins);

            pinsTable = MobileClient.GetSyncTable<SPECIES_LA_LONG>();
        }

        private string InitializeDatabasePins()
        {
#if __ANDROID__ || __IOS__
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
#endif
            SQLitePCL.Batteries.Init();

            var path = "syncstorepins.db";

#if __ANDROID__
            path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), path);

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
#endif

            return path;
        }


        public async Task<ObservableCollection<SPECIES_LA_LONG>> GetPinsAsync()
        {
            await SyncPins();
            IEnumerable<SPECIES_LA_LONG> items = await pinsTable
              .ToEnumerableAsync();

            return new ObservableCollection<SPECIES_LA_LONG>(items);
        }
        public async Task SyncPins()
        {
            await Initialize();
            ReadOnlyCollection<MobileServiceTableOperationError> syncErrors = null;
            try
            {                
                await pinsTable.PullAsync($"allMessage", pinsTable.CreateQuery());
                await MobileClient.SyncContext.PushAsync();
            }
            catch (MobileServicePushFailedException exc)
            {
                if (exc.PushResult != null)
                {
                    syncErrors = exc.PushResult.Errors;
                }
            }
            // Simple error/conflict handling.
            if (syncErrors != null)
            {
                foreach (var error in syncErrors)
                {
                    if (error.OperationKind == MobileServiceTableOperationKind.Update && error.Result != null)
                    {
                        // Update failed, revert to server's copy
                        await error.CancelAndUpdateItemAsync(error.Result);
                    }
                    else
                    {
                        // Discard local change
                        await error.CancelAndDiscardItemAsync();
                    }

                    Debug.WriteLine(@"Error executing sync operation. Item: {0} ({1}). Operation discarded.", error.TableName, error.Item["id"]);
                }
            }
        }


    }
}
