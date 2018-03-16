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
            var pos = new Position(-36.863717, 174.758264);
            mapContent.MoveToRegion(MapSpan.FromCenterAndRadius(pos, Distance.FromMeters(10000)), true);
            AddPinFromAzure();

        }

        async void AddPinFromAzure()
        {
            AzureDataServiceForPins azureDataServiceForPins = new AzureDataServiceForPins();

            IEnumerable<SPECIES_LA_LONG> iEnumerablePinClass = await azureDataServiceForPins.GetPinsAsync();
            AddPin(iEnumerablePinClass);
        }
        public void AddPin(IEnumerable<SPECIES_LA_LONG> pinClassList)
        {
            for (int i = 0; i < pinClassList.Count(); i++)
            {
                SPECIES_LA_LONG pinClass = pinClassList.ElementAt(i);
                var pin = new Pin()              
                {
                    Type = PinType.Place,
                    Label = pinClass.speciesName,
                    Address = "latitude:"+pinClass.latitude+ ",longtitude:"+ pinClass.longtitude,
                    Position = new Position(pinClass.latitude, pinClass.longtitude)
                };
                mapContent.Pins.Add(pin);
            }

        }

		
    }
}