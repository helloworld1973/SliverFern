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
            SpeciesListView.ItemsSource = new List<Species>
            {

                new Species
                {
                    Name="Must",
                    Similarity=0.43,
                    InvasiveOrNot=true,
                    Solutions="please remove it!",
                    ImageAddr="login_image.png",
                    InvasiveOrNotString=InvasiveOrNotReturn(true)
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
	}
}