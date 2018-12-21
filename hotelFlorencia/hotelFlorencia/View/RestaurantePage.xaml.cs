using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelFlorencia.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using hotelFlorencia.clasesHotel;
namespace hotelFlorencia.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RestaurantePage : ContentPage
	{
		public RestaurantePage()
		{
			InitializeComponent ();
            ObservableCollection<PlatilloModel> listaPlatillos = new ObservableCollection<PlatilloModel>(new restauranteList().verPlatillo());
           
        }

        //private async void ListPlatos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        
    }
}