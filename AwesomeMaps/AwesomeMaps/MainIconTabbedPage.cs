using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Daddoon;

namespace AwesomeMaps
{
    class MainIconTabbedPage:IconTabbedPage
    {
        public MainIconTabbedPage() : base()
        {
            BarBackgroundColor = Color.White; //Your own custom color
            BarTextColor = Color.Black; //Your own custom color
            UnselectedTextColor = Color.Gray; //Your own custom color
            HideText = true; //Hide text (iOS only)

            Children.Add(new test { BackgroundColor = Color.Red, Title = "Page 1",Icon= "ic_add_a_photo.png" });
            Children.Add(new LoginPage { BackgroundColor = Color.Blue, Title = "Page 2" });
            //Children.Add(new ContentPage { BackgroundColor = Color.Green, Title = "Page 3", Icon = "success_icon.png" });
        }
    }
}
