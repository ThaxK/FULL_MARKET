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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PROYECTO_MINIMARKET
{
    public partial class FromActualizarCliente : Form
    {
        int idCliente;
        public FromActualizarCliente()
        {
            InitializeComponent();
        }
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epAcCliente.Clear();

            if (!val.OnceDigitos(txtDocumentoClienteAc.Text))
            {
                epAcCliente.SetError(txtDocumentoClienteAc, "Error en el documento");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(txtNombreClienteAc.Text))
            {
                epAcCliente.SetError(txtNombreClienteAc, "Error en el nombre");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(txtApellidoClienteAc.Text))
            {
                epAcCliente.SetError(txtApellidoClienteAc, "Error en el apellido");
                bandera = 0;
            }
            if (!val.CorreoElectronico(txtCorreoClienteAc.Text))
            {
                epAcCliente.SetError(txtCorreoClienteAc, "Error en el correo");
                bandera = 0;
            }
            if (!val.Direccion(txtDireccion.Text))
            {
                epAcCliente.SetError(txtDireccion, "Error en la direccion");
                bandera = 0;
            }
            if (!val.Telefono(txtTelefonoClienteAc.Text))
            {
                epAcCliente.SetError(txtTelefonoClienteAc, "Error en el telefono");
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                dataGridView1.Visible = false;

                idCliente = int.Parse(dataGridView1[1, e.RowIndex].Value.ToString());
                txtDocumentoClienteAc.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txtNombreClienteAc.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                txtApellidoClienteAc.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                txtCorreoClienteAc.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                txtDireccion.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                txtTelefonoClienteAc.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                switch (dataGridView1[3, e.RowIndex].Value.ToString())
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
            dt = CN_Cliente.ConsultarCliente();
            dataGridView1.DataSource = dt;
        }
        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromActualizarCliente_Load(object sender, EventArgs e)
        {

           
            DataTable dt2 = new DataTable();
            dt2 = CN_Cliente.ConsultarCliente();
            dataGridView1.DataSource = dt2;

            DataGridViewButtonColumn botonActualizar = new DataGridViewButtonColumn();
            botonActualizar.Text = "Actualizar";
            botonActualizar.Name = "Actualizar";
            dataGridView1.Columns.Add(botonActualizar);
        }

        private void btnRegsitrarCliente_Click(object sender, EventArgs e)
        {

            if (validarFormulario()){

                if (string.IsNullOrEmpty(txtNombreClienteAc.Text) && string.IsNullOrEmpty(txtApellidoClienteAc.Text) && string.IsNullOrEmpty(txtCorreoClienteAc.Text) && string.IsNullOrEmpty(txtTelefonoClienteAc.Text) && string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Los campos deben estar llenos");
                }
                else
                {

                    Cliente objCliente = new Cliente();
                    objCliente.id = idCliente;
                    objCliente.documento = txtDocumentoClienteAc.Text;
                    objCliente.nombre = txtNombreClienteAc.Text;
                    objCliente.apellido = txtApellidoClienteAc.Text;
                    objCliente.correo = txtCorreoClienteAc.Text;
                    objCliente.telefono = txtTelefonoClienteAc.Text;
                    objCliente.direccion = txtDireccion.Text;

                    if (CN_Cliente.ActualizarCliente(objCliente))
                    {
                        MessageBox.Show("ACTUALIZACIÓN EXITOSA");
                    }
                    else
                    {
                        MessageBox.Show("ERROR EN LA ACTUALIZACIÓN");
                    }
                    DataTable dt = new DataTable();
                    dt = CN_Cliente.ConsultarCliente();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Visible = true;
                }

            }

        }
    }
    }

