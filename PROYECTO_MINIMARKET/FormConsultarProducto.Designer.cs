namespace PROYECTO_MINIMARKET
{
    partial class FormConsultarProducto
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxActualizar = new System.Windows.Forms.GroupBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNombreActualizar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(238, 104);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(267, 20);
            this.textBoxNombre.TabIndex = 22;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(175, 107);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(57, 13);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "NOMBRE:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 226);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "CONSULTAR PRODUCTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxActualizar
            // 
            this.groupBoxActualizar.Controls.Add(this.labelCategoria);
            this.groupBoxActualizar.Controls.Add(this.comboBox1);
            this.groupBoxActualizar.Controls.Add(this.richTextBoxDescripcion);
            this.groupBoxActualizar.Controls.Add(this.labelCodigo);
            this.groupBoxActualizar.Controls.Add(this.textBoxPrecio);
            this.groupBoxActualizar.Controls.Add(this.button2);
            this.groupBoxActualizar.Controls.Add(this.textBoxNombreActualizar);
            this.groupBoxActualizar.Controls.Add(this.label2);
            this.groupBoxActualizar.Controls.Add(this.textBoxCodigo);
            this.groupBoxActualizar.Controls.Add(this.labelDescripcion);
            this.groupBoxActualizar.Controls.Add(this.textBoxCantidad);
            this.groupBoxActualizar.Controls.Add(this.labelCantidad);
            this.groupBoxActualizar.Controls.Add(this.labelPrecio);
            this.groupBoxActualizar.Location = new System.Drawing.Point(33, 25);
            this.groupBoxActualizar.Name = "groupBoxActualizar";
            this.groupBoxActualizar.Size = new System.Drawing.Size(728, 393);
            this.groupBoxActualizar.TabIndex = 26;
            this.groupBoxActualizar.TabStop = false;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(40, 145);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(72, 13);
            this.labelCategoria.TabIndex = 28;
            this.labelCategoria.Text = "CATEGORIA:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(551, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(118, 202);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(551, 92);
            this.richTextBoxDescripcion.TabIndex = 26;
            this.richTextBoxDescripcion.Text = "";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(60, 84);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(52, 13);
            this.labelCodigo.TabIndex = 25;
            this.labelCodigo.Text = "CODIGO:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(484, 81);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(185, 20);
            this.textBoxPrecio.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNombreActualizar
            // 
            this.textBoxNombreActualizar.Location = new System.Drawing.Point(118, 24);
            this.textBoxNombreActualizar.Name = "textBoxNombreActualizar";
            this.textBoxNombreActualizar.Size = new System.Drawing.Size(185, 20);
            this.textBoxNombreActualizar.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "NOMBRE:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(118, 81);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(185, 20);
            this.textBoxCodigo.TabIndex = 20;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(29, 205);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(83, 13);
            this.labelDescripcion.TabIndex = 19;
            this.labelDescripcion.Text = "DESCRIPCIÓN:";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(484, 24);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(185, 20);
            this.textBoxCantidad.TabIndex = 18;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(413, 27);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(65, 13);
            this.labelCantidad.TabIndex = 17;
            this.labelCantidad.Text = "CANTIDAD:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(428, 84);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(50, 13);
            this.labelPrecio.TabIndex = 16;
            this.labelPrecio.Text = "PRECIO:";
            // 
            // FormConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormConsultarProducto";
            this.Text = "FormConsultarProducto";
            this.Activated += new System.EventHandler(this.FormConsultarProducto_Activated);
            this.Load += new System.EventHandler(this.FormConsultarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxActualizar.ResumeLayout(false);
            this.groupBoxActualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxActualizar;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNombreActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelPrecio;
    }
}