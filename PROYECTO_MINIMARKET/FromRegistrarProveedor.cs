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

        private void button2_Click(object sender, EventArgs e)
        {
            if (text_nit.Text==string.Empty||text_ciudad.Text==string.Empty||text_razonSocial.Text==string.Empty||text_correo.Text==string.Empty||text_direccion.Text==string.Empty||text_telefono.Text==string.Empty)
            {
                MessageBox.Show("Los campos deben estar llenos");
            }
            else { 

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
}
