using System;
using System.Collections.Generic;
using System.Text;
using hotelFlorencia.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

//using Menu = hotelFlorencia.Model.Menu;

namespace hotelFlorencia.ViewModel
{
    
    public class RestaurantViewModel:BaseViewModel
    {
        private ObservableCollection<MenuElement> Menus_BF;

        

       

        public ObservableCollection<MenuElement> Menus
        {
            get { return Menus_BF; }
            set { Menus_BF = value;
                OnPropertyChanged();
            }
        }
     


        public RestaurantViewModel()
        {
            

            DetailMenu = new Command(
                async () =>
                {
                    await App.Current.MainPage.Navigation.PushAsync(new View.PlatoMenuDetail
                    { BindingContext = new DetailMenuViewModel(menuSelected) });
                });
            Menus = GetMenuData();

        }


    


        private ObservableCollection<MenuElement> GetMenuData()
        {
            return new ObservableCollection<MenuElement>
            {
                new MenuElement{Image="Entradas.jpg", Name="Entradas", Tipo= MenuType.Entradas} ,
                new MenuElement{Image="Cocteles.jpg", Name="Cocteles y Ceviches", Tipo= MenuType.CoctelesCeviches},
                new MenuElement{Image="Carnes.jpg", Name="Carnes y Aves", Tipo= MenuType.CarnesAves},
                new MenuElement{Image="Camarones.jpg", Name="Camarones y Pescado", Tipo= MenuType.CamaronesYPescado},
                new MenuElement{Image="Cortes.jpg", Name="Cortes Especiales", Tipo= MenuType.CortesEspeciales},
                new MenuElement{Image="Parrilladas.jpg", Name="Parrilladas para Compartir", Tipo= MenuType.Parrilladas},
                new MenuElement{Image="Bebidas.jpg", Name="Bebidas", Tipo= MenuType.Bebidas},
                new MenuElement{Image="Postres.jpg", Name="Postres", Tipo= MenuType.Postres}
            };
                 
        }


        #region Propiedades
        public MenuElement menuSelected { get; set; }
        #endregion
        public Command DetailMenu { get; set; }
    }

}         

