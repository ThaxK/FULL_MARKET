namespace PROYECTO_MINIMARKET
{
    partial class FromConsultarProducto
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDescripcionAc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioAc = new System.Windows.Forms.TextBox();
            this.btnAcProducto = new System.Windows.Forms.Button();
            this.txtNombreProductoAc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoAc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadAc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epProductoAc = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProductoAc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtDescripcionAc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioAc);
            this.groupBox1.Controls.Add(this.btnAcProducto);
            this.groupBox1.Controls.Add(this.txtNombreProductoAc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCodigoAc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantidadAc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 473);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "CATEGORIA:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(685, 194);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // txtDescripcionAc
            // 
            this.txtDescripcionAc.Location = new System.Drawing.Point(685, 49);
            this.txtDescripcionAc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionAc.Name = "txtDescripcionAc";
            this.txtDescripcionAc.Size = new System.Drawing.Size(245, 104);
            this.txtDescripcionAc.TabIndex = 26;
            this.txtDescripcionAc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "CODIGO:";
            // 
            // txtPrecioAc
            // 
            this.txtPrecioAc.Location = new System.Drawing.Point(197, 194);
            this.txtPrecioAc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioAc.Name = "txtPrecioAc";
            this.txtPrecioAc.Size = new System.Drawing.Size(245, 22);
            this.txtPrecioAc.TabIndex = 24;
            // 
            // btnAcProducto
            // 
            this.btnAcProducto.Location = new System.Drawing.Point(471, 305);
            this.btnAcProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcProducto.Name = "btnAcProducto";
            this.btnAcProducto.Size = new System.Drawing.Size(120, 41);
            this.btnAcProducto.TabIndex = 23;
            this.btnAcProducto.Text = "ACTUALIZAR";
            this.btnAcProducto.UseVisualStyleBackColor = true;
            this.btnAcProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreProductoAc
            // 
            this.txtNombreProductoAc.Location = new System.Drawing.Point(197, 49);
            this.txtNombreProductoAc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProductoAc.Name = "txtNombreProductoAc";
            this.txtNombreProductoAc.Size = new System.Drawing.Size(245, 22);
            this.txtNombreProductoAc.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "NOMBRE:";
            // 
            // txtCodigoAc
            // 
            this.txtCodigoAc.Location = new System.Drawing.Point(197, 146);
            this.txtCodigoAc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoAc.Name = "txtCodigoAc";
            this.txtCodigoAc.Size = new System.Drawing.Size(245, 22);
            this.txtCodigoAc.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "DESCRIPCION:";
            // 
            // txtCantidadAc
            // 
            this.txtCantidadAc.Location = new System.Drawing.Point(197, 98);
            this.txtCantidadAc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadAc.Name = "txtCantidadAc";
            this.txtCantidadAc.Size = new System.Drawing.Size(245, 22);
            this.txtCantidadAc.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "CANTIDAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "PRECIO:";
            // 
            // epProductoAc
            // 
            this.epProductoAc.ContainerControl = this;
            // 
            // FromConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FromConsultarProducto";
            this.Text = "FromConsultarProducto";
            this.Load += new System.EventHandler(this.FromConsultarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProductoAc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox txtDescripcionAc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioAc;
        private System.Windows.Forms.Button btnAcProducto;
        private System.Windows.Forms.TextBox txtNombreProductoAc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoAc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadAc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epProductoAc;
    }
}