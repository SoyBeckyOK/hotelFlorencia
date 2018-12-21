using hotelFlorencia.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace hotelFlorencia.clasesHotel
{
   public class ContactList
    {
        public List<ContactModel> GetContacts()
        {
            var listacontacto = new List<ContactModel>();
            listacontacto.Add(new ContactModel() { ImageUrl = "https://s-ec.bstatic.com/images/hotel/max1024x768/117/117177324.jpg",  ShortDescription = "Hotel Florencia SM", Name="Facebook" });
            listacontacto.Add(new ContactModel() { ImageUrl = "https://s-ec.bstatic.com/images/hotel/max1024x768/117/117177324.jpg", ShortDescription = "HotelFlorencia", Name="Instagram"});
            listacontacto.Add(new ContactModel() { ImageUrl = "https://s-ec.bstatic.com/images/hotel/max1024x768/117/117177324.jpg", ShortDescription = "7521-2524" , Name="Telefono"});
            listacontacto.Add(new ContactModel() { ImageUrl = "https://tareasflorentino.files.wordpress.com/2017/04/icono-correo.jpg", ShortDescription = "sjkajs@jdksaj.com", Name= "Correo Electronico" });
            return listacontacto;

        }
    }
}
