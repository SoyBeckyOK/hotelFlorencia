using System;
using System.Collections.Generic;
using System.Text;
using hotelFlorencia.Model;


namespace hotelFlorencia.clasesHotel
{
    class menulist
    {
        public List<MenuModel> VerMenu()
        {
            var lista = new List<MenuModel>();
            lista.Add(new MenuModel () { Nombre = "Open fruit bar", Imagen = "https://www.cantabriadmoda.com/wp-content/uploads/2016/11/GF0O1XE1.jpg", Precio = "$ 3.50", Descripcion = "Frutas de temporada servidas con granola, requesón o yogur." });
            lista.Add(new MenuModel () { Nombre = "Open fruit bar", Imagen = "https://www.cantabriadmoda.com/wp-content/uploads/2016/11/GF0O1XE1.jpg", Precio = "$ 3.50", Descripcion = "Frutas de temporada servidas con granola, requesón o yogur." });
            lista.Add(new MenuModel () { Nombre = "Open fruit bar", Imagen = "https://www.cantabriadmoda.com/wp-content/uploads/2016/11/GF0O1XE1.jpg", Precio = "$ 3.50", Descripcion = "Frutas de temporada servidas con granola, requesón o yogur." });
            lista.Add(new MenuModel () { Nombre = "Open fruit bar", Imagen = "https://www.cantabriadmoda.com/wp-content/uploads/2016/11/GF0O1XE1.jpg", Precio = "$ 3.50", Descripcion = "Frutas de temporada servidas con granola, requesón o yogur." });
           
  
            return lista;
        }
    }
}
