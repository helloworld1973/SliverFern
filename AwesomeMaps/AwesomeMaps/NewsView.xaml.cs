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
    public partial class NewsView : ContentView
    {
        public NewsView()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_TappedNew1(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "http://earthhour.wwf.sg/";
            //Content = browser;
            Content = browser;
            //NewPageLayout.IsVisible = false;
            //NewPageLayoutUp.Children.Insert(1,browser);
        }
        private void TapGestureRecognizer_TappedNew2(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "http://www.mfe.govt.nz/news-events/sign-join-conversation-zero-carbon-bill";
            Content = browser;
        }
        private void TapGestureRecognizer_TappedNew3(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "https://www.mpi.govt.nz/protection-and-response/responding/alerts/myrtle-rust";
            Content = browser;
        }
        private void TapGestureRecognizer_TappedNew4(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "https://www.radionz.co.nz/national/programmes/afternoons/audio/2018635731/expert-feature-the-humble-cabbage-tree-ti-kouka";
            Content = browser;
        }
        private void TapGestureRecognizer_TappedNew5(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "http://blog.tepapa.govt.nz/2018/03/06/what-happens-when-you-ask-ornithologists-to-do-botany/";
            Content = browser;
        }
        private void TapGestureRecognizer_TappedNew6(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "http://greenpeace.nz/petitionEndOil";
            Content = browser;
        }
        private void TapGestureRecognizer_TappedNew7(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "http://www.doc.govt.nz/our-work/battle-for-our-birds/";
            Content = browser;
        }
        private void TapGestureRecognizer_TappedNew8(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "http://www.mfe.govt.nz/news-events/microbeads-banned";
            Content = browser;
        }
        private void TapGestureRecognizer_TappedNew9(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "https://www.theatlantic.com/technology/archive/2015/07/when-you-give-a-tree-an-email-address/398210/?utm_source=fbb";
            Content = browser;
        }
    }
}