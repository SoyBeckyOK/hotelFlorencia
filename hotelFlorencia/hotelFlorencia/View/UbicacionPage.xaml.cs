using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicacionPage : ContentPage
    {
        public UbicacionPage()
        {
            InitializeComponent();

          Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(
                            new Position(13.496144, -88.202453),
                            Distance.FromMiles(0.5)));
        

            
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(13.496144, -88.202453),
                Label = "Hotel Florencia",
                Address = "Carretera Panamericana, Col. Guadalupe, San Miguel, El Salvadorricana, San Miguel, El Salvador",
            };

            Mapa.Pins.Add(pin);
        }
    }
}