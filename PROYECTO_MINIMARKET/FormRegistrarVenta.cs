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

namespace PROYECTO_MINIMARKET
{
    public partial class FormRegistrarVenta : Form
    {
        int posicionDatagridview;
        DataTable CarritoCompras = new DataTable();

        public FormRegistrarVenta()
        {
            InitializeComponent();
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            //Crear carrito de compras
            DataColumn columna1=new DataColumn("Producto");
            DataColumn columna2=new DataColumn("Precio Unidad");
            DataColumn columna3=new DataColumn("Cantidad");
            DataColumn columna4=new DataColumn("Subtotal");
            CarritoCompras.Columns.Add(columna1);
            CarritoCompras.Columns.Add(columna2);
            CarritoCompras.Columns.Add(columna3);
            CarritoCompras.Columns.Add(columna4);
            dataGridView2.DataSource = CarritoCompras;
            DataGridViewButtonColumn botonEliminar = new DataGridViewButtonColumn();
            botonEliminar.Name = "Eliminar";
            botonEliminar.Text = "Eliminar";

            //Poner invisible el carrito de compras y la ventana de compra
            groupBox5.Visible = false;
            groupBox4.Visible = false;

            //Cargar comboBox de categoria
            DataTable dt = new DataTable();
            dt = CN_Categoria.ConsultarCategoria();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ComboCategoria.Items.Add(dt.Rows[i][1].ToString());
            }
            ComboCategoria.SelectedIndex = 0;

            //Cargar datagridview con productos
            DataTable dt2 = new DataTable();
            dt2 = CN_Producto.ConsultarProducto();
            dataGridView1.DataSource= dt2;

            DataGridViewButtonColumn botonComprar = new DataGridViewButtonColumn();
            botonComprar.Text = "Comprar";
            botonComprar.Name = "Comprar";
            dataGridView1.Columns.Add(botonComprar);

            //Poner invisibles columnas
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CN_Producto.ConsultarPorCategoria(int.Parse(ComboCategoria.SelectedIndex.ToString())+1);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CN_Producto.ConsultarPorNombre(textBoxNombre.Text);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Comprar")
            {
                posicionDatagridview = e.RowIndex;
                groupBox4.Visible = true;
                labelNombreProducto.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                labelPrecioProducto.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBoxCantidad.Text = "1";
            }
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxCantidad.Text) > 1)
            {
                textBoxCantidad.Text=(int.Parse(textBoxCantidad.Text) - 1)+"";
            }
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxCantidad.Text.Trim()) < int.Parse(dataGridView1[6, posicionDatagridview].Value.ToString()))
            {
                textBoxCantidad.Text = (int.Parse(textBoxCantidad.Text) + 1)+"";
            }
        }

        private void buttonAgregarCarrito_Click(object sender, EventArgs e)
        {
            DataRow fila = CarritoCompras.NewRow();
            fila[0] = labelNombreProducto.Text;
            fila[1] = labelPrecioProducto.Text;
            fila[2] = textBoxCantidad.Text;
            fila[3] = int.Parse(labelPrecioProducto.Text) * int.Parse(textBoxCantidad.Text);
            CarritoCompras.Rows.Add(fila);
            dataGridView2.DataSource = CarritoCompras;
            groupBox4.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox1.Visible = false;
            groupBox4.Visible = false;

        }

        private void buttonSalirCarritoCompras_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox1.Visible = true;
            groupBox4.Visible = false;
        }
    }
}
