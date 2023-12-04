namespace PROYECTO_MINIMARKET
{
    partial class FromRegistrarProducto
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoriaProductoR = new System.Windows.Forms.ComboBox();
            this.rtxtDescripcionProductoR = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioProductoR = new System.Windows.Forms.TextBox();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.txtNombreProductoR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoProductoR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadProductoR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epRegistroProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRegistroProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbCategoriaProductoR);
            this.groupBox1.Controls.Add(this.rtxtDescripcionProductoR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioProductoR);
            this.groupBox1.Controls.Add(this.btnRegistrarProducto);
            this.groupBox1.Controls.Add(this.txtNombreProductoR);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCodigoProductoR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantidadProductoR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 524);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "registrarProducto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "CATEGORIA:";
            // 
            // cbCategoriaProductoR
            // 
            this.cbCategoriaProductoR.FormattingEnabled = true;
            this.cbCategoriaProductoR.Location = new System.Drawing.Point(675, 279);
            this.cbCategoriaProductoR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategoriaProductoR.Name = "cbCategoriaProductoR";
            this.cbCategoriaProductoR.Size = new System.Drawing.Size(245, 24);
            this.cbCategoriaProductoR.TabIndex = 14;
            this.cbCategoriaProductoR.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rtxtDescripcionProductoR
            // 
            this.rtxtDescripcionProductoR.Location = new System.Drawing.Point(675, 134);
            this.rtxtDescripcionProductoR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtDescripcionProductoR.Name = "rtxtDescripcionProductoR";
            this.rtxtDescripcionProductoR.Size = new System.Drawing.Size(245, 104);
            this.rtxtDescripcionProductoR.TabIndex = 13;
            this.rtxtDescripcionProductoR.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "CODIGO:";
            // 
            // txtPrecioProductoR
            // 
            this.txtPrecioProductoR.Location = new System.Drawing.Point(187, 279);
            this.txtPrecioProductoR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioProductoR.Name = "txtPrecioProductoR";
            this.txtPrecioProductoR.Size = new System.Drawing.Size(245, 22);
            this.txtPrecioProductoR.TabIndex = 11;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(460, 390);
            this.btnRegistrarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(120, 41);
            this.btnRegistrarProducto.TabIndex = 10;
            this.btnRegistrarProducto.Text = "REGISTRAR";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreProductoR
            // 
            this.txtNombreProductoR.Location = new System.Drawing.Point(187, 134);
            this.txtNombreProductoR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProductoR.Name = "txtNombreProductoR";
            this.txtNombreProductoR.Size = new System.Drawing.Size(245, 22);
            this.txtNombreProductoR.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "NOMBRE:";
            // 
            // txtCodigoProductoR
            // 
            this.txtCodigoProductoR.Location = new System.Drawing.Point(187, 231);
            this.txtCodigoProductoR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoProductoR.Name = "txtCodigoProductoR";
            this.txtCodigoProductoR.Size = new System.Drawing.Size(245, 22);
            this.txtCodigoProductoR.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESCRIPCION:";
            // 
            // txtCantidadProductoR
            // 
            this.txtCantidadProductoR.Location = new System.Drawing.Point(187, 183);
            this.txtCantidadProductoR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadProductoR.Name = "txtCantidadProductoR";
            this.txtCantidadProductoR.Size = new System.Drawing.Size(245, 22);
            this.txtCantidadProductoR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CANTIDAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRECIO:";
            // 
            // epRegistroProducto
            // 
            this.epRegistroProducto.ContainerControl = this;
            // 
            // FromRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 549);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FromRegistrarProducto";
            this.Text = "FromRegistrarProducto";
            this.Activated += new System.EventHandler(this.FromRegistrarProducto_Activated);
            this.Load += new System.EventHandler(this.FromRegistrarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRegistroProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreProductoR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoProductoR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadProductoR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.TextBox txtPrecioProductoR;
        private System.Windows.Forms.RichTextBox rtxtDescripcionProductoR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoriaProductoR;
        private System.Windows.Forms.ErrorProvider epRegistroProducto;
    }
}