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

            Children.Add(new MainPage { Icon= "ic_photo_camera.png" });
            Children.Add(new ActivityPage { Icon = "ic_group.png" });
            Children.Add(new NewsPage { Icon = "ic_news.png" });//NewsPage
            Children.Add(new LoginPage { Icon = "ic_face.png" });
                        
        }
    }
}
