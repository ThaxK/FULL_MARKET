using CL_capa_entidades;
using CL_capaNegocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MINIMARKET
{
    public partial class FromRegistrarProducto : Form
    {
        Regex regexNombre = new Regex("[a-zA-Záéíóú\\s]{5,25}$");
        Regex regexCantidad = new Regex("[0-9\\d]{1,10}$");
        Regex regexCodigo = new Regex("[0-9\\d]{1,10}$");
        Regex regexPrecio = new Regex("[0-9\\d]{1,10}$");
        Regex regexDescripcion = new Regex("[a-zA-Záéíóú\\s]{5,100}$");


        public FromRegistrarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                Producto producto = new Producto();
                producto.codigo = textBox1.Text.ToString().Trim();
                producto.nombre = textBox4.Text.ToString().Trim();
                producto.descripcion = richTextBox1.Text.ToString().Trim();
                producto.stock = text_razonSocial.Text.ToString().Trim();
                producto.precio = textBox2.Text.ToString().Trim();
                producto.idCategoria = comboBox1.SelectedIndex + 1;

                if (CN_Producto.InsertarProducto(producto))
                {
                    MessageBox.Show("Registro exitoso");
                }
                else
                {
                    MessageBox.Show("Fallo en el registro");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromRegistrarProducto_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CN_Categoria.ConsultarCategoria();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][1].ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();

            int bandera = 1;

            epRegistroProducto.Clear();

            if (!val.NombreApellidos(textBox4.Text)){

                epRegistroProducto.SetError(textBox4, "Error en el nombre");
                bandera = 0;
            }

            if (!val.Numeros(text_razonSocial.Text))
            {

                epRegistroProducto.SetError(text_razonSocial, "Error en la cantidad");
                bandera = 0;

            }

            if (!val.Numeros(textBox1.Text))
            {

                epRegistroProducto.SetError(textBox1, "Error en el codigo");
                bandera = 0;

            }

            if (!val.Numeros(textBox2.Text))
            {

                epRegistroProducto.SetError(textBox2, "Error en el precio");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FromRegistrarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
