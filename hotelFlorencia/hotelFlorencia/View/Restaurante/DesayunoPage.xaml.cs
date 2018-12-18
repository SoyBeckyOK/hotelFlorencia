using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelFlorencia.Model;
using hotelFlorencia.clasesHotel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace hotelFlorencia.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DesayunoPage : ContentPage
	{
		public DesayunoPage()
		{
			InitializeComponent ();
            ObservableCollection<MenuModel> listaMenus = new ObservableCollection<MenuModel>(new menulist().VerMenu());
            listMenu.ItemsSource = listaMenus;
		}
        private async void ListMenus_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new DesayunoPage());
        }
    }
}