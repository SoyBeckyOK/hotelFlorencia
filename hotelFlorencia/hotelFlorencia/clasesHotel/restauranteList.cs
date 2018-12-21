using System;
using System.Collections.Generic;
using System.Text;
using hotelFlorencia.View;
using hotelFlorencia.Model;
using System.Collections.ObjectModel;

namespace hotelFlorencia.clasesHotel
{
    class restauranteList 
    {
        
        public List<PlatilloModel> verPlatillo()
        {
            var lista = new List<PlatilloModel>();
            lista.Add(new PlatilloModel() { ID = 1, Foto = "http://bstatic.com/images/hotel/max1500_watermarked_standard_bluecom/fe4/fe41bb5f46f12cd4cc53205171adcca3e49b5dba.jpg", Nombre = "Entradas" , Menu="Ver Menu"});
            lista.Add(new PlatilloModel() { ID = 2, Foto = "https://blog.restorando.com/wp-content/uploads/2017/10/shutterstock_617345099-2.jpg", Nombre = "Concteles y Ceviches", Menu = "Ver Menu" });
            lista.Add(new PlatilloModel() { ID = 3, Foto = "http://bstatic.com/images/hotel/max1500_watermarked_standard_bluecom/a22/a22da9a2ce9f9be960b7dfd2f5f4beb23353c16b.jpg", Nombre = "Carnes y Aves", Menu = "Ver Menu" });
            lista.Add(new PlatilloModel() { Foto = "http://bstatic.com/images/hotel/max1500_watermarked_standard_bluecom/a56/a5683c4a1b2e18267bbd3705c51c9ebf7cde256e.jpg", Nombre = "Camarones y Pescado", Menu = "Ver Menu" });
            lista.Add(new PlatilloModel() { Foto = "https://bstatic.com/xdata/w/hotel/max1500_watermarked_standard_bluecom/Ul6EYJehiKqAt2NjYNb7pd7ChHFqKITK5OMpdiCxcFdOSt7qrfcQLiGaTaYoMZV6AIsAtM7SDT1Ra1spTD-u4EqXb8yoxfszc7J6mSuKvXm6I5-cnOE3YRG4AwTZDO-1.jpg", Nombre = "Cortes Especiales", Menu = "Ver Menu" });
            lista.Add(new PlatilloModel() { Foto = "http://bstatic.com/images/hotel/max1500_watermarked_standard_bluecom/d23/d23cf6d25749e514ca1b36fc50eef4efe1141d14.jpg", Nombre = "Parrilladas para Compartir", Menu = "Ver Menu" });
            lista.Add(new PlatilloModel() { Foto = "https://images.clarin.com/2018/05/06/HJwHQ06Tz_1256x620__1.jpg", Nombre = "Bebidas", Menu = "Ver Menu" });
            lista.Add(new PlatilloModel() { Foto = "http://bstatic.com/images/hotel/max1500_watermarked_standard_bluecom/a9e/a9ececcd77e4b211a6023bb2c13bba7d0c4bdcb5.jpg", Nombre = "Postres" , Menu = "Ver Menu" });
            return lista;
        }

       
    }
}
