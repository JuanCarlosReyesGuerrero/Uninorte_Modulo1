using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pedidos
{
    public partial class Abastecer : Form
    {
        List<ProductObj> prods;
        List<PersonObj> provs;

        public Abastecer()
        {
            InitializeComponent();
            prods = ProductObj.getAll();
            provs = PersonObj.getAllByKindId(2);
            foreach (ProductObj p in prods) { cboProducto.Items.Add(p.name); }
            foreach (PersonObj p in provs) { cboProveedor.Items.Add(p.name + " " + p.lastname); }
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("unidad", "Unidad");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("precio", "Precio");
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();
            if (cboProveedor.SelectedIndex != -1)
            {
                c.execute("insert into sell (person_id,operation_type_id,created_at) value (" + provs[cboProveedor.SelectedIndex].id + ",1,NOW())");
            }
            else
            {
                c.execute("insert into sell (operation_type_id,created_at) value (1,NOW())");
            }
            long sell_id = c.insert_id;
            List<SellObj> sell = SellObj.re;
            for (int i = 0; i < sell.Count; i++)
            {
                c.execute("insert into operation (product_id,q,sell_id,operation_type_id,created_at) value (" + sell[i].product_id + "," + sell[i].q + "," + sell_id + ",1,NOW())");
            }
            dataGridView1.Rows.Clear();
            SellObj.sell.Clear();
            MessageBox.Show("Abastecimiento Aplicado Exitosamente");
            //            Dispose();
        }

        private void btnLisatr_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SellObj.re.Clear();
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un producto");
            }
            else if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debes introducir una cantidad");
            }
            else
            {
                int index = cboProducto.SelectedIndex;
                dataGridView1.Rows.Add(prods[index].id, prods[index].unit, prods[index].name, txtCantidad.Text, prods[index].price_in);
                SellObj s = new SellObj();
                s.product_id = prods[index].id;
                s.q = int.Parse(txtCantidad.Text);
                SellObj.re.Add(s);
                cboProducto.SelectedIndex = -1;
                txtCantidad.Text = "";
            }
        }
    }
}
