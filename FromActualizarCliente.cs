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
        public FromActualizarCliente()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                dataGridView1.Visible = false;
                
                NoDocumentoCli.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                NombreCli.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                ApellidoCli.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                CorreoCli.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                DireccionCli.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                TelefonoCli.Text = dataGridView1[8, e.RowIndex].Value.ToString();
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
            if (string.IsNullOrEmpty(NombreCli.Text) && string.IsNullOrEmpty(ApellidoCli.Text) && string.IsNullOrEmpty(CorreoCli.Text) && string.IsNullOrEmpty(TelefonoCli.Text) && string.IsNullOrEmpty(DireccionCli.Text))
            {
                MessageBox.Show("Los campos deben estar llenos");
            }
            else
            {

                Cliente objCliente = new Cliente();
                objCliente.documento = NoDocumentoCli.Text;
                objCliente.nombre = NombreCli.Text;
                objCliente.apellido = ApellidoCli.Text;
                objCliente.correo = CorreoCli.Text;
                objCliente.telefono = TelefonoCli.Text;
                objCliente.direccion = DireccionCli.Text;

                    if (CN_Cliente.ActualizarCliente(objCliente))
                    {
                        MessageBox.Show("ACTUALIZACIÓN EXITOSA");
                    }
                    else
                    {
                        MessageBox.Show("ERROR EN LA ACTUALIZACIÓN");
                    }
                dataGridView1.Visible = true;
            }
                
            }

        
    }
    }

