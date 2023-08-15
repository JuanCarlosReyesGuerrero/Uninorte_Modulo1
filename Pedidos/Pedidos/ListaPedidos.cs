using MySql.Data.MySqlClient;

namespace Pedidos
{
    public partial class ListaPedidos : Form
    {
        public ListaPedidos()
        {
            InitializeComponent();

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

        private void ListaPedidos_Load(object sender, EventArgs e)
        {
            ObtenerGrida();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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

                        c.execute("UPDATE inventario.venta SET status = 0 WHERE id = " + Codigo  + "");                        
                    }

                    totalFilas++;
                }

                MessageBox.Show("Pedido confirmado exitosamente!");

                ObtenerGrida();
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
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
                        int Estado = 2;

                        c.execute("UPDATE inventario.venta SET status = 2 WHERE id = " + Codigo + "");
                    }

                    totalFilas++;
                }

                MessageBox.Show("Pedido rechazado exitosamente!");

                ObtenerGrida();
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void ObtenerGrida()
        {
            dataGridView1.Rows.Clear();
            List<ListaPedidoObj> list = ListaPedidoObj.getAllPedidos();
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add(list[i].id, list[i].nombre, list[i].unidad, list[i].cantidad, list[i].precio, list[i].total);
            }

            txtTotal.Text = "0";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + Convert.ToInt32(dataGridView1.Rows[row.Index].Cells["total"].Value)).ToString();
            }
        }
    }
}
