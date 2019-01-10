using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using hotelFlorencia.Model;
namespace hotelFlorencia.ViewModel
{
   public class HabitacionViewModel
    {
        private ObservableCollection<Habitacion> habitacion_BF;
        public ObservableCollection<Habitacion> habitacion
        {
            get { return habitacion_BF; }
            set { habitacion_BF = value; }
        }

        public HabitacionViewModel()
        {
            habitacion = GetHabitacionesHotel();
        }

        private ObservableCollection<Habitacion> GetHabitacionesHotel()
        {
            return new ObservableCollection<Habitacion>
            {
                new Habitacion { Image = "Suit.jpg", Name = "Habitacion de Lujo" },
                new Habitacion { Image = "HabitacionDoble.jpg", Name = "Habitacion Doble" },
                new Habitacion { Image = "HabitacionTriple.jpg", Name = "Habitacion Triple" }
            };
        }
    }
}
