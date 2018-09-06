using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauramte
{
    class Menu
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public int HoradeInicio { get; set; }
        public int HoradeFin { get; set; }

        public List<Platillo> Platillos;

        public Menu()
        {
            Nombre = "Nuevo Menu";
            Identificador = "1236";
            HoradeInicio = 7;
            HoradeFin = 10;
            Platillos = new List<Platillo>();

        }

    }
}
