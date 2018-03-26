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
    public partial class DetailsView : ContentView
    {
        public DetailsView()
        {
            InitializeComponent();
        }

        protected void GoBackButtonPressed()
        {
            this.IsVisible = false;
            Element ListViewPageAndDetailsPage = this.Parent;
            ListView speciesListView =ListViewPageAndDetailsPage.FindByName<ListView>("SpeciesListView");
            speciesListView.IsVisible = true;
            StackLayout buttonBack = ListViewPageAndDetailsPage.FindByName<StackLayout>("ButtonBack");
            buttonBack.IsVisible = true;
        }
    }
}