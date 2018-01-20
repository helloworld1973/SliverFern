using AwesomeMaps.CustomGoogleMap;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace AwesomeMaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
		{
			InitializeComponent();

            var tap = new TapGestureRecognizer();

            tap.Tapped += (object sender, EventArgs e) => 
            {
                this.Navigation.PushAsync(new CameraPage());
            };
            camera.GestureRecognizers.Add(tap);

        }

        async void OpenCamera(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CameraPage());
        }

        protected override void OnAppearing()
		{
			base.OnAppearing();
			///
            /*
			await Task.Delay(1000);

            var hasPermission = await Utils.CheckPermissions(Permission.Location);
            if (!hasPermission)
            {
                Debug.WriteLine("No Permission");
            }*/
            ///mapView.MoveToCurrentPosition();
		}
	}
}
