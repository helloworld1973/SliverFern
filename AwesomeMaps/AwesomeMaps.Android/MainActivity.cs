using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android.AppCompat;
using System.IO;
using System.Threading.Tasks;
using Android.Content;

namespace AwesomeMaps.Droid
{
    [Activity(Theme = "@style/MainTheme")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

            base.OnCreate(bundle);
            
            global::Xamarin.Forms.Forms.Init(this, bundle);
            
            Xamarin.FormsGoogleMaps.Init(this, bundle);
            
            LoadApplication(new App());
        }

        //pick an image from picture library
        public static readonly int PickImageId = 1000;
        public TaskCompletionSource<Stream> PickImageTaskCompletionSource { set; get; }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent intent)
        {
            base.OnActivityResult(requestCode, resultCode, intent);

            if (requestCode == PickImageId)
            {
                if ((resultCode == Result.Ok) && (intent != null))
                {
                    Android.Net.Uri uri = intent.Data;
                    Stream stream = ContentResolver.OpenInputStream(uri);

                    // Set the Stream as the completion of the Task
                    PickImageTaskCompletionSource.SetResult(stream);
                }
                else
                {
                    PickImageTaskCompletionSource.SetResult(null);
                }
            }
        }
    }
}

