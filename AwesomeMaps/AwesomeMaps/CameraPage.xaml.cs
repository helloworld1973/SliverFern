using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeMaps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CameraPage : ContentPage
	{
		public CameraPage ()
		{
			InitializeComponent ();
            TakePhotoButton.Clicked += TakePhotoButton_Clicked;
        }

        async void TakePhotoButton_Clicked(object sender, System.EventArgs e)
        {
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

    }
}