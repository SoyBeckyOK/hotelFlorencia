using System;
using System.Collections.Generic;
using System.Text;
using hotelFlorencia.View;
using hotelFlorencia.Model;

namespace hotelFlorencia.clasesHotel
{
    class restauranteList 
    {
        public List<PlatilloModel> verPlatillo()
        {
            var lista = new List<PlatilloModel>();
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Desayunos" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Pastas" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Mariscos" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Hamburguesas" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Vinos" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Postres" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Ensaladas" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Entradas" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Bebidas" });
            lista.Add(new PlatilloModel() { Foto = "https://images.friendlyrentals.com/FR_imgs/blog/PrImg_2361.jpg", Nombre = "Acompañamientos" });
            return lista;
        }
    }
}
