using CL_capa_entidades;
using CL_capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MINIMARKET
{
    public partial class FromRegistrarFullMarket : Form
    {
        public FromRegistrarFullMarket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_registrarNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrarFullMarket_Click(object sender, EventArgs e)
        {
            FullMarket objFullMarket = new FullMarket();

            objFullMarket.Nit = text_registrarNit.Text.Trim();
            objFullMarket.RazonSocial = text_razonSocial.Text.Trim();
            objFullMarket.Direccion = text_Direccion.Text.Trim();
            objFullMarket.Telefono = text_Telefono.Text.Trim();
            objFullMarket.Correo = text_Correo.Text.Trim();
            objFullMarket.DireccionWeb = text_Web.Text.Trim();

            if (CN_FullMarket.InsertarFullMarket(objFullMarket))
                MessageBox.Show("Registro exitoso");
            else
                MessageBox.Show("Fallo en la incersion");
        }

        private void FrmRegistrarFullMarket_Load(object sender, EventArgs e)
        {
            


        }

        private void text_razonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromRegistrarFullMarket_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
            DataTable dt = new DataTable();
            dt = CN_FullMarket.consultarFullMarket();

            text_registrarNit.Text = dt.Rows[0]["nitFullmarket"].ToString();
            text_razonSocial.Text = dt.Rows[0]["razonSocial"].ToString();
            text_Direccion.Text = dt.Rows[0]["Direccion"].ToString();
            text_Telefono.Text = dt.Rows[0]["Telefono"].ToString();
            text_Correo.Text = dt.Rows[0]["Correo"].ToString();
            text_Web.Text = dt.Rows[0]["DireccionWeb"].ToString();

        }
    }
}
