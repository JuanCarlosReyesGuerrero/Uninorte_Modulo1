using MySql.Data.MySqlClient;

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



            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("unidad", "Unidad");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("precio", "Precio");
            dataGridView1.Columns.Add("total", "Total");
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
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
            Ventas.operation_type = 2;
            Ventas ow = new Ventas();
            ow.ShowDialog();
        }

        private void abastecimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.operation_type = 1;
            Ventas ow = new Ventas();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                dtgPrincipal.Rows.Clear();
                try
                {
                    Connection c = new Connection();
                    MySqlCommand cmd = c.con.CreateCommand();
                    cmd.CommandText = "select * from product where name like \"%" + txtProducto.Text + "%\"";
                    c.con.Open();
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        dtgPrincipal.Rows.Add(r.GetString("id"), r.GetString("name"), r.GetString("unit"), "", r.GetInt32("price_out"));
                    }
                }
                catch (MySqlException me)
                {
                    MessageBox.Show(me.Message);
                }
            }
            else
            {

                dtgPrincipal.Rows.Clear();
            }
        }

        private void btnVerVenta_Click(object sender, EventArgs e)
        {
            //SellDialog sd = new SellDialog();
            //sd.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text) || txtCantidad.Text == "0")
            {
                MessageBox.Show("Falta la cantidad");
            }
            else
            {
                int totalFilas = 1;
                int lastRowsIndex = dataGridView1.Rows.Count - 1;

                foreach (DataGridViewRow row in dtgPrincipal.Rows)
                {
                    if (totalFilas < dtgPrincipal.Rows.Count)
                    {
                        if (dataGridView1.Rows.Count == 1)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[row.Index].Cells["id"].Value = row.Cells[0].Value;
                            dataGridView1.Rows[row.Index].Cells["nombre"].Value = row.Cells[1].Value;
                            dataGridView1.Rows[row.Index].Cells["unidad"].Value = row.Cells[2].Value;
                            dataGridView1.Rows[row.Index].Cells["cantidad"].Value = txtCantidad.Text;
                            dataGridView1.Rows[row.Index].Cells["precio"].Value = row.Cells[4].Value;
                            dataGridView1.Rows[row.Index].Cells["total"].Value = Convert.ToInt32(row.Cells[4].Value) * Convert.ToInt32(txtCantidad.Text);
                        }
                        else
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.CurrentCell = dataGridView1.Rows[lastRowsIndex].Cells[0];
                            dataGridView1.Rows[lastRowsIndex].Cells["id"].Value = row.Cells[0].Value;
                            dataGridView1.Rows[lastRowsIndex].Cells["nombre"].Value = row.Cells[1].Value;
                            dataGridView1.Rows[lastRowsIndex].Cells["unidad"].Value = row.Cells[2].Value;
                            dataGridView1.Rows[lastRowsIndex].Cells["cantidad"].Value = txtCantidad.Text;
                            dataGridView1.Rows[lastRowsIndex].Cells["precio"].Value = row.Cells[4].Value;
                            dataGridView1.Rows[lastRowsIndex].Cells["total"].Value = Convert.ToInt32(row.Cells[4].Value) * Convert.ToInt32(txtCantidad.Text);
                        }
                    }

                    totalFilas++;
                }

                txtTotalCompra.Text = "0";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    txtTotalCompra.Text = (Convert.ToInt32(txtTotalCompra.Text) + Convert.ToInt32(dataGridView1.Rows[row.Index].Cells["total"].Value)).ToString();
                }

                txtCantidad.Text = "0";
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();

            int totalFilas = 1;

            try
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if (totalFilas < dataGridView1.Rows.Count)
                    {
                        int Codigo = Convert.ToInt32(dataGridView1.Rows[row.Index].Cells["id"].Value);
                        string Nombre = dataGridView1.Rows[row.Index].Cells["nombre"].Value.ToString();
                        string Unidad = dataGridView1.Rows[row.Index].Cells["unidad"].Value.ToString();
                        int Cantidad = Convert.ToInt32(dataGridView1.Rows[row.Index].Cells["cantidad"].Value);
                        decimal Precio = Convert.ToDecimal(dataGridView1.Rows[row.Index].Cells["precio"].Value);
                        decimal Total = Convert.ToDecimal(dataGridView1.Rows[row.Index].Cells["total"].Value);
                        int Estado = 1;

                        c.execute("INSERT INTO inventario.venta (code, name, unit, cant, price, total, status, created_at, is_active) VALUES(\"" + Codigo + "\",\"" + Nombre + "\",\"" + Unidad + "\",\"" + Cantidad + "\",\"" + Precio + "\",\"" + Total + "\",\"" + Estado + "\",\"" + DateTime.Now + "\",\"" + 1 + "\")");
                    }

                    totalFilas++;
                }

                MessageBox.Show("Pedido agregado exitosamente!");
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPedidos lp = new ListaPedidos();
            lp.ShowDialog();
        }
    }
}