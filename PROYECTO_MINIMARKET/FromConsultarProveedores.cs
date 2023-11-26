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
                textBox4.Text = dataGridView1[ 2,e.RowIndex].Value.ToString();
                text_razonSocial.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                text_direccion.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                text_telefono.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                text_correo.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                text_ciudad.Text = dataGridView1[7, e.RowIndex].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (text_ciudad.Text == string.Empty||text_razonSocial.Text==string.Empty||text_correo.Text==string.Empty||text_telefono.Text==string.Empty||text_direccion.Text==string.Empty)
            {
                MessageBox.Show("Los campos deben estar llenos");
            }
            else
            {
                Proveedor objProveedor = new Proveedor();
                objProveedor.idProveedor = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                objProveedor.nit = textBox4.Text.Trim();
                objProveedor.razonSocial = text_razonSocial.Text.Trim();
                objProveedor.telefono = text_telefono.Text.Trim();
                objProveedor.ciudad = text_ciudad.Text.Trim();
                objProveedor.direccion = text_direccion.Text.Trim();
                objProveedor.correo = text_correo.Text.Trim();
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

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CN_Proveedores.ConsultarProveedores();
            dataGridView1.DataSource = dt;
        }
    }
}
