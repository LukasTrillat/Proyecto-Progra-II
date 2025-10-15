namespace Progra2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            boleta = new TabPage();
            panel_boleta_pdf = new Panel();
            boton_mostrar_boleta = new Button();
            pedido = new TabPage();
            tabla_pedido = new DataGridView();
            boton_ensalada_mixta = new Button();
            texto_total = new Label();
            boton_eliminar_pedido = new Button();
            boton_generar_boleta = new Button();
            boton_pollo_frito = new Button();
            boton_panqueques = new Button();
            boton_hamburguesa = new Button();
            boton_pepsi = new Button();
            boton_completo = new Button();
            boton_papas_fritas = new Button();
            carta_restorante = new TabPage();
            panel_carta_pdf = new Panel();
            boton_generar_carta = new Button();
            stock = new TabPage();
            tabla_stock = new DataGridView();
            panel2 = new Panel();
            boton_generar_menu = new Button();
            boton_eliminar_ingrediente = new Button();
            panel1 = new Panel();
            boton_ingresar_ingrediente = new Button();
            label4 = new Label();
            input_cantidad_ingrediente = new TextBox();
            label3 = new Label();
            input_unidad_ingrediente = new TextBox();
            label2 = new Label();
            input_nombre_ingrediente = new TextBox();
            carga_ingredientes = new TabPage();
            tabla_ingredientes_cargados = new DataGridView();
            boton_agregar_stock = new Button();
            label1 = new Label();
            boton_cargar_csv = new Button();
            tabControl1 = new TabControl();
            folderBrowserDialog1 = new FolderBrowserDialog();
            boleta.SuspendLayout();
            pedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_pedido).BeginInit();
            carta_restorante.SuspendLayout();
            stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_stock).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            carga_ingredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_ingredientes_cargados).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // boleta
            // 
            boleta.Controls.Add(panel_boleta_pdf);
            boleta.Controls.Add(boton_mostrar_boleta);
            boleta.Location = new Point(4, 24);
            boleta.Margin = new Padding(3, 2, 3, 2);
            boleta.Name = "boleta";
            boleta.Size = new Size(693, 583);
            boleta.TabIndex = 4;
            boleta.Text = "Boleta";
            boleta.UseVisualStyleBackColor = true;
            // 
            // panel_boleta_pdf
            // 
            panel_boleta_pdf.Location = new Point(44, 69);
            panel_boleta_pdf.Name = "panel_boleta_pdf";
            panel_boleta_pdf.Size = new Size(596, 459);
            panel_boleta_pdf.TabIndex = 1;
            // 
            // boton_mostrar_boleta
            // 
            boton_mostrar_boleta.Location = new Point(253, 18);
            boton_mostrar_boleta.Name = "boton_mostrar_boleta";
            boton_mostrar_boleta.Size = new Size(169, 23);
            boton_mostrar_boleta.TabIndex = 0;
            boton_mostrar_boleta.Text = "Mostrar boleta (PDF)";
            boton_mostrar_boleta.UseVisualStyleBackColor = true;
            boton_mostrar_boleta.Click += boton_mostrar_boleta_Click;
            // 
            // pedido
            // 
            pedido.Controls.Add(tabla_pedido);
            pedido.Controls.Add(boton_ensalada_mixta);
            pedido.Controls.Add(texto_total);
            pedido.Controls.Add(boton_eliminar_pedido);
            pedido.Controls.Add(boton_generar_boleta);
            pedido.Controls.Add(boton_pollo_frito);
            pedido.Controls.Add(boton_panqueques);
            pedido.Controls.Add(boton_hamburguesa);
            pedido.Controls.Add(boton_pepsi);
            pedido.Controls.Add(boton_completo);
            pedido.Controls.Add(boton_papas_fritas);
            pedido.Location = new Point(4, 24);
            pedido.Margin = new Padding(3, 2, 3, 2);
            pedido.Name = "pedido";
            pedido.Size = new Size(693, 583);
            pedido.TabIndex = 3;
            pedido.Text = "Pedido";
            pedido.UseVisualStyleBackColor = true;
            // 
            // tabla_pedido
            // 
            tabla_pedido.AllowUserToAddRows = false;
            tabla_pedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_pedido.Location = new Point(7, 265);
            tabla_pedido.Margin = new Padding(3, 2, 3, 2);
            tabla_pedido.Name = "tabla_pedido";
            tabla_pedido.RowHeadersWidth = 51;
            tabla_pedido.Size = new Size(680, 269);
            tabla_pedido.TabIndex = 10;
            // 
            // boton_ensalada_mixta
            // 
            boton_ensalada_mixta.Image = Properties.Resources.icono_ensalada_64x64;
            boton_ensalada_mixta.Location = new Point(409, 134);
            boton_ensalada_mixta.Margin = new Padding(3, 2, 3, 2);
            boton_ensalada_mixta.Name = "boton_ensalada_mixta";
            boton_ensalada_mixta.Size = new Size(102, 121);
            boton_ensalada_mixta.TabIndex = 9;
            boton_ensalada_mixta.Text = "ENSALADA MIXTA";
            boton_ensalada_mixta.TextAlign = ContentAlignment.BottomCenter;
            boton_ensalada_mixta.UseVisualStyleBackColor = true;
            boton_ensalada_mixta.Visible = false;
            // 
            // texto_total
            // 
            texto_total.AutoSize = true;
            texto_total.Location = new Point(305, 544);
            texto_total.Name = "texto_total";
            texto_total.Size = new Size(36, 15);
            texto_total.TabIndex = 8;
            texto_total.Text = "Total:";
            // 
            // boton_eliminar_pedido
            // 
            boton_eliminar_pedido.Location = new Point(7, 538);
            boton_eliminar_pedido.Margin = new Padding(3, 2, 3, 2);
            boton_eliminar_pedido.Name = "boton_eliminar_pedido";
            boton_eliminar_pedido.Size = new Size(192, 26);
            boton_eliminar_pedido.TabIndex = 7;
            boton_eliminar_pedido.Text = "Eliminar pedido";
            boton_eliminar_pedido.UseVisualStyleBackColor = true;
            boton_eliminar_pedido.Click += boton_eliminar_pedido_Click;
            // 
            // boton_generar_boleta
            // 
            boton_generar_boleta.Location = new Point(493, 538);
            boton_generar_boleta.Margin = new Padding(3, 2, 3, 2);
            boton_generar_boleta.Name = "boton_generar_boleta";
            boton_generar_boleta.Size = new Size(192, 26);
            boton_generar_boleta.TabIndex = 6;
            boton_generar_boleta.Text = "Generar Boleta";
            boton_generar_boleta.UseVisualStyleBackColor = true;
            boton_generar_boleta.Click += boton_generar_boleta_Click;
            // 
            // boton_pollo_frito
            // 
            boton_pollo_frito.Image = Properties.Resources.icono_pollo_frito_64x64;
            boton_pollo_frito.Location = new Point(352, 9);
            boton_pollo_frito.Margin = new Padding(3, 2, 3, 2);
            boton_pollo_frito.Name = "boton_pollo_frito";
            boton_pollo_frito.Size = new Size(102, 121);
            boton_pollo_frito.TabIndex = 5;
            boton_pollo_frito.Text = "POLLO FRITO";
            boton_pollo_frito.TextAlign = ContentAlignment.BottomCenter;
            boton_pollo_frito.UseVisualStyleBackColor = true;
            boton_pollo_frito.Visible = false;
            // 
            // boton_panqueques
            // 
            boton_panqueques.Image = Properties.Resources.icono_panqueques_64x64;
            boton_panqueques.Location = new Point(244, 9);
            boton_panqueques.Margin = new Padding(3, 2, 3, 2);
            boton_panqueques.Name = "boton_panqueques";
            boton_panqueques.Size = new Size(102, 121);
            boton_panqueques.TabIndex = 4;
            boton_panqueques.Text = "PANQUEQUES";
            boton_panqueques.TextAlign = ContentAlignment.BottomCenter;
            boton_panqueques.UseVisualStyleBackColor = true;
            boton_panqueques.Visible = false;
            // 
            // boton_hamburguesa
            // 
            boton_hamburguesa.Image = Properties.Resources.icono_hamburguesa_negra_64x64;
            boton_hamburguesa.Location = new Point(193, 134);
            boton_hamburguesa.Margin = new Padding(3, 2, 3, 2);
            boton_hamburguesa.Name = "boton_hamburguesa";
            boton_hamburguesa.Size = new Size(102, 121);
            boton_hamburguesa.TabIndex = 3;
            boton_hamburguesa.Text = "HAMBURGUESA";
            boton_hamburguesa.TextAlign = ContentAlignment.BottomCenter;
            boton_hamburguesa.UseVisualStyleBackColor = true;
            boton_hamburguesa.Visible = false;
            // 
            // boton_pepsi
            // 
            boton_pepsi.Image = Properties.Resources.icono_cola_64x64;
            boton_pepsi.Location = new Point(460, 9);
            boton_pepsi.Margin = new Padding(3, 2, 3, 2);
            boton_pepsi.Name = "boton_pepsi";
            boton_pepsi.Size = new Size(102, 121);
            boton_pepsi.TabIndex = 2;
            boton_pepsi.Text = "PEPSI";
            boton_pepsi.TextAlign = ContentAlignment.BottomCenter;
            boton_pepsi.UseVisualStyleBackColor = true;
            boton_pepsi.Visible = false;
            // 
            // boton_completo
            // 
            boton_completo.Image = Properties.Resources.icono_hotdog_sin_texto_64x64;
            boton_completo.Location = new Point(301, 134);
            boton_completo.Margin = new Padding(3, 2, 3, 2);
            boton_completo.Name = "boton_completo";
            boton_completo.Size = new Size(102, 121);
            boton_completo.TabIndex = 1;
            boton_completo.Text = "COMPLETO";
            boton_completo.TextAlign = ContentAlignment.BottomCenter;
            boton_completo.UseVisualStyleBackColor = true;
            boton_completo.Visible = false;
            // 
            // boton_papas_fritas
            // 
            boton_papas_fritas.Image = Properties.Resources.icono_papas_fritas_64x64;
            boton_papas_fritas.Location = new Point(136, 9);
            boton_papas_fritas.Margin = new Padding(3, 2, 3, 2);
            boton_papas_fritas.Name = "boton_papas_fritas";
            boton_papas_fritas.Size = new Size(102, 121);
            boton_papas_fritas.TabIndex = 0;
            boton_papas_fritas.Text = "PAPAS FRITAS";
            boton_papas_fritas.TextAlign = ContentAlignment.BottomCenter;
            boton_papas_fritas.UseVisualStyleBackColor = true;
            boton_papas_fritas.Visible = false;
            // 
            // carta_restorante
            // 
            carta_restorante.Controls.Add(panel_carta_pdf);
            carta_restorante.Controls.Add(boton_generar_carta);
            carta_restorante.Location = new Point(4, 24);
            carta_restorante.Margin = new Padding(3, 2, 3, 2);
            carta_restorante.Name = "carta_restorante";
            carta_restorante.Size = new Size(693, 583);
            carta_restorante.TabIndex = 2;
            carta_restorante.Text = "Carta restorante";
            carta_restorante.UseVisualStyleBackColor = true;
            // 
            // panel_carta_pdf
            // 
            panel_carta_pdf.Location = new Point(35, 63);
            panel_carta_pdf.Name = "panel_carta_pdf";
            panel_carta_pdf.Size = new Size(622, 483);
            panel_carta_pdf.TabIndex = 1;
            // 
            // boton_generar_carta
            // 
            boton_generar_carta.Location = new Point(269, 17);
            boton_generar_carta.Name = "boton_generar_carta";
            boton_generar_carta.Size = new Size(126, 23);
            boton_generar_carta.TabIndex = 0;
            boton_generar_carta.Text = "Generar carta (PDF)";
            boton_generar_carta.UseVisualStyleBackColor = true;
            boton_generar_carta.Click += boton_generar_carta_Click;
            // 
            // stock
            // 
            stock.Controls.Add(tabla_stock);
            stock.Controls.Add(panel2);
            stock.Controls.Add(panel1);
            stock.Location = new Point(4, 24);
            stock.Margin = new Padding(3, 2, 3, 2);
            stock.Name = "stock";
            stock.Size = new Size(693, 583);
            stock.TabIndex = 1;
            stock.Text = "Stock";
            stock.UseVisualStyleBackColor = true;
            // 
            // tabla_stock
            // 
            tabla_stock.AllowUserToAddRows = false;
            tabla_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla_stock.ColumnHeadersHeight = 45;
            tabla_stock.Dock = DockStyle.Fill;
            tabla_stock.Location = new Point(192, 0);
            tabla_stock.Margin = new Padding(3, 2, 3, 2);
            tabla_stock.Name = "tabla_stock";
            tabla_stock.RowHeadersVisible = false;
            tabla_stock.RowHeadersWidth = 51;
            tabla_stock.Size = new Size(346, 583);
            tabla_stock.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(boton_generar_menu);
            panel2.Controls.Add(boton_eliminar_ingrediente);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(538, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 583);
            panel2.TabIndex = 2;
            // 
            // boton_generar_menu
            // 
            boton_generar_menu.Location = new Point(18, 82);
            boton_generar_menu.Margin = new Padding(3, 2, 3, 2);
            boton_generar_menu.Name = "boton_generar_menu";
            boton_generar_menu.Size = new Size(119, 38);
            boton_generar_menu.TabIndex = 8;
            boton_generar_menu.Text = "Generar Menú";
            boton_generar_menu.UseVisualStyleBackColor = true;
            boton_generar_menu.Click += boton_generar_menu_Click;
            // 
            // boton_eliminar_ingrediente
            // 
            boton_eliminar_ingrediente.Location = new Point(18, 26);
            boton_eliminar_ingrediente.Margin = new Padding(3, 2, 3, 2);
            boton_eliminar_ingrediente.Name = "boton_eliminar_ingrediente";
            boton_eliminar_ingrediente.Size = new Size(119, 38);
            boton_eliminar_ingrediente.TabIndex = 7;
            boton_eliminar_ingrediente.Text = "Eliminar Ingrediente";
            boton_eliminar_ingrediente.UseVisualStyleBackColor = true;
            boton_eliminar_ingrediente.Click += boton_eliminar_ingrediente_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(boton_ingresar_ingrediente);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(input_cantidad_ingrediente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(input_unidad_ingrediente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(input_nombre_ingrediente);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 583);
            panel1.TabIndex = 1;
            // 
            // boton_ingresar_ingrediente
            // 
            boton_ingresar_ingrediente.Location = new Point(39, 236);
            boton_ingresar_ingrediente.Margin = new Padding(3, 2, 3, 2);
            boton_ingresar_ingrediente.Name = "boton_ingresar_ingrediente";
            boton_ingresar_ingrediente.Size = new Size(119, 38);
            boton_ingresar_ingrediente.TabIndex = 2;
            boton_ingresar_ingrediente.Text = "Ingresar Ingrediente";
            boton_ingresar_ingrediente.UseVisualStyleBackColor = true;
            boton_ingresar_ingrediente.Click += boton_ingresar_ingrediente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_cantidad_ingrediente
            // 
            input_cantidad_ingrediente.Location = new Point(21, 185);
            input_cantidad_ingrediente.Margin = new Padding(3, 2, 3, 2);
            input_cantidad_ingrediente.Name = "input_cantidad_ingrediente";
            input_cantidad_ingrediente.Size = new Size(150, 23);
            input_cantidad_ingrediente.TabIndex = 5;
            input_cantidad_ingrediente.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 93);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Unidad:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_unidad_ingrediente
            // 
            input_unidad_ingrediente.Location = new Point(21, 118);
            input_unidad_ingrediente.Margin = new Padding(3, 2, 3, 2);
            input_unidad_ingrediente.Name = "input_unidad_ingrediente";
            input_unidad_ingrediente.Size = new Size(150, 23);
            input_unidad_ingrediente.TabIndex = 3;
            input_unidad_ingrediente.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 26);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del ingrediente:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_nombre_ingrediente
            // 
            input_nombre_ingrediente.Location = new Point(21, 50);
            input_nombre_ingrediente.Margin = new Padding(3, 2, 3, 2);
            input_nombre_ingrediente.Name = "input_nombre_ingrediente";
            input_nombre_ingrediente.Size = new Size(150, 23);
            input_nombre_ingrediente.TabIndex = 0;
            input_nombre_ingrediente.TextAlign = HorizontalAlignment.Center;
            // 
            // carga_ingredientes
            // 
            carga_ingredientes.Controls.Add(tabla_ingredientes_cargados);
            carga_ingredientes.Controls.Add(boton_agregar_stock);
            carga_ingredientes.Controls.Add(label1);
            carga_ingredientes.Controls.Add(boton_cargar_csv);
            carga_ingredientes.Location = new Point(4, 24);
            carga_ingredientes.Margin = new Padding(3, 2, 3, 2);
            carga_ingredientes.Name = "carga_ingredientes";
            carga_ingredientes.Padding = new Padding(3, 2, 3, 2);
            carga_ingredientes.Size = new Size(693, 583);
            carga_ingredientes.TabIndex = 0;
            carga_ingredientes.Text = "Carga de ingredientes";
            carga_ingredientes.UseVisualStyleBackColor = true;
            // 
            // tabla_ingredientes_cargados
            // 
            tabla_ingredientes_cargados.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tabla_ingredientes_cargados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            tabla_ingredientes_cargados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla_ingredientes_cargados.ColumnHeadersHeight = 48;
            tabla_ingredientes_cargados.DefaultCellStyle = dataGridViewCellStyle2;
            tabla_ingredientes_cargados.Location = new Point(18, 122);
            tabla_ingredientes_cargados.Margin = new Padding(3, 2, 3, 2);
            tabla_ingredientes_cargados.Name = "tabla_ingredientes_cargados";
            tabla_ingredientes_cargados.RowHeadersVisible = false;
            tabla_ingredientes_cargados.RowHeadersWidth = 51;
            tabla_ingredientes_cargados.Size = new Size(658, 386);
            tabla_ingredientes_cargados.TabIndex = 4;
            // 
            // boton_agregar_stock
            // 
            boton_agregar_stock.Location = new Point(209, 521);
            boton_agregar_stock.Margin = new Padding(3, 2, 3, 2);
            boton_agregar_stock.Name = "boton_agregar_stock";
            boton_agregar_stock.Size = new Size(276, 44);
            boton_agregar_stock.TabIndex = 3;
            boton_agregar_stock.Text = "Agregar al Stock";
            boton_agregar_stock.UseVisualStyleBackColor = true;
            boton_agregar_stock.Click += boton_agregar_stock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 27);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 2;
            label1.Text = "Carga de archivos CSV";
            // 
            // boton_cargar_csv
            // 
            boton_cargar_csv.Location = new Point(209, 64);
            boton_cargar_csv.Margin = new Padding(3, 2, 3, 2);
            boton_cargar_csv.Name = "boton_cargar_csv";
            boton_cargar_csv.Size = new Size(276, 44);
            boton_cargar_csv.TabIndex = 1;
            boton_cargar_csv.Text = "Cargar CSV";
            boton_cargar_csv.UseVisualStyleBackColor = true;
            boton_cargar_csv.Click += boton_cargar_csv_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(carga_ingredientes);
            tabControl1.Controls.Add(stock);
            tabControl1.Controls.Add(carta_restorante);
            tabControl1.Controls.Add(pedido);
            tabControl1.Controls.Add(boleta);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(701, 611);
            tabControl1.TabIndex = 1;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.SelectedPath = "aaaaa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 611);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            boleta.ResumeLayout(false);
            pedido.ResumeLayout(false);
            pedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_pedido).EndInit();
            carta_restorante.ResumeLayout(false);
            stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabla_stock).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            carga_ingredientes.ResumeLayout(false);
            carga_ingredientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_ingredientes_cargados).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage boleta;
        private Button boton_mostrar_boleta;
        private TabPage pedido;
        private DataGridView tabla_pedido;
        private Button boton_ensalada_mixta;
        private Label texto_total;
        private Button boton_eliminar_pedido;
        private Button boton_generar_boleta;
        private Button boton_pollo_frito;
        private Button boton_panqueques;
        private Button boton_hamburguesa;
        private Button boton_pepsi;
        private Button boton_completo;
        private Button boton_papas_fritas;
        private TabPage carta_restorante;
        private Button boton_generar_carta;
        private TabPage stock;
        private DataGridView tabla_stock;
        private Panel panel2;
        private Button boton_generar_menu;
        private Button boton_eliminar_ingrediente;
        private Panel panel1;
        private Button boton_ingresar_ingrediente;
        private Label label4;
        private TextBox input_cantidad_ingrediente;
        private Label label3;
        private TextBox input_unidad_ingrediente;
        private Label label2;
        private TextBox input_nombre_ingrediente;
        private TabPage carga_ingredientes;
        private DataGridView tabla_ingredientes_cargados;
        private Button boton_agregar_stock;
        private Label label1;
        private Button boton_cargar_csv;
        private TabControl tabControl1;
        private DataGridView dataGridView2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel_boleta_pdf;
        private Panel panel_carta_pdf;
    }
}
