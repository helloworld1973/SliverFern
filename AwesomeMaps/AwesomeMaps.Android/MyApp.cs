using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AwesomeMaps.CustomGoogleMap;

namespace AwesomeMaps.Droid
{
    [Application]
    [MetaData("com.google.android.maps.v2.API_KEY", Value = Variables.Google_Maps_Android_API_Key)]
    public class MyApp : Application
    {
        public MyApp(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
    }
}