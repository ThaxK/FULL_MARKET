namespace PROYECTO_MINIMARKET
{
    partial class FromConsultarEmpleado
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
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnRegsitrarCliente = new System.Windows.Forms.Button();
            this.NoDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Correo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBoxTipoDocumento);
            this.groupBox1.Controls.Add(this.btnRegsitrarCliente);
            this.groupBox1.Controls.Add(this.NoDocumento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Apellido);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Contraseña);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar Empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CONFIRMAR CONTRASEÑA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 15;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(530, 136);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(185, 20);
            this.Correo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CORREO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "TIPO DE DOCUMENTO:";
            // 
            // CBoxTipoDocumento
            // 
            this.CBoxTipoDocumento.FormattingEnabled = true;
            this.CBoxTipoDocumento.Items.AddRange(new object[] {
            "Cedula De Ciudadania",
            "Cedula Extranjera ",
            "PEP ",
            "Pasaporte"});
            this.CBoxTipoDocumento.Location = new System.Drawing.Point(530, 80);
            this.CBoxTipoDocumento.Name = "CBoxTipoDocumento";
            this.CBoxTipoDocumento.Size = new System.Drawing.Size(185, 21);
            this.CBoxTipoDocumento.TabIndex = 11;
            // 
            // btnRegsitrarCliente
            // 
            this.btnRegsitrarCliente.Location = new System.Drawing.Point(336, 341);
            this.btnRegsitrarCliente.Name = "btnRegsitrarCliente";
            this.btnRegsitrarCliente.Size = new System.Drawing.Size(105, 37);
            this.btnRegsitrarCliente.TabIndex = 10;
            this.btnRegsitrarCliente.Text = "ACTUALIZAR";
            this.btnRegsitrarCliente.UseVisualStyleBackColor = true;
            this.btnRegsitrarCliente.Click += new System.EventHandler(this.btnRegsitrarCliente_Click);
            // 
            // NoDocumento
            // 
            this.NoDocumento.Location = new System.Drawing.Point(140, 81);
            this.NoDocumento.Name = "NoDocumento";
            this.NoDocumento.Size = new System.Drawing.Size(185, 20);
            this.NoDocumento.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "NO. DOCUMENTO:";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(140, 252);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(185, 20);
            this.Telefono.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TELÉFONO:";
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(140, 193);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(185, 20);
            this.Apellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONTRASEÑA:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(140, 136);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(185, 20);
            this.Nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDOS:";
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(530, 193);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(185, 20);
            this.Contraseña.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRES:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(741, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FromConsultarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FromConsultarEmpleado";
            this.Text = "FromConsultarEmpleado";
            this.Load += new System.EventHandler(this.FromConsultarEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxTipoDocumento;
        private System.Windows.Forms.Button btnRegsitrarCliente;
        private System.Windows.Forms.TextBox NoDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}