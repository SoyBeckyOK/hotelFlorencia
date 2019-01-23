using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactoPage : ContentPage
	{
		public ContactoPage()
		{
			InitializeComponent ();
         
          
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://goo.gl/maps/XxbYfkhXCR12"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/hotelflorencia_sanmiguel/"));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://es-la.facebook.com/hotelflorencia.sanmiguel/"));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            PhoneDialer.Open("26655500");
        }
    }
}