using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using hotelFlorencia.Model;

namespace hotelFlorencia.ViewModel
{
  public  class DetailMenuViewModel:BaseViewModel
    {
        
      public MenuElement MenuElement { get; set; }

        public DetailMenuViewModel( MenuElement menu)
        {
            this.MenuElement = menu;
            GetPlato();
        }

        

        public DetailMenuViewModel()
        {
          
        }

        private void GetPlato()
        {
            switch (MenuElement.Tipo)
            {
                case MenuType.Entradas:
                    GenerarEntradasMenu();
                    break;
                case MenuType.CoctelesCeviches:
                    GenerarMarMenu();
                    break;
                case MenuType.CarnesAves:
                    GenerarCarnesMenu();
                    break;
                case MenuType.CamaronesYPescado:
                    GenerarMariscosMenu();
                    break;
                case MenuType.CortesEspeciales:
                    GenerarCortesMenu();
                    break;
                case MenuType.Parrilladas:
                    GenerarParrilladasMenu();
                    break;
                case MenuType.Bebidas:
                    GenerarBebidasMenu();
                    break;
                case MenuType.Postres:
                    GenerarPostresMenu();
                    break;
                default:
                    break;
            }
        }
       
        public ObservableCollection<Plato> Platos { get; set; } 
        private void GenerarEntradasMenu()
        {
            Platos = new ObservableCollection<Plato>
            {
                new Plato{Image= "Entradas.jpg", Nombre="Bombones de Pollo",Price="$5.95", Description="Delicioso bombones de Pollo empanizados, acompañados en salsa BBQ y Tartara."},
                new Plato{Image= "Entradas.jpg", Nombre="Pollo en Salsa de Hongos",Price="$13.50", Description="Es un exquisito filete de pollo en salsa de champiñones al vino tinto, acompañado de vegetales tipo oriental, arroz ecuatoriano."},
                new Plato{Image= "Entradas.jpg", Nombre="Hongos al Ajio",Price="$4.95", Description="Sabrosos hongos gratinados con queso mozzarella."},
                new Plato{Image= "Entradas.jpg", Nombre="Entrada Tipica",Price="$4.95", Description="Chorizo argentino, frijoles, guacamole y tortilla frita salvadoreña."},
                new Plato{Image= "Entradas.jpg", Nombre="Picada Canela",Price="$6.95", Description="Trocitos de carne y de pollo empanizados acompañados de salsa BBQ y Tartara."},
                new Plato{Image= "Entradas.jpg", Nombre="Quezadilla Brasador",Price="$3.95", Description="Suave tortilla de harina, rellenas de Queso mozzarella, jamon y aguacate."}
               
            };
        }
        private void GenerarMarMenu()
        {
            Platos = new ObservableCollection<Plato>
            {
                new Plato{Image= "Coctel.jpg", Nombre="Coctel de Camarones",Price="$5.95",Price2="$8.95"},
                new Plato{Image= "Coctel.jpg", Nombre="Conchas",Price="$5.95",Price2="$8.95"},
                new Plato{Image= "Coctel.jpg", Nombre="Camaron en Salsa Rosada",Price="$6.95",Price2="$8.95"},
                new Plato{Image= "Coctel.jpg", Nombre="Camaron en Salsa Roja",Price="$6.95",Price2="$8.95"},
                new Plato{Image= "Coctel.jpg", Nombre="Camaron en Salsa Rosada y Aguacate",Price="$7.95",Price2="$8.95"},
                new Plato{Image= "Coctel.jpg", Nombre="Conchas-Camaron",Price="$7.50",Price2="$7.95"},
                new Plato{Image= "Coctel.jpg", Nombre="Conchas-Calamar",Price="$7.50",Price2="$7.95"},
                new Plato{Image= "Coctel.jpg", Nombre="Camaron - Calamar",Price="$7.50",Price2="$7.95"},              
                new Plato{Image= "Coctel.jpg", Nombre="Conchas - Ceviche  de Pescado",Price="$7.50",Price2="$8.25"},              
                new Plato{Image= "Coctel.jpg", Nombre="Conchas - Camaron - Calamar",Price2="$8.25"},              
                new Plato{Image= "Coctel.jpg", Nombre="Conchas - Camaron - Pescado",Price2="$8.25"},              
                new Plato{Image= "Coctel.jpg", Nombre="Ceviche Florencia en Salsa roja Gourmet",Price2="$8.95"}              
            };
        }
        private void GenerarCarnesMenu()
        {
            Platos = new ObservableCollection<Plato>
            {
            new Plato { Image = "Carnes.jpg", Nombre = "Lomo a la Parrilla", Price = "$8.55", Price2 = "12.45" },
            new Plato { Image = "Carnes.jpg", Nombre = "Filete de Pollo a la Parrilla", Price = "$7.95", Price2 = "12.05" },
            new Plato { Image = "Carnes.jpg", Nombre = "Puyaso Importado", Price = "$8.55", Price2 = "12.45" },
            new Plato { Image = "Carnes.jpg", Nombre = "Fajitas de Res", Price = "$8.55", Price2 = "12.45" },
            new Plato { Image = "Carnes.jpg", Nombre = "Lomo de Cerdo Importado", Price = "$8.55", Price2 = "12.45" },
            new Plato { Image = "Carnes.jpg", Nombre = "Lomo de aguja a la parrilla", Price = "$10.95", Price2 = "12.45" },
            new Plato { Image = "Carnes.jpg", Nombre = "Churrasco el Brasador",  Price2 = "10.55" }
            };           
        }
        private void GenerarMariscosMenu()
        {
            Platos = new ObservableCollection<Plato>
            {
                new Plato{Image= "Camarones.jpg", Nombre="Filete de Pescado",Price="$10.95", Price2="14.95", Description="A su gusto: Al ajio, empanizado o a la parrilla."},              
                new Plato{Image= "Camarones.jpg", Nombre="Camarones",Price="$10.95", Description="A su gusto: Al ajio, BBQ, empanizado o a la parrilla."},              
                new Plato{Image= "Camarones.jpg", Nombre="Pescado frito entero",Price2="$8.25", Description="A su gusto: Al ajio, BBQ, empanizado o a la parrilla."} 
            };
        }
        private void GenerarCortesMenu()
        {
            Platos = new ObservableCollection<Plato>
            {
                new Plato{Image= "Cortes.jpg", Nombre="Punta Jalapeña",Price="13.95", Description="9 onzas del mejor corte de lomo de aguja, con su tradicional salsa jalapeña."},
                new Plato{Image= "Cortes.jpg", Nombre="Mixto Florencia",Price="$13.95", Description="Combinacion de lomo de aguja y pollo a la parrilla."},
                new Plato{Image= "Cortes.jpg", Nombre="Mar y Tierra",Price="$14.95", Description="Camarones y lomo de aguja a la parrilla."},
                new Plato{Image= "Cortes.jpg", Nombre="Medallones en Salsa Marcelo",Price="$16.95", Description="Deliciosos medallones de filete de pollo, lomo de aguja, y camarones a la parrilla."}
            };
        }
        private void GenerarParrilladasMenu()
        {
            Platos = new ObservableCollection<Plato>
            {
                new Plato{Image= "Parrilladas.jpg", Nombre="Parrillada de Cerdo", Price="19.95 ($6.65 por persona)", Description="1 1/2 Libra de Cerdo a la Parrilla"},
                new Plato{Image= "Parrilladas.jpg", Nombre="Parrillada de pollo", Price="19.95 ($6.65 por persona)", Description="1 1/2 Libra de Pollo a la Parrilla" },
                new Plato{Image= "Parrilladas.jpg", Nombre="Parrillada La Estancia", Price="23.95 ($7.98 por persona)", Description="3/4 Libra de Puyazo, 3/4 libra de Pollo"},
                new Plato{Image= "Parrilladas.jpg", Nombre="Parrillada el Brasador", Price="24.95 (8.31 por persona)" , Description="1/2 libra de Puyazo, 1/2 libra de Pollo, 1/2 libra de Cerdo"},
                new Plato{Image= "Parrilladas.jpg", Nombre="Parrillada Gaucha", Price="24.95 (8.31 por persona)" , Description="1 1/2 libra de Puyazo Importado"},
                new Plato{Image= "Parrilladas.jpg", Nombre="Parrillada Argentina", Price="25.95 ($8.65 por persona)", Description="1/2 libra de Lomo, 1/2 libra de Pollo, 1/2 libra de Cerdo, dos Chorizos argentinos"},
                new Plato{Image= "Parrilladas.jpg", Nombre="Super parrillada Brasador", Price="31.95 ($7.98 por persona)", Description="1/2 libra de lomo, 1/2 libra de pollo, 1/2 libra de cerdo, 1 libra de costilla de cerdo"},
                new Plato{Image= "Parrilladas.jpg", Nombre="Super parrillada Gaucha", Price="35.95 ($8.98 por persona)", Description="1/2 libra de lomo, 1/2 libra de pollo, 1/2 libra de cerdo, 1/2 libra de Camaron, dos chorizos argentinos"}
               
            };
        }
        private void GenerarBebidasMenu()
        {
            Platos = new ObservableCollection<Plato>
            {
                new Plato{Image= "Bebidas.jpg", Nombre="Piña colada sin licor", Price="$2.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Piña colada con licor", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Cuba Libre", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Tom Collins", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Conga Jalisco", Price="$2.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Conga sin Licor", Price="$2.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Margarita", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Planter Pouch", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Daikiry", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Screwdriver", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="angria", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Bloody Mary", Price="$3.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Cerverzas", Price="$1.55", Price2="2.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Vino", Price="$2.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Gaseosas", Price="$1.55"},
                new Plato{Image= "Bebidas.jpg", Nombre="Limonadas", Price="$1.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Limonada con Soda", Price="$1.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Naranjada", Price="$1.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Naranjada con Soda", Price="$1.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Refrescos Natural", Price="$1.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Jugo de Naranja", Price="$1.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Te Helado", Price="$1.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Frozen", Price="$2.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Pichel de gaseosa", Price="$4.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Pichel de Naranjada", Price="$4.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Pichel de Limonada", Price="$4.75"},
                new Plato{Image= "Bebidas.jpg", Nombre="Pichel de Te helado", Price="5.25"},
                new Plato{Image= "Bebidas.jpg", Nombre="Ron, Whisky, Vodka (de barra)", Price="$2.95", Price2="$4.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Ron, Vodka Premium", Price="$3.55", Price2="$4.75" },
                new Plato{Image= "Bebidas.jpg", Nombre="Whisky Cinta Negra", Price="$4.95", Price2="$7.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Chivas Regal", Price="$4.95", Price2="$7.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Tequila José Cuervo", Price="$2.95", Price2="$4.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Tequila 1800, Herradura", Price="$4.95", Price2="$6.95"},
                new Plato{Image= "Bebidas.jpg", Nombre="Crema Digestiva (Roca ó Frapé)", Price="$3.55", Price2="$4.75"},                
            };
        }
        private void GenerarPostresMenu()
        {
            Platos = new ObservableCollection<Plato>
            {
                new Plato{Image= "Postres.jpg", Nombre="Flan de Queso", Price="$2.30"},
                new Plato{Image= "Postres.jpg", Nombre="Flan de Caramelo", Price="$2.30"},
                new Plato{Image= "Postres.jpg", Nombre="Pastel de Higo", Price="$2.30"},
                new Plato{Image= "Postres.jpg", Nombre="Tres Leches", Price="$2.30"},
                new Plato{Image= "Postres.jpg", Nombre="Pastel de Queso", Price="$2.30"},
                new Plato{Image= "Postres.jpg", Nombre="Cocktail de Frutas", Price="$2.30"},
               
            };
        }
    }
}
