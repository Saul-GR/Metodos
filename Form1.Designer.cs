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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
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
            tpCarrito = new TabPage();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            tabPage3 = new TabPage();
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
            tabPage4 = new TabPage();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            tpCarrito.SuspendLayout();
            tabPage3.SuspendLayout();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tpCarrito);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 403);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBoxProStock);
            tabPage1.Controls.Add(textBoxProPrecio);
            tabPage1.Controls.Add(textBoxProDescripcion);
            tabPage1.Controls.Add(textBoxProNombre);
            tabPage1.Controls.Add(textBoxProId);
            tabPage1.Controls.Add(labelProStock);
            tabPage1.Controls.Add(labelProPrecio);
            tabPage1.Controls.Add(labelProDescripcion);
            tabPage1.Controls.Add(lableProNombre);
            tabPage1.Controls.Add(labelProId);
            tabPage1.Controls.Add(dgvProducto);
            tabPage1.Controls.Add(textBoxProBuscado);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 375);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos";
            tabPage1.UseVisualStyleBackColor = true;
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
            // tpCarrito
            // 
            tpCarrito.Controls.Add(label3);
            tpCarrito.Controls.Add(textBox3);
            tpCarrito.Controls.Add(label2);
            tpCarrito.Controls.Add(textBox2);
            tpCarrito.Location = new Point(4, 24);
            tpCarrito.Name = "tpCarrito";
            tpCarrito.Padding = new Padding(3);
            tpCarrito.Size = new Size(768, 375);
            tpCarrito.TabIndex = 1;
            tpCarrito.Text = "Carrito";
            tpCarrito.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 56);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Ingrese contraseña";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(356, 53);
            textBox3.MaxLength = 25;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 56);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese correo";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Lower;
            textBox2.Location = new Point(119, 53);
            textBox2.MaxLength = 25;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnLimpiar);
            tabPage3.Controls.Add(labelId);
            tabPage3.Controls.Add(checkBoxActivo);
            tabPage3.Controls.Add(labelPrecio);
            tabPage3.Controls.Add(labelDescripcion);
            tabPage3.Controls.Add(labelStock);
            tabPage3.Controls.Add(labelNombre);
            tabPage3.Controls.Add(textBoxPrecio);
            tabPage3.Controls.Add(textBoxStock);
            tabPage3.Controls.Add(textBoxDescripcion);
            tabPage3.Controls.Add(textBoxNombre);
            tabPage3.Controls.Add(btnModificar);
            tabPage3.Controls.Add(btnAgregar);
            tabPage3.Controls.Add(dgvInventario);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 375);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Inventario";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
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
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(768, 375);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Control de usuarios";
            tabPage4.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            tpCarrito.ResumeLayout(false);
            tpCarrito.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBoxProBuscado;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tpCarrito;
        private DataGridView dgvProducto;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label2;
        private TextBox textBox2;
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
    }
}
