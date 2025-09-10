namespace Metodos
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
            button1 = new Button();
            textBoxProBuscado = new TextBox();
            label1 = new Label();
            tab1 = new TabControl();
            tabProductos = new TabPage();
            textBoxSubTotal = new TextBox();
            labelSubTotal = new Label();
            numericUpDownCarrito = new NumericUpDown();
            button3 = new Button();
            button2 = new Button();
            textBoxProStock = new TextBox();
            textBoxProPrecio = new TextBox();
            textBoxProDescripcion = new TextBox();
            textBoxProNombre = new TextBox();
            textBoxProId = new TextBox();
            labelProStock = new Label();
            labelProPrecio = new Label();
            labelProDescripcion = new Label();
            lableProNombre = new Label();
            labelProId = new Label();
            dgvProducto = new DataGridView();
            tabCarrito = new TabPage();
            dgvCarrito = new DataGridView();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBoxTotalGeneral = new TextBox();
            tabInventario = new TabPage();
            btnLimpiar = new Button();
            labelId = new Label();
            checkBoxActivo = new CheckBox();
            labelPrecio = new Label();
            labelDescripcion = new Label();
            labelStock = new Label();
            labelNombre = new Label();
            textBoxPrecio = new TextBox();
            textBoxStock = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxNombre = new TextBox();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvInventario = new DataGridView();
            TabHistorialCompras = new TabPage();
            button4 = new Button();
            tab1.SuspendLayout();
            tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            tabCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            tabInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(574, 5);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxProBuscado
            // 
            textBoxProBuscado.Location = new Point(127, 6);
            textBoxProBuscado.Name = "textBoxProBuscado";
            textBoxProBuscado.Size = new Size(104, 23);
            textBoxProBuscado.TabIndex = 1;
            textBoxProBuscado.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 13);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Buscar producto";
            label1.Click += label1_Click;
            // 
            // tab1
            // 
            tab1.Controls.Add(tabProductos);
            tab1.Controls.Add(tabCarrito);
            tab1.Controls.Add(TabHistorialCompras);
            tab1.Controls.Add(tabInventario);
            tab1.Location = new Point(12, 43);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(776, 403);
            tab1.TabIndex = 3;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(textBoxSubTotal);
            tabProductos.Controls.Add(labelSubTotal);
            tabProductos.Controls.Add(numericUpDownCarrito);
            tabProductos.Controls.Add(button3);
            tabProductos.Controls.Add(button2);
            tabProductos.Controls.Add(textBoxProStock);
            tabProductos.Controls.Add(textBoxProPrecio);
            tabProductos.Controls.Add(textBoxProDescripcion);
            tabProductos.Controls.Add(textBoxProNombre);
            tabProductos.Controls.Add(textBoxProId);
            tabProductos.Controls.Add(labelProStock);
            tabProductos.Controls.Add(labelProPrecio);
            tabProductos.Controls.Add(labelProDescripcion);
            tabProductos.Controls.Add(lableProNombre);
            tabProductos.Controls.Add(labelProId);
            tabProductos.Controls.Add(dgvProducto);
            tabProductos.Controls.Add(textBoxProBuscado);
            tabProductos.Controls.Add(label1);
            tabProductos.Controls.Add(button1);
            tabProductos.Location = new Point(4, 24);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(3);
            tabProductos.Size = new Size(768, 375);
            tabProductos.TabIndex = 0;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // textBoxSubTotal
            // 
            textBoxSubTotal.Location = new Point(574, 119);
            textBoxSubTotal.Name = "textBoxSubTotal";
            textBoxSubTotal.ReadOnly = true;
            textBoxSubTotal.Size = new Size(71, 23);
            textBoxSubTotal.TabIndex = 18;
            textBoxSubTotal.Text = "Q. 0.00";
            // 
            // labelSubTotal
            // 
            labelSubTotal.AutoSize = true;
            labelSubTotal.Location = new Point(516, 123);
            labelSubTotal.Name = "labelSubTotal";
            labelSubTotal.Size = new Size(59, 15);
            labelSubTotal.TabIndex = 17;
            labelSubTotal.Text = "Sub-total:";
            // 
            // numericUpDownCarrito
            // 
            numericUpDownCarrito.Location = new Point(574, 90);
            numericUpDownCarrito.Name = "numericUpDownCarrito";
            numericUpDownCarrito.Size = new Size(71, 23);
            numericUpDownCarrito.TabIndex = 16;
            numericUpDownCarrito.TextAlign = HorizontalAlignment.Center;
            numericUpDownCarrito.ValueChanged += numericUpDownCarrito_ValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(651, 90);
            button3.Name = "button3";
            button3.Size = new Size(74, 44);
            button3.TabIndex = 15;
            button3.Text = "Agregar al Carrito";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(574, 45);
            button2.Name = "button2";
            button2.Size = new Size(151, 23);
            button2.TabIndex = 14;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBoxProStock
            // 
            textBoxProStock.Location = new Point(388, 73);
            textBoxProStock.Name = "textBoxProStock";
            textBoxProStock.ReadOnly = true;
            textBoxProStock.Size = new Size(53, 23);
            textBoxProStock.TabIndex = 13;
            // 
            // textBoxProPrecio
            // 
            textBoxProPrecio.Location = new Point(388, 46);
            textBoxProPrecio.Name = "textBoxProPrecio";
            textBoxProPrecio.ReadOnly = true;
            textBoxProPrecio.Size = new Size(53, 23);
            textBoxProPrecio.TabIndex = 12;
            // 
            // textBoxProDescripcion
            // 
            textBoxProDescripcion.Location = new Point(127, 95);
            textBoxProDescripcion.Name = "textBoxProDescripcion";
            textBoxProDescripcion.ReadOnly = true;
            textBoxProDescripcion.Size = new Size(190, 23);
            textBoxProDescripcion.TabIndex = 11;
            // 
            // textBoxProNombre
            // 
            textBoxProNombre.Location = new Point(127, 68);
            textBoxProNombre.Name = "textBoxProNombre";
            textBoxProNombre.ReadOnly = true;
            textBoxProNombre.Size = new Size(190, 23);
            textBoxProNombre.TabIndex = 10;
            // 
            // textBoxProId
            // 
            textBoxProId.Location = new Point(127, 41);
            textBoxProId.Name = "textBoxProId";
            textBoxProId.ReadOnly = true;
            textBoxProId.Size = new Size(104, 23);
            textBoxProId.TabIndex = 9;
            // 
            // labelProStock
            // 
            labelProStock.AutoSize = true;
            labelProStock.Location = new Point(343, 76);
            labelProStock.Name = "labelProStock";
            labelProStock.Size = new Size(39, 15);
            labelProStock.TabIndex = 8;
            labelProStock.Text = "Stock:";
            // 
            // labelProPrecio
            // 
            labelProPrecio.AutoSize = true;
            labelProPrecio.Location = new Point(339, 49);
            labelProPrecio.Name = "labelProPrecio";
            labelProPrecio.Size = new Size(43, 15);
            labelProPrecio.TabIndex = 7;
            labelProPrecio.Text = "Precio:";
            // 
            // labelProDescripcion
            // 
            labelProDescripcion.AutoSize = true;
            labelProDescripcion.Location = new Point(27, 98);
            labelProDescripcion.Name = "labelProDescripcion";
            labelProDescripcion.Size = new Size(72, 15);
            labelProDescripcion.TabIndex = 6;
            labelProDescripcion.Text = "Descripción:";
            // 
            // lableProNombre
            // 
            lableProNombre.AutoSize = true;
            lableProNombre.Location = new Point(27, 76);
            lableProNombre.Name = "lableProNombre";
            lableProNombre.Size = new Size(54, 15);
            lableProNombre.TabIndex = 5;
            lableProNombre.Text = "Nombre:";
            // 
            // labelProId
            // 
            labelProId.AutoSize = true;
            labelProId.Location = new Point(27, 49);
            labelProId.Name = "labelProId";
            labelProId.Size = new Size(20, 15);
            labelProId.TabIndex = 4;
            labelProId.Text = "Id:";
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(6, 159);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.Size = new Size(749, 201);
            dgvProducto.TabIndex = 3;
            dgvProducto.CellClick += dgvUsuarios_CellClick;
            // 
            // tabCarrito
            // 
            tabCarrito.Controls.Add(button4);
            tabCarrito.Controls.Add(dgvCarrito);
            tabCarrito.Controls.Add(label3);
            tabCarrito.Controls.Add(textBox3);
            tabCarrito.Controls.Add(label2);
            tabCarrito.Controls.Add(textBoxTotalGeneral);
            tabCarrito.Location = new Point(4, 24);
            tabCarrito.Name = "tabCarrito";
            tabCarrito.Padding = new Padding(3);
            tabCarrito.Size = new Size(768, 375);
            tabCarrito.TabIndex = 1;
            tabCarrito.Text = "Carrito";
            tabCarrito.UseVisualStyleBackColor = true;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(31, 111);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.Size = new Size(699, 240);
            dgvCarrito.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 27);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Ingrese contraseña";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 24);
            textBox3.MaxLength = 25;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Total general:";
            label2.Click += label2_Click;
            // 
            // textBoxTotalGeneral
            // 
            textBoxTotalGeneral.Location = new Point(505, 66);
            textBoxTotalGeneral.MaxLength = 25;
            textBoxTotalGeneral.Name = "textBoxTotalGeneral";
            textBoxTotalGeneral.ReadOnly = true;
            textBoxTotalGeneral.Size = new Size(100, 23);
            textBoxTotalGeneral.TabIndex = 0;
            // 
            // tabInventario
            // 
            tabInventario.Controls.Add(btnLimpiar);
            tabInventario.Controls.Add(labelId);
            tabInventario.Controls.Add(checkBoxActivo);
            tabInventario.Controls.Add(labelPrecio);
            tabInventario.Controls.Add(labelDescripcion);
            tabInventario.Controls.Add(labelStock);
            tabInventario.Controls.Add(labelNombre);
            tabInventario.Controls.Add(textBoxPrecio);
            tabInventario.Controls.Add(textBoxStock);
            tabInventario.Controls.Add(textBoxDescripcion);
            tabInventario.Controls.Add(textBoxNombre);
            tabInventario.Controls.Add(btnModificar);
            tabInventario.Controls.Add(btnAgregar);
            tabInventario.Controls.Add(dgvInventario);
            tabInventario.Location = new Point(4, 24);
            tabInventario.Name = "tabInventario";
            tabInventario.Size = new Size(768, 375);
            tabInventario.TabIndex = 2;
            tabInventario.Text = "Inventario";
            tabInventario.UseVisualStyleBackColor = true;
            tabInventario.Click += tabPage3_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(474, 66);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button2_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(38, 11);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 15);
            labelId.TabIndex = 12;
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(474, 36);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(82, 19);
            checkBoxActivo.TabIndex = 11;
            checkBoxActivo.Text = "Disponible";
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(246, 70);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(40, 15);
            labelPrecio.TabIndex = 10;
            labelPrecio.Text = "Precio";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(241, 39);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(69, 15);
            labelDescripcion.TabIndex = 9;
            labelDescripcion.Text = "Descripción";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(29, 68);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(36, 15);
            labelStock.TabIndex = 8;
            labelStock.Text = "Stock";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(29, 38);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 7;
            labelNombre.Text = "Nombre";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(316, 65);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(100, 23);
            textBoxPrecio.TabIndex = 6;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(114, 65);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(100, 23);
            textBoxStock.TabIndex = 5;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(316, 35);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(100, 23);
            textBoxDescripcion.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(114, 36);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(668, 68);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(668, 30);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(3, 106);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.Size = new Size(762, 265);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellClick += dgvInventario_CellClick;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            dgvInventario.CellFormatting += dgvInventario_CellFormatting;
            // 
            // TabHistorialCompras
            // 
            TabHistorialCompras.Location = new Point(4, 24);
            TabHistorialCompras.Name = "TabHistorialCompras";
            TabHistorialCompras.Size = new Size(768, 375);
            TabHistorialCompras.TabIndex = 3;
            TabHistorialCompras.Text = "Historial de compras";
            TabHistorialCompras.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(619, 65);
            button4.Name = "button4";
            button4.Size = new Size(111, 23);
            button4.TabIndex = 5;
            button4.Text = "Finalizar compra";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tab1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tab1.ResumeLayout(false);
            tabProductos.ResumeLayout(false);
            tabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            tabCarrito.ResumeLayout(false);
            tabCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            tabInventario.ResumeLayout(false);
            tabInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBoxProBuscado;
        private Label label1;
        private TabControl tab1;
        private TabPage tabProductos;
        private TabPage tabCarrito;
        private DataGridView dgvProducto;
        private TabPage tabInventario;
        private TabPage TabHistorialCompras;
        private Label label2;
        private TextBox textBoxTotalGeneral;
        private Label label3;
        private TextBox textBox3;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvInventario;
        private Label labelPrecio;
        private Label labelDescripcion;
        private Label labelStock;
        private Label labelNombre;
        private TextBox textBoxPrecio;
        private TextBox textBoxStock;
        private TextBox textBoxDescripcion;
        private TextBox textBoxNombre;
        private CheckBox checkBoxActivo;
        private Label labelId;
        private Button btnLimpiar;
        private Label labelProDescripcion;
        private Label lableProNombre;
        private Label labelProId;
        private Label labelProPrecio;
        private Label labelProStock;
        private TextBox textBoxProStock;
        private TextBox textBoxProPrecio;
        private TextBox textBoxProDescripcion;
        private TextBox textBoxProNombre;
        private TextBox textBoxProId;
        private Button button2;
        private Button button3;
        private NumericUpDown numericUpDownCarrito;
        private TextBox textBoxSubTotal;
        private Label labelSubTotal;
        private DataGridView dgvCarrito;
        private Button button4;
    }
}
