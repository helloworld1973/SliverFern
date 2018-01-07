using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Geolocator;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms.GoogleMaps;
using System.Diagnostics;

namespace AwesomeMaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapView : ContentView
    {
        public MapView() : base()
        {
            InitializeComponent();
        }
		
    }
}