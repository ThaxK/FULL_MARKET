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
        


        public FromRegistrarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                Producto producto = new Producto();
                producto.codigo = txtCodigoProductoR.Text.ToString().Trim();
                producto.nombre = txtNombreProductoR.Text.ToString().Trim();
                producto.descripcion = rtxtDescripcionProductoR.Text.ToString().Trim();
                producto.stock = txtCantidadProductoR.Text.ToString().Trim();
                producto.precio = txtPrecioProductoR.Text.ToString().Trim();
                producto.idCategoria = cbCategoriaProductoR.SelectedIndex + 1;

                if (CN_Producto.InsertarProducto(producto))
                {
                    MessageBox.Show("Producto registrado correctamente");
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
                cbCategoriaProductoR.Items.Add(dt.Rows[i][1].ToString());
            }
            cbCategoriaProductoR.SelectedIndex = 0;
        }

        public bool validarFormulario()
        {
            Validaciones val = new Validaciones();

            int bandera = 1;

            epRegistroProducto.Clear();

            if (!val.CincuentaCaracteres(txtNombreProductoR.Text))
            {
                epRegistroProducto.SetError(txtNombreProductoR, "Error en el nombre");
                bandera = 0;
            }
            if (!val.SeisDigitos(txtCodigoProductoR.Text))
            {
                epRegistroProducto.SetError(txtCodigoProductoR, "Error en el codigo");
                bandera = 0;
            }
            if (!val.OnceDigitos(txtCantidadProductoR.Text))
            {
                epRegistroProducto.SetError(txtCantidadProductoR, "Error en la cantidad ");
                bandera = 0;
            }
            if (!val.OnceDigitos(txtPrecioProductoR.Text))
            {
                epRegistroProducto.SetError(txtPrecioProductoR, "Error en el precio");
                bandera = 0;
            }if (!val.DoscientosCaracteres(rtxtDescripcionProductoR.Text))
            {
                epRegistroProducto.SetError(rtxtDescripcionProductoR, "Error en la descripcion");
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
