namespace PROYECTO_MINIMARKET
{
    partial class FromRegistrarEmpleado
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
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnRCliente = new System.Windows.Forms.Button();
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
            this.epREmpleado = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epREmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ConfirmarContrasena);
            this.groupBox1.Controls.Add(this.Correo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBoxTipoDocumento);
            this.groupBox1.Controls.Add(this.btnRCliente);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 524);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "CONFIRMAR CONTRASEÑA:";
            // 
            // ConfirmarContrasena
            // 
            this.ConfirmarContrasena.Location = new System.Drawing.Point(707, 310);
            this.ConfirmarContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmarContrasena.Name = "ConfirmarContrasena";
            this.ConfirmarContrasena.PasswordChar = '*';
            this.ConfirmarContrasena.Size = new System.Drawing.Size(245, 22);
            this.ConfirmarContrasena.TabIndex = 15;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(707, 167);
            this.Correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(245, 22);
            this.Correo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "CORREO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
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
            this.CBoxTipoDocumento.Location = new System.Drawing.Point(707, 98);
            this.CBoxTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBoxTipoDocumento.Name = "CBoxTipoDocumento";
            this.CBoxTipoDocumento.Size = new System.Drawing.Size(245, 24);
            this.CBoxTipoDocumento.TabIndex = 11;
            // 
            // btnRCliente
            // 
            this.btnRCliente.Location = new System.Drawing.Point(448, 420);
            this.btnRCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRCliente.Name = "btnRCliente";
            this.btnRCliente.Size = new System.Drawing.Size(140, 46);
            this.btnRCliente.TabIndex = 10;
            this.btnRCliente.Text = "REGISTRAR";
            this.btnRCliente.UseVisualStyleBackColor = true;
            this.btnRCliente.Click += new System.EventHandler(this.btnRegsitrarCliente_Click);
            // 
            // NoDocumento
            // 
            this.NoDocumento.Location = new System.Drawing.Point(187, 100);
            this.NoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoDocumento.Name = "NoDocumento";
            this.NoDocumento.Size = new System.Drawing.Size(245, 22);
            this.NoDocumento.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "NO. DOCUMENTO:";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(187, 310);
            this.Telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(245, 22);
            this.Telefono.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "TELÉFONO:";
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(187, 238);
            this.Apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(245, 22);
            this.Apellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONTRASEÑA:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(187, 167);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(245, 22);
            this.Nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDOS:";
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(707, 238);
            this.Contraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(245, 22);
            this.Contraseña.TabIndex = 1;
            this.Contraseña.TextChanged += new System.EventHandler(this.Direccion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRES:";
            // 
            // epREmpleado
            // 
            this.epREmpleado.ContainerControl = this;
            // 
            // FromRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FromRegistrarEmpleado";
            this.Text = "FromRegistrarEmpleado";
            this.Load += new System.EventHandler(this.FromRegistrarEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epREmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxTipoDocumento;
        private System.Windows.Forms.Button btnRCliente;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ConfirmarContrasena;
        private System.Windows.Forms.ErrorProvider epREmpleado;
    }
}