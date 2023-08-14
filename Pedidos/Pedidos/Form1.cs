using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace Pedidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dtgPrincipal.Columns.Add("id", "Id");
            dtgPrincipal.Columns.Add("nombre", "Nombre");
            dtgPrincipal.Columns.Add("unidad", "Unidad");
            dtgPrincipal.Columns.Add("disponible", "Disponible");
            dtgPrincipal.Columns.Add("precio", "Precio");
            dtgPrincipal.Columns[0].Width = 50;
            dtgPrincipal.Columns[1].Width = 400;
            dtgPrincipal.Columns[2].Width = 100;
            dtgPrincipal.Columns[3].Width = 100;
            dtgPrincipal.Columns[4].Width = 100;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsWindow pw = new ProductsWindow();
            pw.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newProduct np = new newProduct();
            np.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationWindow.operation_type = 2;
            OperationWindow ow = new OperationWindow();
            ow.ShowDialog();
        }

        private void abastecimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationWindow.operation_type = 1;
            OperationWindow ow = new OperationWindow();
            ow.ShowDialog();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.ShowDialog();
        }

        private void abastecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abastecer ip = new Abastecer();
            ip.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }
    }
}