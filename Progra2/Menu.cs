using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Menu
    {
        public static List<Menu> Menus = new List<Menu>();

        public string Nombre {  get; set; }
        public Button Boton { get; set; } = new Button();
        public float Precio { get; set; }
        public List<Ingrediente> Ingredientes_requeridos { get; set; } = new List<Ingrediente>();


        public Menu(string nombre, float precio, List<Ingrediente> ingredientes, Button boton)
        {
            Nombre = nombre;
            Precio = precio;
            Ingredientes_requeridos = ingredientes;
            Boton = boton;

            Menus.Add(this);
        }

        public bool Esta_disponible()
        {
            bool ok = false;
            foreach (Ingrediente req in this.Ingredientes_requeridos)
            {
                ok = false;
                foreach(Ingrediente ing in Stock.lista_ingredientes)
                {
                    if (ing.Nombre == req.Nombre && (ing.Unidad == req.Unidad || ing.Unidad == "") && ing.Cantidad >= req.Cantidad)
                    {
                        ok = true;
                        break;
                    }
                }
                if (!ok) { return false; }
            }
            return true;
        }
    
    }

}
