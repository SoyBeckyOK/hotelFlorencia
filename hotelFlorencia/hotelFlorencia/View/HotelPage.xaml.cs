using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelFlorencia.View.Hotel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HotelPage : ContentPage
	{
		public HotelPage()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new HabitacionLujoPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new HabitacionDoblePage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new HabitacionTriplePage());
        }
    }
}