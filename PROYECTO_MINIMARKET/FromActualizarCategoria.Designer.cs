namespace PROYECTO_MINIMARKET
{
    partial class FromActualizarCategoria
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtDescripcionCategoriaAc = new System.Windows.Forms.RichTextBox();
            this.txtIdCategoriaAc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCategoriaAc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcCategoria = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.epActualizarCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epActualizarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 524);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Categoria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtxtDescripcionCategoriaAc);
            this.groupBox2.Controls.Add(this.txtIdCategoriaAc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNombreCategoriaAc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAcCategoria);
            this.groupBox2.Location = new System.Drawing.Point(101, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(799, 306);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar Categoria";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID CATEGORIA:";
            // 
            // rtxtDescripcionCategoriaAc
            // 
            this.rtxtDescripcionCategoriaAc.Location = new System.Drawing.Point(263, 167);
            this.rtxtDescripcionCategoriaAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtDescripcionCategoriaAc.Name = "rtxtDescripcionCategoriaAc";
            this.rtxtDescripcionCategoriaAc.Size = new System.Drawing.Size(216, 112);
            this.rtxtDescripcionCategoriaAc.TabIndex = 18;
            this.rtxtDescripcionCategoriaAc.Text = "";
            // 
            // txtIdCategoriaAc
            // 
            this.txtIdCategoriaAc.Location = new System.Drawing.Point(263, 46);
            this.txtIdCategoriaAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdCategoriaAc.Name = "txtIdCategoriaAc";
            this.txtIdCategoriaAc.Size = new System.Drawing.Size(216, 22);
            this.txtIdCategoriaAc.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "DESCRIPCION:";
            // 
            // txtNombreCategoriaAc
            // 
            this.txtNombreCategoriaAc.Location = new System.Drawing.Point(263, 105);
            this.txtNombreCategoriaAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCategoriaAc.Name = "txtNombreCategoriaAc";
            this.txtNombreCategoriaAc.Size = new System.Drawing.Size(216, 22);
            this.txtNombreCategoriaAc.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "NOMBRE:";
            // 
            // btnAcCategoria
            // 
            this.btnAcCategoria.Location = new System.Drawing.Point(588, 122);
            this.btnAcCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcCategoria.Name = "btnAcCategoria";
            this.btnAcCategoria.Size = new System.Drawing.Size(164, 49);
            this.btnAcCategoria.TabIndex = 13;
            this.btnAcCategoria.Text = "Actualizar";
            this.btnAcCategoria.UseVisualStyleBackColor = true;
            this.btnAcCategoria.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 398);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // epActualizarCategoria
            // 
            this.epActualizarCategoria.ContainerControl = this;
            // 
            // FromActualizarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 548);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FromActualizarCategoria";
            this.Text = "FromConsultarCategoria";
            this.Load += new System.EventHandler(this.FromActualizarCategoria_Load);
            this.VisibleChanged += new System.EventHandler(this.FromActualizarCategoria_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epActualizarCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAcCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIdCategoriaAc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCategoriaAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtDescripcionCategoriaAc;
        private System.Windows.Forms.ErrorProvider epActualizarCategoria;
    }
}