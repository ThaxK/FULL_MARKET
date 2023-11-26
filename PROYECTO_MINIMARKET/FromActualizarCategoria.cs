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
    public partial class FromActualizarCategoria : Form
    {
        public FromActualizarCategoria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name=="Actualizar")
            {
                dataGridView1.Visible = false;
                groupBox2.Visible = true;

                textBox4.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBoxNombre.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                richTextBox1.Text = dataGridView1[3,e.RowIndex].Value.ToString();
            }
        }

        private void FromActualizarCategoria_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            DataTable dt = new DataTable();
            dt = CN_Categoria.ConsultarCategoria();
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn botonActualizar= new DataGridViewButtonColumn();
            botonActualizar.Text = "Actualizar";
            botonActualizar.Name = "Actualizar";
            dataGridView1.Columns.Add(botonActualizar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.id = int.Parse(textBox4.Text.ToString());
            objCategoria.nombre = textBoxNombre.Text.ToString();
            objCategoria.descripcion = richTextBox1.Text.ToString();

            if (CN_Categoria.ActualizarCategoria(objCategoria))
            {
                MessageBox.Show("Actualización exitosa");
            }
            else
            {
                MessageBox.Show("Error en la actualización");
            }

            dataGridView1.Visible = true;
            groupBox2.Visible = false;
        }

        private void FromActualizarCategoria_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            
            groupBox2.Visible = false;
            DataTable dt = new DataTable();
            dt = CN_Categoria.ConsultarCategoria();
            dataGridView1.DataSource = dt;
        }
    }
}
