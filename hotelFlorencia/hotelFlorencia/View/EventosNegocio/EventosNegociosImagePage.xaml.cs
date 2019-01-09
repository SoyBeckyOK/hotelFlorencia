﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelFlorencia.View.EventosSociales;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hotelFlorencia.View.EventosNegocio
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventosNegociosImagePage : ContentPage
	{
		public EventosNegociosImagePage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new BoquitasEventosPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuPolloEventosPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuCarneEventosPage());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuCenasEventos());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuMariscosEventospage());
        }
    }
}