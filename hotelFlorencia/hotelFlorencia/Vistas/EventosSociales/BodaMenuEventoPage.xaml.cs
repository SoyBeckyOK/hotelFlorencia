using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.Vistas.EventosSociales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BodaMenuEventoPage : ContentPage
    {
        public BodaMenuEventoPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new BoquitasEventosPage());
        }
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuNiñosPage());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuPolloEventosPage());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuCarneEventosPage());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuCenasEventos());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuMariscosEventospage());
        }
    }
}