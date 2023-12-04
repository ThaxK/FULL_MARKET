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
    public partial class FromActualizarFullMarket : Form
    {
        public FromActualizarFullMarket()
        {
            InitializeComponent();
        }

        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epAcFullmarket.Clear();

            if (!val.Nit(txtNitFullMarketAC.Text))
            {
                epAcFullmarket.SetError(txtNitFullMarketAC, "Error en el nit");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(txtRazonSocialFullMarketAc.Text))
            {
                epAcFullmarket.SetError(txtRazonSocialFullMarketAc, "Error en el nit");
                bandera = 0;
            }
            if (!val.Direccion(txtDireccionFullMarketAc.Text))
            {
                epAcFullmarket.SetError(txtDireccionFullMarketAc, "Error en la direccion");
                bandera = 0;
            }
            if (!val.Telefono(txtTelefonoFullMarketAc.Text))
            {
                epAcFullmarket.SetError(txtTelefonoFullMarketAc, "Error en el telefono");
                bandera = 0;
            }
            if (!val.CorreoElectronico(txtCorreoFullMarketAc.Text))
            {
                epAcFullmarket.SetError(txtCorreoFullMarketAc, "Error en el correo");
                bandera = 0;
            }
            if (!val.Web(txtWebFullMarketAc.Text))
            {
                epAcFullmarket.SetError(txtWebFullMarketAc, "Error en la direccion web");
                bandera = 0;
            }

            if (bandera == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            if (validarFormulario())
            {
                FullMarket objFullMarket = new FullMarket();

                objFullMarket.Nit = txtNitFullMarketAC.Text.Trim();
                objFullMarket.RazonSocial = txtRazonSocialFullMarketAc.Text.Trim();
                objFullMarket.Direccion = txtDireccionFullMarketAc.Text.Trim();
                objFullMarket.Telefono = txtTelefonoFullMarketAc.Text.Trim();
                objFullMarket.Correo = txtCorreoFullMarketAc.Text.Trim();
                objFullMarket.DireccionWeb = txtWebFullMarketAc.Text.Trim();

                if (CN_FullMarket.ActualizarFullMarket(objFullMarket))
                    MessageBox.Show("Actualización exitosa");
                else
                    MessageBox.Show("Fallo en la actualización");
            }
        }

        private void text_razonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromRegistrarFullMarket_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt=CN_FullMarket.ConsultarFullMarket();

            txtNitFullMarketAC.Text = dt.Rows[0]["nit"].ToString();
            txtRazonSocialFullMarketAc.Text = dt.Rows[0]["razonSocial"].ToString();
            txtDireccionFullMarketAc.Text = dt.Rows[0]["direccion"].ToString();
            txtTelefonoFullMarketAc.Text = dt.Rows[0]["telefono"].ToString();
            txtCorreoFullMarketAc.Text = dt.Rows[0]["correo"].ToString();
            txtWebFullMarketAc.Text = dt.Rows[0]["direccionWeb"].ToString();
        }
    }
}
