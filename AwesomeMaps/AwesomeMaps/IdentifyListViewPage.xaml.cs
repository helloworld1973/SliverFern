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
	public partial class IdentifyListViewPage : ContentPage
	{
        Species seletedSpecies = new Species();
        public IdentifyListViewPage ()
		{
			InitializeComponent ();
            SpeciesListView.ItemsSource = new List<Species>
            {

                new Species
                {
                    Name="Must",
                    Similarity=0.43,
                    InvasiveOrNot=true,
                    Solutions="please remove it!",
                    ImageAddr="login_image.png",
                    InvasiveOrNotString=InvasiveOrNotReturn(true),
                    Description="The plant can grow to 3 metres high with up to 50 stems per plant. It flowers from December to February with showy spikes of purple flowers at the end of the stems.",
                    Hazard="The plant can grow to 3 metres high with up to 50 stems per plant (usually square in cross-section). It flowers from December to February with showy spikes of purple flowers.",
                    Solution="The plant can grow to 3 metres high with up to 50 stems per plant (usually square in cross-section)."
                },
                new Species
                {
                    Name="Must",
                    Similarity=0.43,
                    InvasiveOrNot=false,
                    Solutions="please remove it!",
                    ImageAddr="login_image.png",
                    InvasiveOrNotString=InvasiveOrNotReturn(false)
                },
                new Species
                {
                    Name="Must",
                    Similarity=0.43,
                    InvasiveOrNot=false,
                    Solutions="please remove it!",
                    ImageAddr="login_image.png",
                    InvasiveOrNotString=InvasiveOrNotReturn(false)
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
            seletedSpecies = item;
            ListViewPageAndDetailsPage.Children.Remove(SpeciesListView);
            DetailsView detailsView = new DetailsView();
            detailsView.BindingContext = item;
            ListViewPageAndDetailsPage.Children.Add(detailsView);
            
            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
           
            //ListView lst = (ListView)sender;
            //lst.SelectedItem = null;
        }
    }
}