namespace PROYECTO_MINIMARKET
{
    partial class FromRegistrarCliente
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
            this.CorreoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxTipoDocuCliente = new System.Windows.Forms.ComboBox();
            this.btnRegsitrarCliente = new System.Windows.Forms.Button();
            this.NoDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelefonoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ApellidoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DireccionCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epRegistrarCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRegistrarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CorreoCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBoxTipoDocuCliente);
            this.groupBox1.Controls.Add(this.btnRegsitrarCliente);
            this.groupBox1.Controls.Add(this.NoDocumentoCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TelefonoCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ApellidoCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DireccionCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 524);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "registrarCliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CorreoCliente
            // 
            this.CorreoCliente.Location = new System.Drawing.Point(707, 238);
            this.CorreoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoCliente.Name = "CorreoCliente";
            this.CorreoCliente.Size = new System.Drawing.Size(245, 22);
            this.CorreoCliente.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 241);
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
            // CBoxTipoDocuCliente
            // 
            this.CBoxTipoDocuCliente.FormattingEnabled = true;
            this.CBoxTipoDocuCliente.Items.AddRange(new object[] {
            "Cedula De Ciudadania",
            "Cedula Extranjera ",
            "PEP ",
            "Pasaporte"});
            this.CBoxTipoDocuCliente.Location = new System.Drawing.Point(707, 98);
            this.CBoxTipoDocuCliente.Margin = new System.Windows.Forms.Padding(4);
            this.CBoxTipoDocuCliente.Name = "CBoxTipoDocuCliente";
            this.CBoxTipoDocuCliente.Size = new System.Drawing.Size(245, 24);
            this.CBoxTipoDocuCliente.TabIndex = 11;
            // 
            // btnRegsitrarCliente
            // 
            this.btnRegsitrarCliente.Location = new System.Drawing.Point(448, 420);
            this.btnRegsitrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegsitrarCliente.Name = "btnRegsitrarCliente";
            this.btnRegsitrarCliente.Size = new System.Drawing.Size(140, 46);
            this.btnRegsitrarCliente.TabIndex = 10;
            this.btnRegsitrarCliente.Text = "REGISTRAR";
            this.btnRegsitrarCliente.UseVisualStyleBackColor = true;
            this.btnRegsitrarCliente.Click += new System.EventHandler(this.btnRegsitrarCliente_Click);
            // 
            // NoDocumentoCliente
            // 
            this.NoDocumentoCliente.Location = new System.Drawing.Point(187, 100);
            this.NoDocumentoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.NoDocumentoCliente.Name = "NoDocumentoCliente";
            this.NoDocumentoCliente.Size = new System.Drawing.Size(245, 22);
            this.NoDocumentoCliente.TabIndex = 9;
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
            // TelefonoCliente
            // 
            this.TelefonoCliente.Location = new System.Drawing.Point(707, 170);
            this.TelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.Size = new System.Drawing.Size(245, 22);
            this.TelefonoCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "TELÉFONO:";
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.Location = new System.Drawing.Point(187, 238);
            this.ApellidoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.Size = new System.Drawing.Size(245, 22);
            this.ApellidoCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "DIRECCION:";
            // 
            // NombreCliente
            // 
            this.NombreCliente.Location = new System.Drawing.Point(187, 167);
            this.NombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(245, 22);
            this.NombreCliente.TabIndex = 3;
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
            // DireccionCliente
            // 
            this.DireccionCliente.Location = new System.Drawing.Point(187, 304);
            this.DireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.Size = new System.Drawing.Size(245, 22);
            this.DireccionCliente.TabIndex = 1;
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
            // epRegistrarCliente
            // 
            this.epRegistrarCliente.ContainerControl = this;
            // 
            // FromRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 546);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FromRegistrarCliente";
            this.Text = "FromRegistrarCliente";
            this.Load += new System.EventHandler(this.FromRegistrarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRegistrarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NoDocumentoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TelefonoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApellidoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DireccionCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegsitrarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxTipoDocuCliente;
        private System.Windows.Forms.TextBox CorreoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider epRegistrarCliente;
    }
}