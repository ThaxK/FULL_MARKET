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
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epREmpleado.Clear();

            if (!val.OnceDigitos(NoDocumento.Text))
            {
                epREmpleado.SetError(NoDocumento, "Error en el documento");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(Nombre.Text))
            {
                epREmpleado.SetError(Nombre, "Error en el Nombre");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(Apellido.Text))
            {
                epREmpleado.SetError(Apellido, "Error en el Apellido");
                bandera = 0;
            }
            if (!val.CorreoElectronico(Correo.Text))
            {
                epREmpleado.SetError(Correo, "Error en el Apellido");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(Contraseña.Text))
            {
                epREmpleado.SetError(Contraseña, "Error en la contraseña");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(ConfirmarContrasena.Text))
            {
                epREmpleado.SetError(ConfirmarContrasena, "Error en la confirmacion");
                bandera = 0;
            }
            if (!val.Telefono(Telefono.Text))
            {
                epREmpleado.SetError(Telefono, "Error en la telefono");
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
            if (validarFormulario())
            {
                int ayuda = CBoxTipoDocumento.SelectedIndex;
                Empleado objEmpleado = new Empleado();
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
                if (Contraseña.Text.Trim() == ConfirmarContrasena.Text.Trim())
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

        private void FromRegistrarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
