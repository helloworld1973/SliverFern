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
                    ImageAddr="login_image.png"

                },
                new Species
                {
                    Name="Must",
                    Similarity=0.43,
                    InvasiveOrNot=true,
                    Solutions="please remove it!",
                    ImageAddr="login_image.png"

                },
                new Species
                {
                    Name="Must",
                    Similarity=0.43,
                    InvasiveOrNot=true,
                    Solutions="please remove it!",
                    ImageAddr="login_image.png"

                }

            };


        }
	}
}