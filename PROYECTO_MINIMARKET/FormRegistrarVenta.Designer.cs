﻿namespace PROYECTO_MINIMARKET
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConfirmarVenta = new System.Windows.Forms.Button();
            this.buttonSalirCarritoCompras = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(7, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1059, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Location = new System.Drawing.Point(228, 23);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(596, 164);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Confirmar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Desea realizar esta compra a nombre de:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(340, 114);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 34);
            this.button5.TabIndex = 1;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(157, 116);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 34);
            this.button4.TabIndex = 0;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxDocumento);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.dataGridView3);
            this.groupBox6.Location = new System.Drawing.Point(185, 53);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(647, 185);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Seleccionar Cliente";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(193, 46);
            this.textBoxDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(219, 22);
            this.textBoxDocumento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Documento:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 43);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 102);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(647, 75);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
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
            this.groupBox4.Location = new System.Drawing.Point(204, 33);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(628, 230);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Confirmar Compra";
            // 
            // buttonAgregarCarrito
            // 
            this.buttonAgregarCarrito.Location = new System.Drawing.Point(255, 194);
            this.buttonAgregarCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAgregarCarrito.Name = "buttonAgregarCarrito";
            this.buttonAgregarCarrito.Size = new System.Drawing.Size(144, 28);
            this.buttonAgregarCarrito.TabIndex = 8;
            this.buttonAgregarCarrito.Text = "Agregar al carrito";
            this.buttonAgregarCarrito.UseVisualStyleBackColor = true;
            this.buttonAgregarCarrito.Click += new System.EventHandler(this.buttonAgregarCarrito_Click);
            // 
            // buttonSumar
            // 
            this.buttonSumar.Location = new System.Drawing.Point(365, 144);
            this.buttonSumar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(37, 26);
            this.buttonSumar.TabIndex = 7;
            this.buttonSumar.Text = "+";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
            // 
            // buttonRestar
            // 
            this.buttonRestar.Location = new System.Drawing.Point(249, 144);
            this.buttonRestar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRestar.Name = "buttonRestar";
            this.buttonRestar.Size = new System.Drawing.Size(37, 26);
            this.buttonRestar.TabIndex = 6;
            this.buttonRestar.Text = "-";
            this.buttonRestar.UseVisualStyleBackColor = true;
            this.buttonRestar.Click += new System.EventHandler(this.buttonRestar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Enabled = false;
            this.textBoxCantidad.Location = new System.Drawing.Point(295, 144);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(61, 22);
            this.textBoxCantidad.TabIndex = 5;
            this.textBoxCantidad.Text = "1";
            // 
            // labelPrecioProducto
            // 
            this.labelPrecioProducto.AutoSize = true;
            this.labelPrecioProducto.Location = new System.Drawing.Point(251, 101);
            this.labelPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecioProducto.Name = "labelPrecioProducto";
            this.labelPrecioProducto.Size = new System.Drawing.Size(44, 16);
            this.labelPrecioProducto.TabIndex = 4;
            this.labelPrecioProducto.Text = "label4";
            // 
            // labelNombreProducto
            // 
            this.labelNombreProducto.AutoSize = true;
            this.labelNombreProducto.Location = new System.Drawing.Point(251, 53);
            this.labelNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreProducto.Name = "labelNombreProducto";
            this.labelNombreProducto.Size = new System.Drawing.Size(44, 16);
            this.labelNombreProducto.TabIndex = 3;
            this.labelNombreProducto.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // button2
            // 
            this.button2.Image = global::PROYECTO_MINIMARKET.Properties.Resources._63007shoppingcart_109353;
            this.button2.Location = new System.Drawing.Point(943, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 46);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(991, 174);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxNombre);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(533, 53);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(480, 121);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(52, 52);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(245, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCategoria);
            this.groupBox2.Controls.Add(this.ComboCategoria);
            this.groupBox2.Location = new System.Drawing.Point(21, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(488, 121);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por categoria";
            // 
            // buttonCategoria
            // 
            this.buttonCategoria.Location = new System.Drawing.Point(323, 53);
            this.buttonCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCategoria.Name = "buttonCategoria";
            this.buttonCategoria.Size = new System.Drawing.Size(112, 26);
            this.buttonCategoria.TabIndex = 1;
            this.buttonCategoria.Text = "Buscar";
            this.buttonCategoria.UseVisualStyleBackColor = true;
            this.buttonCategoria.Click += new System.EventHandler(this.buttonCategoria_Click);
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(48, 53);
            this.ComboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(245, 24);
            this.ComboCategoria.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelTotal);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.buttonConfirmarVenta);
            this.groupBox5.Controls.Add(this.buttonSalirCarritoCompras);
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(16, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1033, 385);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carrito de compras";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(476, 278);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 16);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // buttonConfirmarVenta
            // 
            this.buttonConfirmarVenta.Location = new System.Drawing.Point(464, 313);
            this.buttonConfirmarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirmarVenta.Name = "buttonConfirmarVenta";
            this.buttonConfirmarVenta.Size = new System.Drawing.Size(139, 49);
            this.buttonConfirmarVenta.TabIndex = 2;
            this.buttonConfirmarVenta.Text = "Confirmar venta";
            this.buttonConfirmarVenta.UseVisualStyleBackColor = true;
            this.buttonConfirmarVenta.Click += new System.EventHandler(this.buttonConfirmarVenta_Click);
            // 
            // buttonSalirCarritoCompras
            // 
            this.buttonSalirCarritoCompras.BackColor = System.Drawing.Color.Gray;
            this.buttonSalirCarritoCompras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalirCarritoCompras.Location = new System.Drawing.Point(957, 11);
            this.buttonSalirCarritoCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSalirCarritoCompras.Name = "buttonSalirCarritoCompras";
            this.buttonSalirCarritoCompras.Size = new System.Drawing.Size(76, 46);
            this.buttonSalirCarritoCompras.TabIndex = 1;
            this.buttonSalirCarritoCompras.Text = "Volver";
            this.buttonSalirCarritoCompras.UseVisualStyleBackColor = false;
            this.buttonSalirCarritoCompras.Click += new System.EventHandler(this.buttonSalirCarritoCompras_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 64);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1017, 201);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // FormRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 686);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRegistrarVenta";
            this.Text = "FormRegistrarVenta";
            this.Load += new System.EventHandler(this.FormRegistrarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Button buttonConfirmarVenta;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
    }
}