using System.Data;
using System.IO;
using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Progra2
{
    public partial class Form1 : Form
    {
        // Instancias de WebView2 para mostrar PDFs
        private WebView2 pdfViewerBoleta;
        private WebView2 pdfViewerCarta;

        public Form1()
        {
            InitializeComponent();
            InicializarMenus();
            Configurar_botones_de_menu(texto_total);

            // == Panel Boleta ==
            pdfViewerBoleta = new WebView2();
            pdfViewerBoleta.Dock = DockStyle.Fill;
            panel_boleta_pdf.Controls.Add(pdfViewerBoleta);

            // == Panel Carta ==
            pdfViewerCarta = new WebView2();
            pdfViewerCarta.Dock = DockStyle.Fill;
            panel_carta_pdf.Controls.Add(pdfViewerCarta);
        }


        // ---------CARGA DE INGREDIENTES --------- //

        //Almacena los datos del ultimo .csv cargado
        public DataTable tabla_cargada_actual;
        
        private DataTable CargarCsvComoDataTable(string rutaCsv)
        // Lectura de CSV y conversión a DataTable
        {
            DataTable dt = new DataTable();
            string[] lineas = File.ReadAllLines(rutaCsv);

            if (lineas.Length > 0)
            {
                //Lectura de encabezados
                string[] encabezados = lineas[0].Split(',');
                foreach (string encabezado in encabezados)
                { dt.Columns.Add(encabezado.Trim()); }

                //Lectura de lineas
                foreach (string linea in lineas.Skip(1))
                {
                    string[] celdas = linea.Split(",");
                    dt.Rows.Add(celdas);
                }
            }
            return dt;
        }
        private void boton_cargar_csv_Click(object sender, EventArgs e)
        {
            //Al presionar el botónde "Cargar CSV" se abre un dialogo (input de archivo) para cargar un .csv
            using (OpenFileDialog fileInput = new OpenFileDialog()
            {
                //Parametros del dialogo
                Filter = "Archivos CSV (*.csv)|*.csv",
                Title = "Selecciona un archivo CSV"
            })
            {

                // Al recibir el archivo, crear una ruta con su nombre, cargar la función para leer sus datos 
                // y asignarlos a la tabla de ingredientes disponibles
                if (fileInput.ShowDialog() == DialogResult.OK)
                {
                    string ruta = fileInput.FileName;
                    tabla_cargada_actual = CargarCsvComoDataTable(ruta); //Actualización de tabla cargada
                    tabla_ingredientes_cargados.DataSource = tabla_cargada_actual; //Actualización de tabla visual
                }
            }
        }
        private void boton_agregar_stock_Click(object sender, EventArgs e)
        {
            if (tabla_cargada_actual != null)
            {
                //Carga los ingredientes de la tabla cargada al stock
                foreach (DataRow fila in tabla_cargada_actual.Rows)
                {
                    string nombre = fila[0]?.ToString() ?? "";
                    string unidad = fila[1]?.ToString() ?? "";
                    int cantidad = Convert.ToInt32(fila[2]);

                    Stock.agregar_ingrediente(new Ingrediente(nombre, unidad, cantidad));
                }

                //Actualización visual de tabla de stock
                Stock.actualizar_tabla(tabla_stock);
                MessageBox.Show($"Stock actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --------- MANEJO DE STOCK --------- //
        private void boton_eliminar_ingrediente_Click(object sender, EventArgs e)
        {
            if (tabla_stock.CurrentRow != null)
            {
                DataGridViewRow fila = tabla_stock.CurrentRow;
                Stock.eliminar_ingrediente(nombre_ingrediente: fila.Cells[0].Value.ToString());
                Stock.actualizar_tabla(tabla_stock);
            }
        }
        private void boton_ingresar_ingrediente_Click(object sender, EventArgs e)
        {
            string nombre = input_nombre_ingrediente.Text.Trim();
            string unidad = input_unidad_ingrediente.Text.Trim();
            string cantidadTexto = input_cantidad_ingrediente.Text.Trim();

            // Validar nombre
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Any(char.IsDigit))
            {
                MessageBox.Show("Ingrese un nombre válido (solo texto).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar unidad
            if (string.IsNullOrWhiteSpace(unidad) || unidad.Any(char.IsDigit))
            {
                MessageBox.Show("Ingrese una unidad válida (solo texto).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar cantidad
            if (!int.TryParse(cantidadTexto, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad numérica válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar ingrediente
            Stock.agregar_ingrediente(new Ingrediente(nombre, unidad, cantidad));
            Stock.actualizar_tabla(tabla_stock);

            input_nombre_ingrediente.Clear();
            input_unidad_ingrediente.Clear();
            input_cantidad_ingrediente.Clear();
        }
        private void InicializarMenus()
        {
            Menu Papas_fritas = new Menu(
                nombre: "Papas Fritas",
                precio: 500,
                ingredientes: new List<Ingrediente>
                {
                    new Ingrediente("Papas", "kg", 5)
                },
                boton: boton_papas_fritas
            );
            Menu Pepsi = new Menu(
                nombre: "Pepsi",
                precio: 1100,
                ingredientes: new List<Ingrediente>
                {
                    new Ingrediente("Pepsi", "unid", 1)
                },
                boton: boton_pepsi
            );
            Menu Completo = new Menu(
                nombre: "Completo",
                precio: 1800,
                ingredientes: new List<Ingrediente>
                {
                    new Ingrediente("Vienesa", "unid", 1),
                    new Ingrediente("Pan de completo", "unid", 1),
                    new Ingrediente("Tomate", "kg", 1),
                    new Ingrediente("Palta", "kg", 1)
                },
                boton: boton_completo
            );
            Menu Hamburguesa = new Menu(
                nombre: "Hamburguesa",
                precio: 3500,
                ingredientes: new List<Ingrediente>
                {
                    new Ingrediente("Pan de hamburguesa", "unid", 1),
                    new Ingrediente("Lamina de queso", "unid", 1),
                    new Ingrediente("Churrasco de carne", "unid", 1)
                },
                boton: boton_hamburguesa
            );
            Menu Panqueques = new Menu(
                nombre: "Panqueques",
                precio: 2000,
                ingredientes: new List<Ingrediente>
                {
                    new Ingrediente("Panqueque", "unid", 2),
                    new Ingrediente("Manjar", 1),
                    new Ingrediente("Azucar flor", 1)
                },
                boton: boton_panqueques
            );
            Menu Pollo_frito = new Menu(
                nombre: "Pollo Frito",
                precio: 2800,
                ingredientes: new List<Ingrediente>
                {
                    new Ingrediente("Presa de pollo", "unid", 1),
                    new Ingrediente("Porción de harina", 1),
                    new Ingrediente("Porción de aceite", 1)
                },
                boton: boton_pollo_frito
            );
            Menu Ensalada_mixta = new Menu(
                nombre: "Ensalada Mixta",
                precio: 1500,
                ingredientes: new List<Ingrediente>
                {
                    new Ingrediente("Lechuga", 1),
                    new Ingrediente("Tomate", "kg", 1),
                    new Ingrediente("Zanahoria rallada", "unid", 1)
                },
                boton: boton_ensalada_mixta
            );
        }
        private void boton_generar_menu_Click(object sender, EventArgs e)
        // Actualiza la disponibilidad de los botones de menú
        {
            foreach (Menu menu in Menu.Menus)
            {
                if (menu.Esta_disponible() == true)
                {
                    menu.Boton.Visible = true;
                }
                else
                {
                    menu.Boton.Visible = false;
                }
            }
        }

        // --------- MANEJO DE PEDIDO --------- //
        private void boton_eliminar_pedido_Click(object sender, EventArgs e)
        {
            if (tabla_pedido.CurrentRow != null)
            {
                DataGridViewRow fila = tabla_pedido.CurrentRow;
                Pedido.Eliminar_pedido(nombre_menu: fila.Cells[0].Value.ToString(), tabla_stock, tabla_pedido, texto_total);
                Pedido.Actualizar_Tabla(tabla_pedido);
            }
        }
        private void Configurar_botones_de_menu(Label text_label)
        {
            foreach (Menu menu in Menu.Menus)
            {
                menu.ConfigurarBoton(tabla_pedido, tabla_stock, texto_total);
            }
        }


        // ------------------ GENERAR BOLETA -----------------------------
        private void boton_generar_boleta_Click(object sender, EventArgs e)
        {
            // Genera el PDF y guarda la ruta
            string rutaPDF = PDF_manager.generar_boleta(Pedido.lista_pedidos);

            if (File.Exists(rutaPDF))
                MessageBox.Show("Boleta generada en: " + rutaPDF);
            else
                MessageBox.Show("No se pudo generar la boleta.");
        }

        // ------------------ MOSTRAR BOLETA -----------------------------
        private async void boton_mostrar_boleta_Click(object sender, EventArgs e)
        {
            string rutaPDF = PDF_manager.generar_boleta(Pedido.lista_pedidos);

            if (File.Exists(rutaPDF))
            {
                await pdfViewerBoleta.EnsureCoreWebView2Async();
                pdfViewerBoleta.CoreWebView2.Navigate(rutaPDF);
            }
            else
            {
                MessageBox.Show("No se pudo generar la boleta.");
            }
        }

        // ------------------ GENERAR MENU -----------------------------
        private async void boton_generar_carta_Click(object sender, EventArgs e)
        {
            // Generar PDF
            string rutaPDF = PDF_manager.generar_menu(Menu.Menus);

            if (File.Exists(rutaPDF))
            {
                // Convertir la ruta a formato de URL local
                string rutaURL = "file:///" + rutaPDF.Replace("\\", "/");

                // Asegurar que WebView2 esté inicializado
                await pdfViewerCarta.EnsureCoreWebView2Async();

                // Navegar al archivo PDF
                pdfViewerCarta.CoreWebView2.Navigate(rutaURL);
            }
            else
            {
                MessageBox.Show("No se pudo generar el PDF.");
            }
        }
    }

}