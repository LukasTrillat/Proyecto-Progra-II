using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;

namespace Progra2
{
    public static class PDF_manager
    {
        // ------------------ GENERAR BOLETA -----------------------------
        public static string generar_boleta(List<Pedido> pedidos)
        {
            string ruta = Path.Combine(Path.GetTempPath(), "boleta.pdf");

            // Crear documento y abrirlo
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open();

            // Construcción del pdf
            doc.Add(new Paragraph("BOLETA DE PEDIDOS"));
            doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("g"))); // g - fecha corta + hora corta
            doc.Add(new Paragraph(" "));
            PdfPTable tabla = new PdfPTable(3);
            tabla.AddCell("Ingrediente");
            tabla.AddCell("Cantidad");
            tabla.AddCell("Precio Unitario");

            foreach (var p in pedidos)
            {
                tabla.AddCell(p.MenuNombre);
                tabla.AddCell(p.Cantidad.ToString());
                tabla.AddCell(p.PrecioUnitario.ToString());
            }

            doc.Add(tabla);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("TOTAL: $" + Pedido.Total_pedido.ToString()));

            doc.Close();
            return ruta;
        }

        // ------------------ MOSTRAR BOLETA -----------------------------
        public static void mostrar_boleta(string rutaPDF, WebBrowser visor)
        {
            if (File.Exists(rutaPDF))
            {
                MessageBox.Show(rutaPDF);
                visor.Navigate(rutaPDF);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la boleta para mostrar.");
            }
        }

        // ------------------ GENERAR MENU -----------------------------
        public static string generar_menu(List<Menu> menus)
        {
            string ruta = Path.Combine(Path.GetTempPath(), "CartaRestaurante.pdf");

            // Crear documento y abrirlo
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open();

            // Estructura del PDF
            doc.Add(new Paragraph("CARTA DEL RESTAURANTE"));
            doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("g"))); // g - fecha corta + hora corta
            doc.Add(new Paragraph(" "));

            PdfPTable tabla = new PdfPTable(2);
            tabla.AddCell("Nombre del Plato");
            tabla.AddCell("Precio");

            foreach (var menu in menus)
            {
                tabla.AddCell(menu.Nombre);
                tabla.AddCell(menu.Precio.ToString());
            }

            doc.Add(tabla);
            doc.Close();

            return ruta;
        }
    }
}
