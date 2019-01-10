using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using hotelFlorencia.Model;

namespace hotelFlorencia.ViewModel
{
   public class NegociosViewModel
    {
        private ObservableCollection<Negocios> negocios_BF;
        public ObservableCollection<Negocios> negocios
        {
            get { return negocios_BF; }
            set { negocios_BF = value; }

        }
        public NegociosViewModel()
        {
            negocios = GetNegociosData();
        }

        private ObservableCollection<Negocios> GetNegociosData()
        {
            return new ObservableCollection<Negocios>
            {
                new Negocios{Image="NegociosImage.jpg", Name="Reuniones de Negocios"},
                
            };
        }
    }
}
