using CL_capa_entidades;
using CL_capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_MINIMARKET
{
    public partial class FromConsultarProducto : Form
    {
        int id;
        public FromConsultarProducto()
        {
            InitializeComponent();
        }
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epProductoAc.Clear();

            if (!val.SeisDigitos(txtCodigoAc.Text))
            {
                epProductoAc.SetError(txtCodigoAc, "Error en el codigo");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(txtNombreProductoAc.Text))
            {
                epProductoAc.SetError(txtNombreProductoAc, "Error en el nombre");
                bandera = 0;
            }
            if (!val.OnceDigitos(txtPrecioAc.Text))
            {
                epProductoAc.SetError(txtPrecioAc, "Error en el precio");
                bandera = 0;
            }
            if (!val.DoscientosCaracteres(txtDescripcionAc.Text))
            {
                epProductoAc.SetError(txtDescripcionAc, "Error en la descripcion");
                bandera = 0;
            }
            if (!val.OnceDigitos(txtCantidadAc.Text))
            {
                epProductoAc.SetError(txtCantidadAc, "Error en la cantidad");
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

            private void FromConsultarProducto_Load(object sender, EventArgs e)
        {
            

            DataTable dtc=new DataTable();
            dtc = CN_Categoria.ConsultarCategoria();
            for(int i = 0; i < dtc.Rows.Count; i++)
            {
                comboBox1.Items.Add(dtc.Rows[i][1].ToString());
            }
            comboBox1.SelectedIndex = 0;

            DataTable dt = new DataTable();
            dt = CN_Producto.ConsultarProducto();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            DataGridViewButtonColumn botonActualizar = new DataGridViewButtonColumn();
            botonActualizar.Text = "Actualizar";
            botonActualizar.Name = "Actualizar";
            dataGridView1.Columns.Add(botonActualizar);
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CN_Producto.ConsultarProducto();
            dataGridView1.DataSource = dt;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                dataGridView1.Visible = false;
                groupBox1.Visible = true;
                id = int.Parse(dataGridView1[1, e.RowIndex].Value.ToString());
                txtCodigoAc.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txtNombreProductoAc.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                txtPrecioAc.Text = dataGridView1[4, e.RowIndex].Value.ToString()+ dataGridView1[6, e.RowIndex].Value.ToString();
                txtDescripcionAc.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                txtCantidadAc.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == dataGridView1[7, e.RowIndex].Value.ToString())
                    {
                        comboBox1.SelectedIndex = i;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                Producto producto = new Producto();
                producto.idProducto = id;
                producto.codigo = txtCodigoAc.Text.ToString().Trim();
                producto.nombre = txtNombreProductoAc.Text.ToString().Trim();
                producto.descripcion = txtDescripcionAc.Text.ToString().Trim();
                producto.stock = txtCantidadAc.Text.ToString().Trim();
                producto.precio = txtPrecioAc.Text.ToString().Trim();
                producto.idCategoria = comboBox1.SelectedIndex + 1;

                if (CN_Producto.ActualizarProducto(producto))
                {
                    MessageBox.Show("Actualización exitosa");
                }
                else
                {
                    MessageBox.Show("Error en la actualización");
                }

                dataGridView1.Visible = true;
            }
        }
    }
}
