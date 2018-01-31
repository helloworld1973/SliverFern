using AwesomeMaps.CustomGoogleMap;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        async void TapGestureRecognizer_Tapped_Camera(object sender, EventArgs e)
        {
            relativeLayout.Children.Remove(mapView);//remove google map

            var cameraPageClass = new CameraPageClass();
            cameraPageClass.OnPhotoResult += CameraPageClass_OnPhotoResult;
            await Navigation.PushModalAsync(cameraPageClass);
        }
        async void CameraPageClass_OnPhotoResult(AwesomeMaps.PhotoResultEventArgs result)
        {
            await Navigation.PopModalAsync();
            if (!result.Success)
                return;

            Photo.Source = ImageSource.FromStream(() => new MemoryStream(result.Image));
        }

        async void TapGestureRecognizer_Tapped_ImagesLib(object sender, EventArgs e)
        {
            relativeLayout.Children.Remove(mapView);//remove google map
            imagesLib.IsEnabled = false;
            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

            if (stream != null)
            {
                Photo.Source = ImageSource.FromStream(() => stream);

            }
            else
            {
                imagesLib.IsEnabled = true;
            }
        }
    }
}
