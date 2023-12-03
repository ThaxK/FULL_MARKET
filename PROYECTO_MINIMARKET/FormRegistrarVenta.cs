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

namespace PROYECTO_MINIMARKET
{
    public partial class FormRegistrarVenta : Form
    {
        int posicionDatagridview, idProducto,documentClient;
        DataTable CarritoCompras = new DataTable();

        public FormRegistrarVenta()
        {
            InitializeComponent();
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            //Crear carrito de compras
            DataColumn columna0 = new DataColumn("idProducto");
            DataColumn columna1=new DataColumn("Producto");
            DataColumn columna2=new DataColumn("Precio Unidad");
            DataColumn columna3=new DataColumn("Cantidad");
            DataColumn columna4=new DataColumn("Subtotal");
            CarritoCompras.Columns.Add(columna0);
            CarritoCompras.Columns.Add(columna1);
            CarritoCompras.Columns.Add(columna2);
            CarritoCompras.Columns.Add(columna3);
            CarritoCompras.Columns.Add(columna4);
            dataGridView2.DataSource = CarritoCompras;
            DataGridViewButtonColumn botonEliminar = new DataGridViewButtonColumn();
            botonEliminar.Name = "Eliminar";
            botonEliminar.Text = "Eliminar";
            dataGridView2.Columns.Add(botonEliminar);
            dataGridView2.Columns[0].Visible = false;

            DataGridViewButtonColumn botonSeleccionar = new DataGridViewButtonColumn();
            botonSeleccionar.Text = "Seleccionar";
            botonSeleccionar.Name = "Seleccionar";
            dataGridView3.Columns.Add(botonSeleccionar);


            //Poner invisible el carrito de compras y la ventana de compra
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;

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

            //label en numeros enteros
            labelTotal.Text = "0";

            //Crear columna de seleccionar a datagridview3
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
                idProducto = int.Parse(dataGridView1[1, e.RowIndex].Value.ToString());
                
                labelNombreProducto.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                labelPrecioProducto.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBoxCantidad.Text = "1";

                groupBox4.Visible = true;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
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
            fila[0] = idProducto;
            fila[1] = labelNombreProducto.Text;
            fila[2] = labelPrecioProducto.Text;
            fila[3] = textBoxCantidad.Text;
            fila[4] = int.Parse(labelPrecioProducto.Text) * int.Parse(textBoxCantidad.Text);
            CarritoCompras.Rows.Add(fila);
            dataGridView2.DataSource = CarritoCompras;
            groupBox4.Visible = false;

            //Generar total
            int subtotal = (int.Parse(labelPrecioProducto.Text) * int.Parse(textBoxCantidad.Text))+int.Parse(labelTotal.Text);
            labelTotal.Text = subtotal+"";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                CarritoCompras.Rows[e.RowIndex].Delete();
                labelTotal.Text= (int.Parse(labelTotal.Text) - int.Parse(dataGridView2[5, e.RowIndex].Value.ToString()))+"";
                dataGridView2.DataSource = CarritoCompras;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox1.Visible = false;
            groupBox4.Visible = false;

        }

        private void buttonConfirmarVenta_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = false;
            groupBox5.Visible = false;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CN_Cliente.ConsultarClientePorDocumento(textBoxDocumento.Text);
            dataGridView3.DataSource = dt;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                documentClient = int.Parse(dataGridView3[1,e.RowIndex].Value.ToString());
                label7.Text = dataGridView3[0, e.RowIndex].Value.ToString();
                groupBox6.Visible = false;
                groupBox7.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Consultar el ultimo numero de venta
            DataTable dt= new DataTable();
            dt = CN_Venta.ConsultarVenta();


            Venta objVenta = new Venta();
            objVenta.numeroVenta = dt.Rows.Count+1;
            objVenta.fechaVenta = DateTime.Now;
            objVenta.iva = 19*int.Parse(labelTotal.Text)/100;
            objVenta.total = int.Parse(labelTotal.Text);
            objVenta.idEmpleado = 1;
            objVenta.identificacionCliente = documentClient;
            if (CN_Venta.RegistrarVenta(objVenta))
            {
                for (int i = 0; i < CarritoCompras.Rows.Count; i++)
                {
                    DetalleVenta objDetalleVenta = new DetalleVenta();
                    objDetalleVenta.numeroVenta = dt.Rows.Count+1;
                    objDetalleVenta.idProducto = int.Parse(CarritoCompras.Rows[i][0].ToString());
                    objDetalleVenta.subtotal = int.Parse(CarritoCompras.Rows[i][4].ToString());
                    CN_DetalleVenta.RegistrarDetalleVenta(objDetalleVenta);
                }

                MessageBox.Show("Venta exitosa");
            }
            else
            {
                MessageBox.Show("Error en la venta");
            }
            
            groupBox7.Visible = false;
            groupBox1.Visible = true;

            dataGridView2.DataSource = null;
            dataGridView3.DataSource=null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = false;
            groupBox6.Visible = true;
        }

        private void buttonSalirCarritoCompras_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox1.Visible = true;
            groupBox4.Visible = false;
        }
    }
}
