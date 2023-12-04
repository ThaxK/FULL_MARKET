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
    public partial class FromRegistrarCliente : Form
    {
        public FromRegistrarCliente()
        {
            InitializeComponent();
        }
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epRegistrarCliente.Clear();

            if (!val.OnceDigitos(NoDocumentoCliente.Text))
            {
                epRegistrarCliente.SetError(NoDocumentoCliente, "Error en el documento");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(NombreCliente.Text))
            {
                epRegistrarCliente.SetError(NombreCliente, "Error en el nombre");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(ApellidoCliente.Text))
            {
                epRegistrarCliente.SetError(ApellidoCliente, "Error en el apellido");
                bandera = 0;
            }
            if (!val.CorreoElectronico(CorreoCliente.Text))
            {
                epRegistrarCliente.SetError(CorreoCliente, "Error en el correo");
                bandera = 0;
            }
            if (!val.Direccion(DireccionCliente.Text))
            {
                epRegistrarCliente.SetError(DireccionCliente, "Error en la direccion");
                bandera = 0;
            }
            if (!val.Telefono(TelefonoCliente.Text))
            {
                epRegistrarCliente.SetError(TelefonoCliente, "Error en el telefono");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FromRegistrarCliente_Load(object sender, EventArgs e)
        {
            CBoxTipoDocuCliente.SelectedIndex = 0;
        }

        private void btnRegsitrarCliente_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                Cliente cliente = new Cliente();
                cliente.nombre = NombreCliente.Text.Trim();
                cliente.apellido = ApellidoCliente.Text.Trim();
                cliente.direccion = DireccionCliente.Text.Trim();
                cliente.telefono = TelefonoCliente.Text.Trim();
                cliente.correo = CorreoCliente.Text.Trim();
                cliente.documento = NoDocumentoCliente.Text.Trim();
                if (CBoxTipoDocuCliente.SelectedIndex == 0)
                {
                    cliente.tipoDocumento = "CC";
                }
                else if (CBoxTipoDocuCliente.SelectedIndex == 1)
                {
                    cliente.tipoDocumento = "CE";
                }
                else if (CBoxTipoDocuCliente.SelectedIndex == 2)
                {
                    cliente.tipoDocumento = "PAS";
                }
                else if (CBoxTipoDocuCliente.SelectedIndex == 3)
                {
                    cliente.tipoDocumento = "PEP";
                }
                if (CN_Cliente.RegistarCliente(cliente))
                {
                    MessageBox.Show("Registro Exitoso");
                }
                else
                {
                    MessageBox.Show("Registro Erroneo");
                }
            }
        }
    }
}
