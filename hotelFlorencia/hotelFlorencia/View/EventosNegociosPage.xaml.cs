﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelFlorencia.View.EventosNegocio;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventosNegociosPage : ContentPage
	{
		public EventosNegociosPage()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new EventosNegociosImagePage());
        }
    }
}