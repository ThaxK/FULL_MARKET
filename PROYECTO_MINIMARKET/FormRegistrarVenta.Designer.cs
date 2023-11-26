namespace PROYECTO_MINIMARKET
{
    partial class FormRegistrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarCarrito = new System.Windows.Forms.Button();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.buttonRestar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelPrecioProducto = new System.Windows.Forms.Label();
            this.labelNombreProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCategoria = new System.Windows.Forms.Button();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonSalirCarritoCompras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.buttonAgregarCarrito);
            this.groupBox4.Controls.Add(this.buttonSumar);
            this.groupBox4.Controls.Add(this.buttonRestar);
            this.groupBox4.Controls.Add(this.textBoxCantidad);
            this.groupBox4.Controls.Add(this.labelPrecioProducto);
            this.groupBox4.Controls.Add(this.labelNombreProducto);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(114, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 187);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Confirmar Compra";
            // 
            // buttonAgregarCarrito
            // 
            this.buttonAgregarCarrito.Location = new System.Drawing.Point(191, 158);
            this.buttonAgregarCarrito.Name = "buttonAgregarCarrito";
            this.buttonAgregarCarrito.Size = new System.Drawing.Size(108, 23);
            this.buttonAgregarCarrito.TabIndex = 8;
            this.buttonAgregarCarrito.Text = "Agregar al carrito";
            this.buttonAgregarCarrito.UseVisualStyleBackColor = true;
            this.buttonAgregarCarrito.Click += new System.EventHandler(this.buttonAgregarCarrito_Click);
            // 
            // buttonSumar
            // 
            this.buttonSumar.Location = new System.Drawing.Point(274, 117);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(28, 21);
            this.buttonSumar.TabIndex = 7;
            this.buttonSumar.Text = "+";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
            // 
            // buttonRestar
            // 
            this.buttonRestar.Location = new System.Drawing.Point(187, 117);
            this.buttonRestar.Name = "buttonRestar";
            this.buttonRestar.Size = new System.Drawing.Size(28, 21);
            this.buttonRestar.TabIndex = 6;
            this.buttonRestar.Text = "-";
            this.buttonRestar.UseVisualStyleBackColor = true;
            this.buttonRestar.Click += new System.EventHandler(this.buttonRestar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Enabled = false;
            this.textBoxCantidad.Location = new System.Drawing.Point(221, 117);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(47, 20);
            this.textBoxCantidad.TabIndex = 5;
            this.textBoxCantidad.Text = "1";
            // 
            // labelPrecioProducto
            // 
            this.labelPrecioProducto.AutoSize = true;
            this.labelPrecioProducto.Location = new System.Drawing.Point(188, 82);
            this.labelPrecioProducto.Name = "labelPrecioProducto";
            this.labelPrecioProducto.Size = new System.Drawing.Size(35, 13);
            this.labelPrecioProducto.TabIndex = 4;
            this.labelPrecioProducto.Text = "label4";
            // 
            // labelNombreProducto
            // 
            this.labelNombreProducto.AutoSize = true;
            this.labelNombreProducto.Location = new System.Drawing.Point(188, 43);
            this.labelNombreProducto.Name = "labelNombreProducto";
            this.labelNombreProducto.Size = new System.Drawing.Size(35, 13);
            this.labelNombreProducto.TabIndex = 3;
            this.labelNombreProducto.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // button2
            // 
            this.button2.Image = global::PROYECTO_MINIMARKET.Properties.Resources._63007shoppingcart_109353;
            this.button2.Location = new System.Drawing.Point(707, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 37);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 141);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxNombre);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(400, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 98);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(39, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(185, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCategoria);
            this.groupBox2.Controls.Add(this.ComboCategoria);
            this.groupBox2.Location = new System.Drawing.Point(16, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 98);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por categoria";
            // 
            // buttonCategoria
            // 
            this.buttonCategoria.Location = new System.Drawing.Point(242, 43);
            this.buttonCategoria.Name = "buttonCategoria";
            this.buttonCategoria.Size = new System.Drawing.Size(84, 21);
            this.buttonCategoria.TabIndex = 1;
            this.buttonCategoria.Text = "Buscar";
            this.buttonCategoria.UseVisualStyleBackColor = true;
            this.buttonCategoria.Click += new System.EventHandler(this.buttonCategoria_Click);
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(36, 43);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(185, 21);
            this.ComboCategoria.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSalirCarritoCompras);
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(775, 233);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carrito de compras";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(758, 163);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // buttonSalirCarritoCompras
            // 
            this.buttonSalirCarritoCompras.BackColor = System.Drawing.Color.Gray;
            this.buttonSalirCarritoCompras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalirCarritoCompras.Location = new System.Drawing.Point(718, 9);
            this.buttonSalirCarritoCompras.Name = "buttonSalirCarritoCompras";
            this.buttonSalirCarritoCompras.Size = new System.Drawing.Size(57, 37);
            this.buttonSalirCarritoCompras.TabIndex = 1;
            this.buttonSalirCarritoCompras.Text = "Volver";
            this.buttonSalirCarritoCompras.UseVisualStyleBackColor = false;
            this.buttonSalirCarritoCompras.Click += new System.EventHandler(this.buttonSalirCarritoCompras_Click);
            // 
            // FormRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "FormRegistrarVenta";
            this.Text = "FormRegistrarVenta";
            this.Load += new System.EventHandler(this.FormRegistrarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCategoria;
        private System.Windows.Forms.ComboBox ComboCategoria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.Button buttonRestar;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelPrecioProducto;
        private System.Windows.Forms.Label labelNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAgregarCarrito;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonSalirCarritoCompras;
    }
}