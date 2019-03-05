using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace hotelFlorencia
{
    public class SplashPage : ContentPage

    {
        Image SplashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "LogoFlorencia",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(SplashImage);

            this.BackgroundImage = "FondoPrincipal.jpg";
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            await SplashImage.ScaleTo(1, 800);
            await SplashImage.ScaleTo(3, 600);
            //await SplashImage.ScaleTo(110, 700);
            Application.Current.MainPage = new NavigationPage(new Vistas.MenuTabbedPagePrincipal());
        }
    }
}
