using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelFlorencia.Vistas.Restaurante;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantePage : ContentPage
    {
        public RestaurantePage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new EntradasPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new CevichesPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new CarnesPage());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new CortesEspecialesPage());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new ParrilladaPage());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new BebidasPage());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new PostresRestaurantePage());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MariscosPage());
        }
    }
}