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
            NoDocumento.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                
                dataGridView1.Visible = false;

                id=int.Parse(dataGridView1[1, e.RowIndex].Value.ToString());
                NoDocumento.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                Nombre.Text= dataGridView1[4, e.RowIndex].Value.ToString();
                Apellido.Text= dataGridView1[5, e.RowIndex].Value.ToString();
                Correo.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                Telefono.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                Contraseña.Text= dataGridView1[9, e.RowIndex].Value.ToString();
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
            if(string.IsNullOrEmpty(Nombre.Text)&& string.IsNullOrEmpty(Apellido.Text)&& string.IsNullOrEmpty(Correo.Text)&& string.IsNullOrEmpty(Telefono.Text)&& string.IsNullOrEmpty(Contraseña.Text)&& string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Los campos deben estar llenos");
            }
            else
            {
                if (Contraseña.Text == textBox1.Text)
                {
                    Empleado objEmpleado = new Empleado();
                    objEmpleado.identificacion = NoDocumento.Text;
                    objEmpleado.nombres = Nombre.Text;
                    objEmpleado.apellidos = Apellido.Text;
                    objEmpleado.correo = Correo.Text;
                    objEmpleado.clave = Contraseña.Text;
                    objEmpleado.telefono = Telefono.Text;
                    objEmpleado.idEmpleado = id;

                    if (CN_Empleado.ActualizarEmpleado(objEmpleado))
                    {
                        MessageBox.Show("Actualización exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Error en la actualización");
                    }

                    textBox1.Text = "";
                    dataGridView1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben coincidir");
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            
        }
    }
}
