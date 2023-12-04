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
    public partial class FromConsultarEmpleado : Form
    {
        private int id;
        public FromConsultarEmpleado()
        {
            InitializeComponent();
        }
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epEmpleadoAc.Clear();

            if (!val.OnceDigitos(txtDocumentoAc.Text))
            {
                epEmpleadoAc.SetError(txtDocumentoAc, "Error en el documento");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(txtNombreAc.Text))
            {
                epEmpleadoAc.SetError(txtNombreAc, "Error en el Nombre");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(txtApellidoAc.Text))
            {
                epEmpleadoAc.SetError(txtApellidoAc, "Error en el Apellido");
                bandera = 0;
            }
            if (!val.CorreoElectronico(txtCorreoAc.Text))
            {
                epEmpleadoAc.SetError(txtCorreoAc, "Error en el Apellido");
                bandera = 0;
            }if (!val.CincuentaCaracteres(txtContrasenaAc.Text))
            {
                epEmpleadoAc.SetError(txtContrasenaAc, "Error en la contraseña");
                bandera = 0;
            }if (!val.CincuentaCaracteres(txtConfirmarContrasenaAc.Text))
            {
                epEmpleadoAc.SetError(txtConfirmarContrasenaAc, "Error en la confirmacion");
                bandera = 0;
            }
            if (!val.Telefono(txtTelefonoAc.Text))
            {
                epEmpleadoAc.SetError(txtTelefonoAc, "Error en la telefono");
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

            private void FromConsultarEmpleado_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = CN_Empleado.ConsultarEmpleado();
            dataGridView1.DataSource = dt;
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.Text = "Actualizar";
            col.Name = "Actualizar";
            dataGridView1.Columns.Add(col);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            CBoxTipoDocumento.Enabled = false;
            txtDocumentoAc.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                
                dataGridView1.Visible = false;

                id=int.Parse(dataGridView1[1, e.RowIndex].Value.ToString());
                txtDocumentoAc.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txtNombreAc.Text= dataGridView1[4, e.RowIndex].Value.ToString();
                txtApellidoAc.Text= dataGridView1[5, e.RowIndex].Value.ToString();
                txtCorreoAc.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                txtTelefonoAc.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                txtContrasenaAc.Text= dataGridView1[9, e.RowIndex].Value.ToString();
                switch(dataGridView1[3, e.RowIndex].Value.ToString())
                {
                    case "CC":
                        CBoxTipoDocumento.SelectedIndex = 0;
                        break;
                    case "CE":
                        CBoxTipoDocumento.SelectedIndex = 1;
                        break;
                    case "PEP":
                        CBoxTipoDocumento.SelectedIndex = 2;
                        break;
                    case "PE":
                        CBoxTipoDocumento.SelectedIndex = 3;
                        break;
                }
            }
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CN_Empleado.ConsultarEmpleado();
            dataGridView1.DataSource = dt;
        }

        private void btnRegsitrarCliente_Click(object sender, EventArgs e)

        {

            if (validarFormulario())
            {
                if (string.IsNullOrEmpty(txtNombreAc.Text)&& string.IsNullOrEmpty(txtApellidoAc.Text)&& string.IsNullOrEmpty(txtCorreoAc.Text)&& string.IsNullOrEmpty(txtTelefonoAc.Text)&& string.IsNullOrEmpty(txtContrasenaAc.Text)&& string.IsNullOrEmpty(txtConfirmarContrasenaAc.Text))
                {
                    MessageBox.Show("Los campos deben estar llenos");
                }
                else
                {
                    if (txtContrasenaAc.Text == txtConfirmarContrasenaAc.Text)
                    {
                        Empleado objEmpleado = new Empleado();
                        objEmpleado.identificacion = txtDocumentoAc.Text;
                        objEmpleado.nombres = txtNombreAc.Text;
                        objEmpleado.apellidos = txtApellidoAc.Text;
                        objEmpleado.correo = txtCorreoAc.Text;
                        objEmpleado.clave = txtContrasenaAc.Text;
                        objEmpleado.telefono = txtTelefonoAc.Text;
                        objEmpleado.idEmpleado = id;

                        if (CN_Empleado.ActualizarEmpleado(objEmpleado))
                        {
                            MessageBox.Show("Actualización exitosa");
                        }
                        else
                        {
                            MessageBox.Show("Error en la actualización");
                        }

                        txtConfirmarContrasenaAc.Text = "";
                        dataGridView1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas deben coincidir");
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            
        }
    }
}
