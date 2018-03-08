using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeMaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string userName = username.Text;
            string passWord = password.Text;
            loginbutton.Text = userName + passWord;
        }

        private async void testbutton_Clicked(object sender, EventArgs e)
        {
            AzureDataService azureDataService = new AzureDataService();
            try
            {
                string name = "Acacia";
                IEnumerable<Species> species_name = await azureDataService.GetSpeciesAsync(name);


                //Task < ObservableCollection<Species> > aa= azureDataService.GetTodoItemsAsync("Acacia");
                //ObservableCollection<Species> observableCollection = aa.Result;
                //for (int i = 0; i < observableCollection.Count; i++)
                //{
                //    Species species = observableCollection[i];
                //    String name = species.speciesName;
                //}
            }
            catch (Exception exp)
            {
                Debug.WriteLine(@"Sync error: {0}", exp.Message);
            }
           
        }
    }
}