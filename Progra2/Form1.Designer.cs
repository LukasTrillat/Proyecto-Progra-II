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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            carga_ingredientes = new TabPage();
            tabla_ingredientes_cargados = new DataGridView();
            boton_agregar_stock = new Button();
            label1 = new Label();
            boton_cargar_csv = new Button();
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
            carta_restorante = new TabPage();
            pedido = new TabPage();
            boton_ensalada_mixta = new Button();
            label5 = new Label();
            boton_eliminar_pedido = new Button();
            button12 = new Button();
            boton_pollo_frito = new Button();
            boton_panqueques = new Button();
            boton_hamburguesa = new Button();
            boton_pepsi = new Button();
            boton_completo = new Button();
            boton_papas_fritas = new Button();
            boleta = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            carga_ingredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_ingredientes_cargados).BeginInit();
            stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_stock).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 815);
            tabControl1.TabIndex = 1;
            // 
            // carga_ingredientes
            // 
            carga_ingredientes.Controls.Add(tabla_ingredientes_cargados);
            carga_ingredientes.Controls.Add(boton_agregar_stock);
            carga_ingredientes.Controls.Add(label1);
            carga_ingredientes.Controls.Add(boton_cargar_csv);
            carga_ingredientes.Location = new Point(4, 29);
            carga_ingredientes.Name = "carga_ingredientes";
            carga_ingredientes.Padding = new Padding(3);
            carga_ingredientes.Size = new Size(793, 782);
            carga_ingredientes.TabIndex = 0;
            carga_ingredientes.Text = "Carga de ingredientes";
            carga_ingredientes.UseVisualStyleBackColor = true;
            // 
            // tabla_ingredientes_cargados
            // 
            tabla_ingredientes_cargados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tabla_ingredientes_cargados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tabla_ingredientes_cargados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla_ingredientes_cargados.ColumnHeadersHeight = 48;
            tabla_ingredientes_cargados.DefaultCellStyle = dataGridViewCellStyle1;
            tabla_ingredientes_cargados.Location = new Point(20, 163);
            tabla_ingredientes_cargados.Name = "tabla_ingredientes_cargados";
            tabla_ingredientes_cargados.RowHeadersVisible = false;
            tabla_ingredientes_cargados.RowHeadersWidth = 51;
            tabla_ingredientes_cargados.Size = new Size(752, 514);
            tabla_ingredientes_cargados.TabIndex = 4;
            // 
            // boton_agregar_stock
            // 
            boton_agregar_stock.Location = new Point(239, 695);
            boton_agregar_stock.Name = "boton_agregar_stock";
            boton_agregar_stock.Size = new Size(315, 58);
            boton_agregar_stock.TabIndex = 3;
            boton_agregar_stock.Text = "Agregar al Stock";
            boton_agregar_stock.UseVisualStyleBackColor = true;
            boton_agregar_stock.Click += boton_agregar_stock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 36);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 2;
            label1.Text = "Carga de archivos CSV";
            // 
            // boton_cargar_csv
            // 
            boton_cargar_csv.Location = new Point(239, 85);
            boton_cargar_csv.Name = "boton_cargar_csv";
            boton_cargar_csv.Size = new Size(315, 58);
            boton_cargar_csv.TabIndex = 1;
            boton_cargar_csv.Text = "Cargar CSV";
            boton_cargar_csv.UseVisualStyleBackColor = true;
            boton_cargar_csv.Click += boton_cargar_csv_Click;
            // 
            // stock
            // 
            stock.Controls.Add(tabla_stock);
            stock.Controls.Add(panel2);
            stock.Controls.Add(panel1);
            stock.Location = new Point(4, 29);
            stock.Name = "stock";
            stock.Size = new Size(793, 782);
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
            tabla_stock.Location = new Point(220, 0);
            tabla_stock.Name = "tabla_stock";
            tabla_stock.RowHeadersVisible = false;
            tabla_stock.RowHeadersWidth = 51;
            tabla_stock.Size = new Size(396, 782);
            tabla_stock.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(boton_generar_menu);
            panel2.Controls.Add(boton_eliminar_ingrediente);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(616, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 782);
            panel2.TabIndex = 2;
            // 
            // boton_generar_menu
            // 
            boton_generar_menu.Location = new Point(20, 109);
            boton_generar_menu.Name = "boton_generar_menu";
            boton_generar_menu.Size = new Size(136, 50);
            boton_generar_menu.TabIndex = 8;
            boton_generar_menu.Text = "Generar Menú";
            boton_generar_menu.UseVisualStyleBackColor = true;
            boton_generar_menu.Click += boton_generar_menu_Click;
            // 
            // boton_eliminar_ingrediente
            // 
            boton_eliminar_ingrediente.Location = new Point(20, 34);
            boton_eliminar_ingrediente.Name = "boton_eliminar_ingrediente";
            boton_eliminar_ingrediente.Size = new Size(136, 50);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 782);
            panel1.TabIndex = 1;
            // 
            // boton_ingresar_ingrediente
            // 
            boton_ingresar_ingrediente.Location = new Point(45, 314);
            boton_ingresar_ingrediente.Name = "boton_ingresar_ingrediente";
            boton_ingresar_ingrediente.Size = new Size(136, 50);
            boton_ingresar_ingrediente.TabIndex = 2;
            boton_ingresar_ingrediente.Text = "Ingresar Ingrediente";
            boton_ingresar_ingrediente.UseVisualStyleBackColor = true;
            boton_ingresar_ingrediente.Click += boton_ingresar_ingrediente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 214);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Cantidad:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_cantidad_ingrediente
            // 
            input_cantidad_ingrediente.Location = new Point(24, 247);
            input_cantidad_ingrediente.Name = "input_cantidad_ingrediente";
            input_cantidad_ingrediente.Size = new Size(171, 27);
            input_cantidad_ingrediente.TabIndex = 5;
            input_cantidad_ingrediente.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 124);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Unidad:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_unidad_ingrediente
            // 
            input_unidad_ingrediente.Location = new Point(24, 157);
            input_unidad_ingrediente.Name = "input_unidad_ingrediente";
            input_unidad_ingrediente.Size = new Size(171, 27);
            input_unidad_ingrediente.TabIndex = 3;
            input_unidad_ingrediente.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 34);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre del ingrediente:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_nombre_ingrediente
            // 
            input_nombre_ingrediente.Location = new Point(24, 67);
            input_nombre_ingrediente.Name = "input_nombre_ingrediente";
            input_nombre_ingrediente.Size = new Size(171, 27);
            input_nombre_ingrediente.TabIndex = 0;
            input_nombre_ingrediente.TextAlign = HorizontalAlignment.Center;
            // 
            // carta_restorante
            // 
            carta_restorante.Location = new Point(4, 29);
            carta_restorante.Name = "carta_restorante";
            carta_restorante.Size = new Size(793, 782);
            carta_restorante.TabIndex = 2;
            carta_restorante.Text = "Carta restorante";
            carta_restorante.UseVisualStyleBackColor = true;
            // 
            // pedido
            // 
            pedido.Controls.Add(dataGridView1);
            pedido.Controls.Add(boton_ensalada_mixta);
            pedido.Controls.Add(label5);
            pedido.Controls.Add(boton_eliminar_pedido);
            pedido.Controls.Add(button12);
            pedido.Controls.Add(boton_pollo_frito);
            pedido.Controls.Add(boton_panqueques);
            pedido.Controls.Add(boton_hamburguesa);
            pedido.Controls.Add(boton_pepsi);
            pedido.Controls.Add(boton_completo);
            pedido.Controls.Add(boton_papas_fritas);
            pedido.Location = new Point(4, 29);
            pedido.Name = "pedido";
            pedido.Size = new Size(793, 782);
            pedido.TabIndex = 3;
            pedido.Text = "Pedido";
            pedido.UseVisualStyleBackColor = true;
            // 
            // boton_ensalada_mixta
            // 
            boton_ensalada_mixta.Location = new Point(489, 155);
            boton_ensalada_mixta.Name = "boton_ensalada_mixta";
            boton_ensalada_mixta.Size = new Size(101, 109);
            boton_ensalada_mixta.TabIndex = 9;
            boton_ensalada_mixta.Text = "Ensalada Mixta";
            boton_ensalada_mixta.UseVisualStyleBackColor = true;
            boton_ensalada_mixta.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 308);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "Total:";
            // 
            // boton_eliminar_pedido
            // 
            boton_eliminar_pedido.Location = new Point(555, 301);
            boton_eliminar_pedido.Name = "boton_eliminar_pedido";
            boton_eliminar_pedido.Size = new Size(219, 34);
            boton_eliminar_pedido.TabIndex = 7;
            boton_eliminar_pedido.Text = "Eliminar pedido";
            boton_eliminar_pedido.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(287, 718);
            button12.Name = "button12";
            button12.Size = new Size(219, 34);
            button12.TabIndex = 6;
            button12.Text = "Generar Boleta";
            button12.UseVisualStyleBackColor = true;
            // 
            // boton_pollo_frito
            // 
            boton_pollo_frito.Location = new Point(346, 155);
            boton_pollo_frito.Name = "boton_pollo_frito";
            boton_pollo_frito.Size = new Size(101, 109);
            boton_pollo_frito.TabIndex = 5;
            boton_pollo_frito.Text = "Pollo Frito";
            boton_pollo_frito.UseVisualStyleBackColor = true;
            boton_pollo_frito.Visible = false;
            // 
            // boton_panqueques
            // 
            boton_panqueques.Location = new Point(203, 155);
            boton_panqueques.Name = "boton_panqueques";
            boton_panqueques.Size = new Size(101, 109);
            boton_panqueques.TabIndex = 4;
            boton_panqueques.Text = "Panqueques";
            boton_panqueques.UseVisualStyleBackColor = true;
            boton_panqueques.Visible = false;
            // 
            // boton_hamburguesa
            // 
            boton_hamburguesa.Location = new Point(280, 28);
            boton_hamburguesa.Name = "boton_hamburguesa";
            boton_hamburguesa.Size = new Size(101, 109);
            boton_hamburguesa.TabIndex = 3;
            boton_hamburguesa.Text = "Hamburguesa";
            boton_hamburguesa.UseVisualStyleBackColor = true;
            boton_hamburguesa.Visible = false;
            // 
            // boton_pepsi
            // 
            boton_pepsi.Location = new Point(411, 28);
            boton_pepsi.Name = "boton_pepsi";
            boton_pepsi.Size = new Size(101, 109);
            boton_pepsi.TabIndex = 2;
            boton_pepsi.Text = "Pepsi";
            boton_pepsi.UseVisualStyleBackColor = true;
            boton_pepsi.Visible = false;
            // 
            // boton_completo
            // 
            boton_completo.Location = new Point(542, 28);
            boton_completo.Name = "boton_completo";
            boton_completo.Size = new Size(101, 109);
            boton_completo.TabIndex = 1;
            boton_completo.Text = "Completo";
            boton_completo.UseVisualStyleBackColor = true;
            boton_completo.Visible = false;
            // 
            // boton_papas_fritas
            // 
            boton_papas_fritas.Location = new Point(149, 28);
            boton_papas_fritas.Name = "boton_papas_fritas";
            boton_papas_fritas.Size = new Size(101, 109);
            boton_papas_fritas.TabIndex = 0;
            boton_papas_fritas.Text = "Papas fritas";
            boton_papas_fritas.UseVisualStyleBackColor = true;
            boton_papas_fritas.Visible = false;
            // 
            // boleta
            // 
            boleta.Location = new Point(4, 29);
            boleta.Name = "boleta";
            boleta.Size = new Size(793, 782);
            boleta.TabIndex = 4;
            boleta.Text = "Boleta";
            boleta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(777, 359);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 815);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            carga_ingredientes.ResumeLayout(false);
            carga_ingredientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_ingredientes_cargados).EndInit();
            stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabla_stock).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pedido.ResumeLayout(false);
            pedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage carga_ingredientes;
        private TabPage stock;
        private TabPage carta_restorante;
        private TabPage pedido;
        private TabPage boleta;
        private Button boton_cargar_csv;
        private Label label1;
        private Button boton_agregar_stock;
        private Panel panel1;
        private TextBox input_nombre_ingrediente;
        private Label label2;
        private Label label4;
        private TextBox input_cantidad_ingrediente;
        private Label label3;
        private TextBox input_unidad_ingrediente;
        private Button boton_ingresar_ingrediente;
        private Panel panel2;
        private Button boton_generar_menu;
        private Button boton_eliminar_ingrediente;
        private Button boton_eliminar_pedido;
        private Button button12;
        private Button boton_pollo_frito;
        private Button boton_panqueques;
        private Button boton_hamburguesa;
        private Button boton_pepsi;
        private Button boton_completo;
        private Button boton_papas_fritas;
        private Label label5;
        private DataGridView tabla_ingredientes_cargados;
        private DataGridView tabla_stock;
        private Button boton_ensalada_mixta;
        private DataGridView dataGridView1;
    }
}
