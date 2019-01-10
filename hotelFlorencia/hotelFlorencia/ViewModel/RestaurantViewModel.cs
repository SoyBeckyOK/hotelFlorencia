using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using hotelFlorencia.Model;


namespace hotelFlorencia.ViewModel
{
    public class RestaurantViewModel
    {
        private ObservableCollection<Menu> Menus_BF;
        public ObservableCollection<Menu> Menus
        {
            get { return Menus_BF; }
            set { Menus_BF = value; }
        }

        public RestaurantViewModel()
        {
            Menus = GetMenuData();

        }

        private ObservableCollection<Menu> GetMenuData()
        {
            return new ObservableCollection<Menu>
            {
                new Menu{Image="Entradas.jpg", Name="Entradas"},
                new Menu{Image="Cocteles.jpg", Name="Cocteles y Ceviches"},
                new Menu{Image="Carnes.jpg", Name="Carnes y Aves"},
                new Menu{Image="Camarones.jpg", Name="Camarones y Pescado"},
                new Menu{Image="Cortes.jpg", Name="Cortes Especiales"},
                new Menu{Image="Parrilladas.jpg", Name="Parrilladas para Compartir"},
                new Menu{Image="Bebidas.jpg", Name="Bebidas"},
                new Menu{Image="Postres.jpg", Name="Postres"}
            };
                 
        }

        #region Propiedades
        public Menu menuSelected { get; set; }
        #endregion
    }

}         

