using hotelFlorencia.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalPage :ContentPage
	{
		public PrincipalPage ()
		{
			InitializeComponent ();
           
           
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new RestaurantePage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new HotelPage());
        }

        private async  void Button_Clicked_2(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new EventosSocialesPage());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new EventosNegociosPage());
        }
    }
}