using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeMaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
            NewsListView.ItemsSource = new List<News>
            {
                new News
                {
                    Title="Big Disaster in this summer",
                    ImageSmallAddr = "login_image.png",
                    ImageBigAddr = "login_image.png",
                    Publisher = "Uni of Cant.",
                    DateTimeTime =DateTime.Today,
                    Article = "The plant can grow to 3 metres high with up to 50 stems per plant. It flowers from December to February with showy spikes of purple flowers at the end of the stems.",
                    Abstract="The plant can grow to 3 metre"

                },
                new News
                {
                    Title="Big Disaster in this summer",
                    ImageSmallAddr = "login_image.png",
                    ImageBigAddr = "login_image.png",
                    Publisher = "Uni of Cant.",
                    DateTimeTime =DateTime.Today,
                    Article = "The plant can grow to 3 metres high with up to 50 stems per plant. It flowers from December to February with showy spikes of purple flowers at the end of the stems.",
                    Abstract="The plant can grow to 3 metre"

                }
            };
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as News;
            NewsPageAndDetailsPage.Children.Remove(NewsListView);
            //NewsWholeView newsWholeView = new NewsWholeView();
            //newsWholeView.BindingContext = item;
            //NewsPageAndDetailsPage.Children.Add(newsWholeView);
        }

    }
}