namespace Pedidos
{
    public partial class newProduct : Form
    {
        public newProduct()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPrecioEntrada.Text != "" && txtPrecioSalida.Text != "")
            {
                Connection c = new Connection();

                c.execute("insert into product (name,price_in,price_out,unit) value(\"" + txtNombre.Text + "\",\"" + txtPrecioEntrada.Text + "\",\"" + txtPrecioSalida.Text + "\",\"" + txtUnidad.Text + "\")");

                MessageBox.Show("Producto agregado exitosamente!");

                txtNombre.Text = txtPrecioEntrada.Text = txtPrecioSalida.Text = txtUnidad.Text = "";
            }
            else
            {
                MessageBox.Show("Campos requeridos: Nombre, precio entrada, precio salida");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
