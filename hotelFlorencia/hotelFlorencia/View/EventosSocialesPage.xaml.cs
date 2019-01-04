using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelFlorencia.View.EventosSociales;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventosSocialesPage : ContentPage
	{
		public EventosSocialesPage ()
		{
			InitializeComponent ();
		}

        private async void Btn_FiestaRosa_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new FiestaRosaMenuEvento());
        }

        private async void Btn_BabyShower_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new BabyShowerMenuEvento());
        }

        private async void Btn_Boda_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new BodaMenuEventoPage());
        }

        private async void Btn_Graduaciones_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new GraduacionMenuEventos());
        }
    }
}