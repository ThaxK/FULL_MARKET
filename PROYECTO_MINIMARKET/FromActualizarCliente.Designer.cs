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
            this.components = new System.ComponentModel.Container();
            this.groupBoxCli = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreoClienteAc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnRegsitrarCliente = new System.Windows.Forms.Button();
            this.txtDocumentoClienteAc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoClienteAc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoClienteAc = new System.Windows.Forms.TextBox();
            this.txtNombreClienteAc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epAcCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAcCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCli
            // 
            this.groupBoxCli.Controls.Add(this.dataGridView1);
            this.groupBoxCli.Controls.Add(this.label4);
            this.groupBoxCli.Controls.Add(this.txtCorreoClienteAc);
            this.groupBoxCli.Controls.Add(this.label7);
            this.groupBoxCli.Controls.Add(this.label5);
            this.groupBoxCli.Controls.Add(this.CBoxTipoDocumento);
            this.groupBoxCli.Controls.Add(this.btnRegsitrarCliente);
            this.groupBoxCli.Controls.Add(this.txtDocumentoClienteAc);
            this.groupBoxCli.Controls.Add(this.label6);
            this.groupBoxCli.Controls.Add(this.txtTelefonoClienteAc);
            this.groupBoxCli.Controls.Add(this.label3);
            this.groupBoxCli.Controls.Add(this.txtApellidoClienteAc);
            this.groupBoxCli.Controls.Add(this.txtNombreClienteAc);
            this.groupBoxCli.Controls.Add(this.label2);
            this.groupBoxCli.Controls.Add(this.txtDireccion);
            this.groupBoxCli.Controls.Add(this.label1);
            this.groupBoxCli.Location = new System.Drawing.Point(13, 14);
            this.groupBoxCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCli.Name = "groupBoxCli";
            this.groupBoxCli.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCli.Size = new System.Drawing.Size(1035, 508);
            this.groupBoxCli.TabIndex = 2;
            this.groupBoxCli.TabStop = false;
            this.groupBoxCli.Text = "actualizarCliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(976, 443);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "DIRECCIÓN:";
            // 
            // txtCorreoClienteAc
            // 
            this.txtCorreoClienteAc.Location = new System.Drawing.Point(723, 148);
            this.txtCorreoClienteAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreoClienteAc.Name = "txtCorreoClienteAc";
            this.txtCorreoClienteAc.Size = new System.Drawing.Size(245, 22);
            this.txtCorreoClienteAc.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "CORREO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
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
            this.CBoxTipoDocumento.Location = new System.Drawing.Point(723, 79);
            this.CBoxTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBoxTipoDocumento.Name = "CBoxTipoDocumento";
            this.CBoxTipoDocumento.Size = new System.Drawing.Size(245, 24);
            this.CBoxTipoDocumento.TabIndex = 28;
            // 
            // btnRegsitrarCliente
            // 
            this.btnRegsitrarCliente.Location = new System.Drawing.Point(464, 400);
            this.btnRegsitrarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegsitrarCliente.Name = "btnRegsitrarCliente";
            this.btnRegsitrarCliente.Size = new System.Drawing.Size(140, 46);
            this.btnRegsitrarCliente.TabIndex = 27;
            this.btnRegsitrarCliente.Text = "ACTUALIZAR";
            this.btnRegsitrarCliente.UseVisualStyleBackColor = true;
            this.btnRegsitrarCliente.Click += new System.EventHandler(this.btnRegsitrarCliente_Click);
            // 
            // txtDocumentoClienteAc
            // 
            this.txtDocumentoClienteAc.Enabled = false;
            this.txtDocumentoClienteAc.Location = new System.Drawing.Point(203, 80);
            this.txtDocumentoClienteAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumentoClienteAc.Name = "txtDocumentoClienteAc";
            this.txtDocumentoClienteAc.Size = new System.Drawing.Size(245, 22);
            this.txtDocumentoClienteAc.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "NO. DOCUMENTO:";
            // 
            // txtTelefonoClienteAc
            // 
            this.txtTelefonoClienteAc.Location = new System.Drawing.Point(203, 290);
            this.txtTelefonoClienteAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefonoClienteAc.Name = "txtTelefonoClienteAc";
            this.txtTelefonoClienteAc.Size = new System.Drawing.Size(245, 22);
            this.txtTelefonoClienteAc.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "TELÉFONO:";
            // 
            // txtApellidoClienteAc
            // 
            this.txtApellidoClienteAc.Location = new System.Drawing.Point(203, 218);
            this.txtApellidoClienteAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoClienteAc.Name = "txtApellidoClienteAc";
            this.txtApellidoClienteAc.Size = new System.Drawing.Size(245, 22);
            this.txtApellidoClienteAc.TabIndex = 22;
            // 
            // txtNombreClienteAc
            // 
            this.txtNombreClienteAc.Location = new System.Drawing.Point(203, 148);
            this.txtNombreClienteAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreClienteAc.Name = "txtNombreClienteAc";
            this.txtNombreClienteAc.Size = new System.Drawing.Size(245, 22);
            this.txtNombreClienteAc.TabIndex = 20;
            this.txtNombreClienteAc.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "APELLIDOS:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(723, 218);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '*';
            this.txtDireccion.Size = new System.Drawing.Size(245, 22);
            this.txtDireccion.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "NOMBRES:";
            // 
            // epAcCliente
            // 
            this.epAcCliente.ContainerControl = this;
            // 
            // FromActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1058, 549);
            this.Controls.Add(this.groupBoxCli);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FromActualizarCliente";
            this.Text = "FromActualizarCliente";
            this.Load += new System.EventHandler(this.FromActualizarCliente_Load);
            this.groupBoxCli.ResumeLayout(false);
            this.groupBoxCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAcCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCli;
        private System.Windows.Forms.TextBox txtCorreoClienteAc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxTipoDocumento;
        private System.Windows.Forms.Button btnRegsitrarCliente;
        private System.Windows.Forms.TextBox txtDocumentoClienteAc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonoClienteAc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoClienteAc;
        private System.Windows.Forms.TextBox txtNombreClienteAc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider epAcCliente;
    }
}