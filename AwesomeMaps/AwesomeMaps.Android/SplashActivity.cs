using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AwesomeMaps.Droid
{
    [Activity(MainLauncher = true, NoHistory = true, Theme = "@style/SplashTheme")]//
    public class SplashActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Log.Debug(TAG, "SplashActivity.OnCreate");
           
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => 
            {
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));

            });
            startupWork.Start();
        }
    }
}