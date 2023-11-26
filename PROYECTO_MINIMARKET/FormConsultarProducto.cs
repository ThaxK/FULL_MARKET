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
    public partial class FormConsultarProducto : Form
    {
        public FormConsultarProducto()
        {
            InitializeComponent();
        }

        private void FormConsultarProducto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=CN_Producto.ConsultarProductoPorNombre(textBoxNombre.Text.Trim());
            dataGridView1.DataSource = dt;

        }

        private void FormConsultarProducto_Activated(object sender, EventArgs e)
        {
            groupBoxActualizar.Visible = false;

            DataTable dt = new DataTable();
            dt = CN_Producto.ConsultarProducto();
            dataGridView1.DataSource=dt;
            DataGridViewButtonColumn columna = new DataGridViewButtonColumn();
            columna.Text = "Actualizar";
            columna.Name = "Actualizar";
            dataGridView1.Columns.Add(columna);


            //Llenar combobox
            DataTable dt2 = new DataTable();
            dt2 = CN_Categoria.ConsultarCategoria();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt2.Rows[i][1].ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                groupBoxActualizar.Visible = true;

                textBoxCodigo.Text = dataGridView1[0, e.RowIndex].ToString();
                textBoxNombre.Text = dataGridView1[1,e.RowIndex].ToString();
                textBoxPrecio.Text= dataGridView1[2,e.RowIndex].ToString();
                richTextBoxDescripcion.Text = dataGridView1[3, e.RowIndex].ToString();
                textBoxCantidad.Text = dataGridView1[4, e.RowIndex].ToString();
                for(int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if(dataGridView1[5, e.RowIndex].ToString() == comboBox1.Items[i].ToString())
                    {
                        comboBox1.SelectedIndex=i;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
