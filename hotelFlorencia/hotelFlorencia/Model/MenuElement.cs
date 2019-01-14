using System;
using System.Collections.Generic;
using System.Text;

namespace hotelFlorencia.Model
{
   public class MenuElement
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Plato> platos { get; set; }
        public MenuType Tipo{ get; set; }
    }
    public enum MenuType
    {
        Entradas, CoctelesCeviches, CarnesAves,CamaronesYPescado, CortesEspeciales,Parrilladas, Bebidas, Postres }


}