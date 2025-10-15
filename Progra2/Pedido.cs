using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    // ###################################################
    //                SISTEMA DE PEDIDO
    // ###################################################
    public interface IPedido
    {
        string MenuNombre { get; set; }
        int Cantidad { get; set; }
        float PrecioUnitario { get; set; }
    }

    public class Pedido : IPedido
    {
        // Variables globale
        public static List<Pedido> lista_pedidos = new List<Pedido>();
        public static float Total_pedido { get; set; }

        // Variables
        public string MenuNombre { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public List<Ingrediente> Ingredientes_requeridos { get; set; } = new List<Ingrediente>();

        public Pedido(string nombre, int cantidad, float precio, List<Ingrediente> ingredientes)
        {
            MenuNombre = nombre;
            Cantidad = cantidad;
            PrecioUnitario = precio;
            Ingredientes_requeridos = new List<Ingrediente>();

            // Guardar los ingredientes requeridos
            foreach (var ing in ingredientes)
            {
                Ingredientes_requeridos.Add(new Ingrediente(ing.Nombre, ing.Unidad, ing.Cantidad * cantidad));
            }
        }


        public static DataTable ObtenerElementos()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Ingrediente", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio Unitario", typeof(float));

            foreach (Pedido p in lista_pedidos) { dt.Rows.Add(p.MenuNombre, p.Cantidad, p.PrecioUnitario); }
            return dt;
        }

        // ============================================================
        //                 ACTUALIZACIÓN
        // ============================================================
        public static void Actualizar_Tabla(DataGridView tabla_pedido) { tabla_pedido.DataSource = ObtenerElementos(); }

        // Actualizar el precio total del pedido
        public static void Actualizar_Total(Label texto_total)
        {
            // Variable temporal
            float total_final = 0;
            // Recorre cada elemento del pedido y le suma su precio unitario
            foreach (Pedido pedido in Pedido.lista_pedidos)
            {
                total_final += pedido.PrecioUnitario * pedido.Cantidad;
            }
            Total_pedido = total_final;
            texto_total.Text = "Total: " + total_final.ToString();
        }

        // ============================================================
        //                       STOCK
        // ============================================================
        internal static void Descontar_Stock(List<Ingrediente> ingredientes)
        {
            // Por cada ingrediente requerido
            foreach (Ingrediente req in ingredientes)
            {
                // Lo busca en el stock para descontarlo
                foreach (Ingrediente ing in Stock.lista_ingredientes)
                {
                    if (ing.Nombre == req.Nombre && (ing.Unidad == req.Unidad || ing.Unidad == ""))
                    {
                        // Descuenta la cantidad en el stock
                        ing.Cantidad -= req.Cantidad;
                        if (ing.Cantidad < 0) ing.Cantidad = 0;
                        break;
                    }
                }
            }
        }

        // ============================================================
        //                        PEDIDO
        // ============================================================
        public static void Añadir_Pedido(string nombre, int cantidad, float precio, DataGridView tabla_pedido, List<Ingrediente> ingredientes)
        {
            lista_pedidos.Add(new Pedido(nombre, cantidad, precio, ingredientes));
            Actualizar_Tabla(tabla_pedido);
        }

        public static void Eliminar_pedido(string nombre_menu, DataGridView tabla_stock, DataGridView tabla_pedido, Label texto_total)
        {
            for (int i = 0; i < lista_pedidos.Count; i++)
            {
                // Busca el pedido a través del nombre
                if (lista_pedidos[i].MenuNombre == nombre_menu)
                {
                    // Devolver los ingredientes al stock
                    foreach (Ingrediente ing in lista_pedidos[i].Ingredientes_requeridos)
                    {
                        Stock.agregar_ingrediente(new Ingrediente(ing.Nombre, ing.Unidad, ing.Cantidad));
                    }
                    Stock.actualizar_tabla(tabla_stock);
                    Pedido.Actualizar_Tabla(tabla_pedido);
                    Pedido.Actualizar_Total(texto_total);
                    // Eliminar columna
                    lista_pedidos.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
