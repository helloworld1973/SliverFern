using AwesomeMaps.CustomGoogleMap;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
        String AIreturnData = null;

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
            byte[] m_Bytes = result.Image;
            await MakePredictionRequest(m_Bytes);


            Photo.Source = ImageSource.FromStream(() => new MemoryStream(result.Image));
        }

        async void TapGestureRecognizer_Tapped_ImagesLib(object sender, EventArgs e)
        {
            relativeLayout.Children.Remove(mapView);//remove google map
            imagesLib.IsEnabled = false;
            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();
            byte[] m_Bytes = ReadToEnd(stream);
            await MakePredictionRequest(m_Bytes);


            if (stream != null)
            {
                Photo.Source = ImageSource.FromStream(() => stream);

            }
            else
            {
                imagesLib.IsEnabled = true;
            }
        }

        public static byte[] ReadToEnd(System.IO.Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }

        public async Task MakePredictionRequest(byte[] byteImageData)
        {
            var client = new HttpClient();

            // Request headers - replace this example key with your valid subscription key.
            client.DefaultRequestHeaders.Add("Prediction-Key", "2fda6965363343bbb00babc6959ba975");

            // Prediction URL - replace this example URL with your valid prediction URL.
            string url = "https://southcentralus.api.cognitive.microsoft.com/customvision/v1.1/Prediction/7b1f5083-43a1-4a08-9d54-7a153b7ce405/image?iterationId=372a91da-92e5-477a-a1dd-a68e863308c4";

            HttpResponseMessage response;

            // Request body. Try this sample with a locally stored image.
            byte[] byteData = byteImageData;

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(url, content);
                AIreturnData = await response.Content.ReadAsStringAsync();
            }
        }


    }
}
