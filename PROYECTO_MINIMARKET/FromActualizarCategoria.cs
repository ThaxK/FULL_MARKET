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
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();

            int bandera = 1;

            epActualizarCategoria.Clear();

            if (!val.CincuentaCaracteres(txtNombreCategoriaAc.Text))
            {
                epActualizarCategoria.SetError(txtNombreCategoriaAc, "Error en el nombre");
                bandera = 0;
            }if (!val.CincuentaCaracteres(rtxtDescripcionCategoriaAc.Text))
            {
                epActualizarCategoria.SetError(rtxtDescripcionCategoriaAc, "Error en el nombre");
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
            if (dataGridView1.Columns[e.ColumnIndex].Name=="Actualizar")
            {
                dataGridView1.Visible = false;
                groupBox2.Visible = true;

                txtIdCategoriaAc.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtNombreCategoriaAc.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                rtxtDescripcionCategoriaAc.Text = dataGridView1[3,e.RowIndex].Value.ToString();
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
            if (validarFormulario())
            {
                Categoria objCategoria = new Categoria();
                objCategoria.id = int.Parse(txtIdCategoriaAc.Text.ToString());
                objCategoria.nombre = txtNombreCategoriaAc.Text.ToString();
                objCategoria.descripcion = rtxtDescripcionCategoriaAc.Text.ToString();

                if (CN_Categoria.ActualizarCategoria(objCategoria))
                {
                    MessageBox.Show("La categoria se actualizó correctamente");
                }
                else
                {
                    MessageBox.Show("Error en la actualización");
                }

                dataGridView1.Visible = true;
                groupBox2.Visible = false;
            }
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
