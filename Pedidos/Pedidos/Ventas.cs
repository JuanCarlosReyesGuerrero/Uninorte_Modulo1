namespace Pedidos
{
    public partial class Ventas : Form
    {
        public static int operation_type;
        List<SellObj> sells;

        public Ventas()
        {
            InitializeComponent();
            if (operation_type == 1)
            {
                Text = "Abastecimiento de Inventario";
            }
            else if (operation_type == 2)
            {
                Text = "Ventas";
            }

            sells = SellObj.getAllByOperationTypeId(operation_type);

            foreach (SellObj s in sells) { cboOperacion.Items.Add("#" + s.id + " - " + s.created_at); }

            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("unidad", "Unidad");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("precio", "Precio");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cboOperacion.SelectedIndex != -1)
            {
                dataGridView1.Rows.Clear();
                List<OperationObj> ops = OperationObj.getAllBySellId(sells[cboOperacion.SelectedIndex].id);
                float total = 0;
                foreach (OperationObj op in ops)
                {
                    ProductObj p = ProductObj.getById(op.product_id);
                    float price = 0;
                    if (operation_type == 1) { price = p.price_in; }
                    else if (operation_type == 2) { price = p.price_out; }
                    dataGridView1.Rows.Add(p.id, p.unit, p.name, op.q, price, op.q * price);
                    total += op.q * price;
                }

                dataGridView1.Rows.Add("", "", "Total", "", "", total);
            }
        }
    }
}
