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
        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();
            int bandera = 0;
            epCategoriaR.Clear();
            if (!val.CincuentaCaracteres(textBoxNombre.Text))
            {
                epCategoriaR.SetError(textBoxNombre, "Error en el Nombre");
                bandera = 0;
            }
            if (!val.CincuentaCaracteres(textBoxDescripcion.Text))
            {
                epCategoriaR.SetError(textBoxDescripcion, "Error en la descripcion");
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

            private void button1_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                Categoria categoria = new Categoria();

                categoria.nombre = textBoxNombre.Text.Trim();
                categoria.descripcion = textBoxDescripcion.Text.Trim();

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

        private void FromRegistrarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
