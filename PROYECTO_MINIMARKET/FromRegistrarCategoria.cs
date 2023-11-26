using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_capaNegocios;

namespace PROYECTO_MINIMARKET
{
    public partial class FromRegistrarCategoria : Form
    {
        public FromRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            categoria.nombre = textBoxNombre.Text.Trim();
            categoria.descripcion = textBox4.Text.Trim();

            if (CN_Categoria.InsertarCategoria(categoria))
            {
                MessageBox.Show("Registro Exitoso");
            }
            else
            {
                MessageBox.Show("Registro Erroneo");
            }
        }
    }
}
