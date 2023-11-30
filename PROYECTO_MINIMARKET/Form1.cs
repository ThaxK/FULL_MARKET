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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fullMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FromActualizarFullMarket ObjFrm = new FromActualizarFullMarket();

            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromRegistrarCategoria ObjFrm = new FromRegistrarCategoria();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromConsultarProveedores ObjFrm = new FromConsultarProveedores();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FromRegistrarProveedor ObjFrm = new FromRegistrarProveedor();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FromRegistrarProducto ObjFrm = new FromRegistrarProducto();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromActualizarCategoria ObjFrm = new FromActualizarCategoria();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FromRegistrarCliente ObjFrm = new FromRegistrarCliente();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FromConsultarProducto ObjFrm = new FromConsultarProducto();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FromRegistrarEmpleado ObjFrm = new FromRegistrarEmpleado();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FromConsultarEmpleado ObjFrm = new FromConsultarEmpleado();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarVenta ObjFrm = new FormRegistrarVenta();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FromActualizarCliente ObjFrm = new FromActualizarCliente();
            ObjFrm.MdiParent = this;

            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }
    }
}
