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
	public partial class IdentifyListView : ContentView
	{
        public IdentifyListView()
        {
            InitializeComponent();
            SpeciesListView.ItemsSource = new List<Species>
            {

                new Species
                {

                },
                new Species
                {

                },
                new Species
                {

                }
            };
        }
        string InvasiveOrNotReturn(Boolean set)
        {
            if (set.Equals(true))
            {
                return "Invasive Species";
            }
            else
            {
                return "Non-invasive Species";
            }
        }
        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Species;
            ListViewPageAndDetailsPage.Children.Remove(SpeciesListView);
            DetailsView detailsView = new DetailsView();
            detailsView.BindingContext = item;
            ListViewPageAndDetailsPage.Children.Add(detailsView);

        }
    }
}