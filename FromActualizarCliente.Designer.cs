namespace PROYECTO_MINIMARKET
{
    partial class FromActualizarCliente
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
            this.groupBoxCli = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CorreoCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnRegsitrarCliente = new System.Windows.Forms.Button();
            this.NoDocumentoCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelefonoCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ApellidoCli = new System.Windows.Forms.TextBox();
            this.NombreCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DireccionCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCli
            // 
            this.groupBoxCli.Controls.Add(this.dataGridView1);
            this.groupBoxCli.Controls.Add(this.label4);
            this.groupBoxCli.Controls.Add(this.CorreoCli);
            this.groupBoxCli.Controls.Add(this.label7);
            this.groupBoxCli.Controls.Add(this.label5);
            this.groupBoxCli.Controls.Add(this.CBoxTipoDocumento);
            this.groupBoxCli.Controls.Add(this.btnRegsitrarCliente);
            this.groupBoxCli.Controls.Add(this.NoDocumentoCli);
            this.groupBoxCli.Controls.Add(this.label6);
            this.groupBoxCli.Controls.Add(this.TelefonoCli);
            this.groupBoxCli.Controls.Add(this.label3);
            this.groupBoxCli.Controls.Add(this.ApellidoCli);
            this.groupBoxCli.Controls.Add(this.NombreCli);
            this.groupBoxCli.Controls.Add(this.label2);
            this.groupBoxCli.Controls.Add(this.DireccionCli);
            this.groupBoxCli.Controls.Add(this.label1);
            this.groupBoxCli.Location = new System.Drawing.Point(10, 11);
            this.groupBoxCli.Name = "groupBoxCli";
            this.groupBoxCli.Size = new System.Drawing.Size(776, 426);
            this.groupBoxCli.TabIndex = 2;
            this.groupBoxCli.TabStop = false;
            this.groupBoxCli.Text = "actualizarCliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "DIRECCIÓN:";
            // 
            // CorreoCli
            // 
            this.CorreoCli.Location = new System.Drawing.Point(542, 120);
            this.CorreoCli.Name = "CorreoCli";
            this.CorreoCli.Size = new System.Drawing.Size(185, 20);
            this.CorreoCli.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "CORREO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "TIPO DE DOCUMENTO:";
            // 
            // CBoxTipoDocumento
            // 
            this.CBoxTipoDocumento.FormattingEnabled = true;
            this.CBoxTipoDocumento.Items.AddRange(new object[] {
            "CC",
            "CE",
            "PEP",
            "PE"});
            this.CBoxTipoDocumento.Location = new System.Drawing.Point(542, 64);
            this.CBoxTipoDocumento.Name = "CBoxTipoDocumento";
            this.CBoxTipoDocumento.Size = new System.Drawing.Size(185, 21);
            this.CBoxTipoDocumento.TabIndex = 28;
            // 
            // btnRegsitrarCliente
            // 
            this.btnRegsitrarCliente.Location = new System.Drawing.Point(348, 325);
            this.btnRegsitrarCliente.Name = "btnRegsitrarCliente";
            this.btnRegsitrarCliente.Size = new System.Drawing.Size(105, 37);
            this.btnRegsitrarCliente.TabIndex = 27;
            this.btnRegsitrarCliente.Text = "ACTUALIZAR";
            this.btnRegsitrarCliente.UseVisualStyleBackColor = true;
            this.btnRegsitrarCliente.Click += new System.EventHandler(this.btnRegsitrarCliente_Click);
            // 
            // NoDocumentoCli
            // 
            this.NoDocumentoCli.Location = new System.Drawing.Point(152, 65);
            this.NoDocumentoCli.Name = "NoDocumentoCli";
            this.NoDocumentoCli.Size = new System.Drawing.Size(185, 20);
            this.NoDocumentoCli.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "NO. DOCUMENTO:";
            // 
            // TelefonoCli
            // 
            this.TelefonoCli.Location = new System.Drawing.Point(152, 236);
            this.TelefonoCli.Name = "TelefonoCli";
            this.TelefonoCli.Size = new System.Drawing.Size(185, 20);
            this.TelefonoCli.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "TELÉFONO:";
            // 
            // ApellidoCli
            // 
            this.ApellidoCli.Location = new System.Drawing.Point(152, 177);
            this.ApellidoCli.Name = "ApellidoCli";
            this.ApellidoCli.Size = new System.Drawing.Size(185, 20);
            this.ApellidoCli.TabIndex = 22;
            // 
            // NombreCli
            // 
            this.NombreCli.Location = new System.Drawing.Point(152, 120);
            this.NombreCli.Name = "NombreCli";
            this.NombreCli.Size = new System.Drawing.Size(185, 20);
            this.NombreCli.TabIndex = 20;
            this.NombreCli.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "APELLIDOS:";
            // 
            // DireccionCli
            // 
            this.DireccionCli.Location = new System.Drawing.Point(542, 177);
            this.DireccionCli.Name = "DireccionCli";
            this.DireccionCli.PasswordChar = '*';
            this.DireccionCli.Size = new System.Drawing.Size(185, 20);
            this.DireccionCli.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "NOMBRES:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 360);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FromActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 448);
            this.Controls.Add(this.groupBoxCli);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FromActualizarCliente";
            this.Text = "FromActualizarCliente";
            this.Load += new System.EventHandler(this.FromActualizarCliente_Load);
            this.groupBoxCli.ResumeLayout(false);
            this.groupBoxCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCli;
        private System.Windows.Forms.TextBox CorreoCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxTipoDocumento;
        private System.Windows.Forms.Button btnRegsitrarCliente;
        private System.Windows.Forms.TextBox NoDocumentoCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TelefonoCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApellidoCli;
        private System.Windows.Forms.TextBox NombreCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DireccionCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}