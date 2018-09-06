using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauramte
{
    class Platillo
    {

        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }

        public List<Ingrediente> Ingredientes { get; set; }

        public Platillo(string nombre, string identificador, string descripcion, float precio)
        {
            Nombre = nombre;
            Identificador = identificador;
            Descripcion = descripcion;

            if (precio < 50)
            {
                Precio = precio;
            }
            

        }

        public Platillo()
        {
            Ingredientes = new List<Ingrediente>();
        }


    }
}
