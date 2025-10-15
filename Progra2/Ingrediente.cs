using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public int Cantidad { get; set; }

        public Ingrediente(string nombre, string unidad, int cantidad)
        {
            Nombre = nombre;
            Unidad = unidad;
            Cantidad = cantidad;
        }
        public Ingrediente(string nombre, int cantidad)
        {
            Nombre = nombre;
            Unidad = "";
            Cantidad = cantidad;
        }

    }
}
