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
    public partial class FromRegistrarEmpleado : Form
    {
        public FromRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegsitrarCliente_Click(object sender, EventArgs e)
        {
            int ayuda = CBoxTipoDocumento.SelectedIndex;
            Empleado objEmpleado= new Empleado();
            objEmpleado.identificacion = NoDocumento.Text.Trim();
            objEmpleado.nombres=Nombre.Text.Trim();
            objEmpleado.apellidos=Apellido.Text.Trim();
            objEmpleado.telefono=Telefono.Text.Trim();
            objEmpleado.correo=Correo.Text.Trim();
            objEmpleado.idFullMarket = 1;
            switch (ayuda)
            {
                case 0:
                    objEmpleado.tipoDocumento = "CC";
                    break;
                case 1:
                    objEmpleado.tipoDocumento = "CE";
                    break;
                case 2:
                    objEmpleado.tipoDocumento = "PAS";
                    break;
                case 3:
                    objEmpleado.tipoDocumento = "PE";
                    break;
            }
            if (Contraseña.Text.Trim() == textBox1.Text.Trim())
            {
                objEmpleado.clave = Contraseña.Text.Trim();
                if (CN_Empleado.InsertarEmpleado(objEmpleado))
                {
                    MessageBox.Show("Registro exitóso");
                }
                else
                {
                    MessageBox.Show("Error en el registro");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas deben coincidir");
            }
        }
    }
}
