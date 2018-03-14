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
    class AzureDataService
    {
        public MobileServiceClient MobileClient { get; set; }
        IMobileServiceSyncTable<Species> speciesTable;

        public async Task Initialize()
        {
            if (MobileClient?.SyncContext?.IsInitialized ?? false)
                return;

            var appUrl = "https://sliverfernmobileapp.azurewebsites.net";



            MobileClient = new MobileServiceClient(appUrl);

            //InitialzeDatabase for path
            var path = InitializeDatabase();
            path = Path.Combine(MobileServiceClient.DefaultDatabasePath, path);

            //setup our local sqlite store and intialize our table
            var store = new MobileServiceSQLiteStore(path);

            //Define table
            store.DefineTable<Species>();

            //Initialize SyncContext  used to associate the local store with the sync context
            await MobileClient.SyncContext.InitializeAsync(store);

            speciesTable = MobileClient.GetSyncTable<Species>();
        }

        private string InitializeDatabase()
        {
#if __ANDROID__ || __IOS__
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
#endif
            SQLitePCL.Batteries.Init();

            var path = "syncstore.db";

#if __ANDROID__
            path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), path);

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
#endif

            return path;
        }



        public async Task<ObservableCollection<Species>> GetSpeciesAsync(string name)
        {
            await SyncSpecies();

            IEnumerable<Species> items = await speciesTable
              .Where(todoItem => todoItem.speciesName==name)
              .ToEnumerableAsync();

            return new ObservableCollection<Species>(items);
        }



        public async Task<Species> AddSpecies()
        {
            await Initialize();
            Species mySpecies = new Species
            {
                speciesName = "yexiaozhou",
                invasiveOrNot = true,
            };

            await speciesTable.InsertAsync(mySpecies);
            await SyncSpecies();
            return mySpecies;
        }



        public async Task SyncSpecies()
        {
            await Initialize();
            ReadOnlyCollection<MobileServiceTableOperationError> syncErrors = null;
            try
            {
                await MobileClient.SyncContext.PushAsync();
                await speciesTable.PullAsync($"allMessage", speciesTable.CreateQuery());
                
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
       
        

        //public AzureDataService()
        //{
        //    MobileService = new MobileServiceClient("https://sliverfernmobileapp.azurewebsites.net");
        //    speciesTable = MobileService.GetTable<Species>();
        //}



        //Querying Data
        //public async Task<ObservableCollection<Species>> GetTodoItemsAsync(String name)
        //{

        //    IEnumerable<Species> items = await speciesTable
        //        .Where(todoItem => todoItem.invasiveOrNot)
        //        .Select(todoItem => todoItem)
        //        .ToListAsync()
        //        ;

        //    return new ObservableCollection<Species>(items);
        //}

    }
}
