using hotelFlorencia.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace hotelFlorencia.clasesHotel
{
    public class aboutList
    {
        public List<AboutModel> aboutlist()
        {
            var lista =  new List<AboutModel>();
            lista.Add(new AboutModel() { Mision = "Dar a nuestros clientes la mejor experiencia al comer fuera, garantizando la calidad y el sabor único", Vision = "Ser la empresa líder a nivel regional en el negocio de Restaurantes tipo Steak House.", Imagen = "https://s-ec.bstatic.com/images/hotel/max1024x768/117/117177324.jpg" });
            return lista;
        }

    }
}
