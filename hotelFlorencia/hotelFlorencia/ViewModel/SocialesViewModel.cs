using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using hotelFlorencia.Model;
namespace hotelFlorencia.ViewModel
{
   public class SocialesViewModel
    {
        private ObservableCollection<Sociales> Sociales_BF;
        public ObservableCollection<Sociales> sociales
        {

            get { return Sociales_BF; }
            set { Sociales_BF = value; } 
        }
        public SocialesViewModel()
        {
            sociales = GetEventosSociales();
        }

        private ObservableCollection<Sociales> GetEventosSociales()
        {
            return new ObservableCollection<Sociales>
            {
                 new Sociales { Image = "bodas.jpg", Name = "Bodas" },
                 new Sociales { Image = "bodas.jpg", Name = "Fiesta Rosa" },
                 new Sociales { Image = "bodas.jpg", Name = "Graduaciones" },
                 new Sociales { Image = "bodas.jpg", Name = "Reuniones Religiosas" }
            };
           
        }
    }
}
