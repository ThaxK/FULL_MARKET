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
    public partial class FromRegistrarProveedor : Form
    {
        public FromRegistrarProveedor()
        {
            InitializeComponent();
        }
        
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epRProveedor.Clear();
            if (!val.Nit(text_nit.Text))
            {

                epRProveedor.SetError(text_nit, "Error en el NIT");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(text_razonSocial.Text))
            {
                epRProveedor.SetError(text_razonSocial, "Error en la razon social");
                bandera = 0;
            }
            if (!val.Direccion(text_direccion.Text))
            {
                epRProveedor.SetError(text_direccion, "Error en la direccion");
                bandera = 0;
            }
            if (!val.Telefono(text_telefono.Text))
            {
                epRProveedor.SetError(text_telefono, "Error en el telefono");
                bandera = 0;
            }
            if (!val.CorreoElectronico(text_correo.Text))
            {
                epRProveedor.SetError(text_correo, "Error en el correo");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(text_ciudad.Text))
            {
                epRProveedor.SetError(text_ciudad, "Error en la ciudad");
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                if (text_nit.Text==string.Empty||text_ciudad.Text==string.Empty||text_razonSocial.Text==string.Empty||text_correo.Text==string.Empty||text_direccion.Text==string.Empty||text_telefono.Text==string.Empty)
                {
                    MessageBox.Show("Los campos deben estar llenos");
                }
                else
                {

                    Proveedor objProveedor = new Proveedor();
                    objProveedor.nit = text_nit.Text.Trim();
                    objProveedor.ciudad=text_ciudad.Text.Trim();
                    objProveedor.razonSocial=text_razonSocial.Text.Trim();
                    objProveedor.correo=text_correo.Text.Trim();
                    objProveedor.direccion=text_direccion.Text.Trim();
                    objProveedor.telefono=text_telefono.Text.Trim();

                    if (CN_Proveedores.RegistrarProveedor(objProveedor))
                    {
                        MessageBox.Show("Registro exitoso");
                    }
                    else
                    {
                        MessageBox.Show("Registro fallido");
                    }
                }
            }
        }

        private void FromRegistrarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
