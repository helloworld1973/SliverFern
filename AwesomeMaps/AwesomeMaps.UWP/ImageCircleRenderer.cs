using AwesomeMaps;
using AwesomeMaps.CustomGoogleMap;
using AwesomeMaps.UWP;
using System;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Image), typeof(ImageCircleRenderer))]
namespace AwesomeMaps.UWP
{
    public class ImageCircleRenderer : ImageRenderer
    {
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Control != null && Control.Clip == null)
            {
                var min = Math.Min(Element.Width, Element.Height) / 2.0f;
                if (min <= 0)
                    return;
                Control.Clip = new RectangleGeometry
                {
                    Rect = new Windows.Foundation.Rect(0,0, Element.Width, Element.Height)
                };
            }
        }
    }
}
