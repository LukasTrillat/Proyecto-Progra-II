using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal static class Stock
    {
        public static List<Ingrediente> lista_ingredientes { get; set; } = new List<Ingrediente>();

        public static void agregar_ingrediente(Ingrediente ingrediente)
        {
            for (int i = 0; i < lista_ingredientes.Count; i++)
            {
                if (lista_ingredientes[i].Nombre == ingrediente.Nombre)
                {
                    lista_ingredientes[i].Cantidad += ingrediente.Cantidad;
                    return;
                }
            }
            lista_ingredientes.Add(ingrediente); 
        }

        public static void eliminar_ingrediente(string nombre_ingrediente)
        {
            for (int i = 0; i < lista_ingredientes.Count; i++)
            {
                if (lista_ingredientes[i].Nombre == nombre_ingrediente)
                {
                    lista_ingredientes.RemoveAt(i);
                    break;
                }
            }
        }
    
        public static DataTable obtener_elementos()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Unidad", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));

            foreach (Ingrediente ing in lista_ingredientes)
            {
                dt.Rows.Add(ing.Nombre, ing.Unidad, ing.Cantidad);
            }

            return dt;
        }
    
        public static void actualizar_tabla(DataGridView tabla)
        { tabla.DataSource = Stock.obtener_elementos(); }
    }
}
