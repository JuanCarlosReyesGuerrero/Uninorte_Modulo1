namespace Pedidos
{
    public partial class ProductsWindow : Form
    {
        public ProductsWindow()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("unit", "Unidad");
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("price_in", "Precio de entrada");
            dataGridView1.Columns.Add("price_out", "Precio de salida");
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;            
        }

        private void ProductsWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<ProductObj> list = ProductObj.getAll();
            for (int i = 0; i < list.Count; i++)
            {                
                dataGridView1.Rows.Add(list[i].id, list[i].unit, list[i].name, list[i].price_in, list[i].price_out);
            }
        }
    }
}
