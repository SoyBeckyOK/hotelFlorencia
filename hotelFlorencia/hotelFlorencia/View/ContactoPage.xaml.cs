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
    }
}