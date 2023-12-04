using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_capa_entidades;
using CL_capaNegocios;

namespace PROYECTO_MINIMARKET
{
    public partial class FromConsultarProveedores : Form
    {
        public FromConsultarProveedores()
        {
            InitializeComponent();
        }
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epAcProveedor.Clear();
            if (!val.Nit(txtNit.Text))
            {
                epAcProveedor.SetError(txtNit, "Error en el NIT");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(txtRazonSocial.Text))
            {
                epAcProveedor.SetError(txtRazonSocial, "Error en la razon social");
                bandera = 0;
            }
            if (!val.Direccion(txtDireccion.Text))
            {
                epAcProveedor.SetError(txtDireccion, "Error en la direccion");
                bandera = 0;
            }
            if (!val.Telefono(txtTelefono.Text))
            {
                epAcProveedor.SetError(txtTelefono, "Error en el telefono");
                bandera = 0;
            }
            if (!val.CorreoElectronico(txtCorreo.Text))
            {
                epAcProveedor.SetError(txtCorreo, "Error en el correo");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(txtCiudad.Text))
            {
                epAcProveedor.SetError(txtCiudad, "Error en la ciudad");
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

            private void FromConsultarProveedores_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            DataTable dt = new DataTable();

            dt = CN_Proveedores.ConsultarProveedores();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            DataGridViewButtonColumn botonActualizar= new DataGridViewButtonColumn();
            botonActualizar.Text = "Actualizar";
            botonActualizar.Name = "Actualizar";
            dataGridView1.Columns.Add(botonActualizar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                dataGridView1.Visible= false;
                groupBox1.Visible = true;
                txtNit.Text = dataGridView1[ 2,e.RowIndex].Value.ToString();
                txtRazonSocial.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                txtDireccion.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                txtTelefono.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                txtCorreo.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                txtCiudad.Text = dataGridView1[7, e.RowIndex].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)


        {

            if (validarFormulario())
            {
                if (txtCiudad.Text == string.Empty||txtRazonSocial.Text==string.Empty||txtCorreo.Text==string.Empty||txtTelefono.Text==string.Empty||txtDireccion.Text==string.Empty)
                {
                    MessageBox.Show("Los campos deben estar llenos");
                }
                else
                {
                    Proveedor objProveedor = new Proveedor();
                    objProveedor.idProveedor = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    objProveedor.nit = txtNit.Text.Trim();
                    objProveedor.razonSocial = txtRazonSocial.Text.Trim();
                    objProveedor.telefono = txtTelefono.Text.Trim();
                    objProveedor.ciudad = txtCiudad.Text.Trim();
                    objProveedor.direccion = txtDireccion.Text.Trim();
                    objProveedor.correo = txtCorreo.Text.Trim();
                    if (CN_Proveedores.ActualizarProveedores(objProveedor))
                    {
                        MessageBox.Show("Se actualizaron los datos correctamente");
                        dataGridView1.Visible=true;
                        groupBox1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar los datos");
                    }
                }
            }

        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CN_Proveedores.ConsultarProveedores();
            dataGridView1.DataSource = dt;
        }
    }
}
