using MySql.Data.MySqlClient;

namespace Pedidos
{
    public class ListaPedidoObj
    {       
        public int id;
        public int codigo;
        public string nombre;
        public string unidad;
        public int cantidad;
        public decimal precio;
        public decimal total;
        public int status;
        bool is_active;


        public static List<ListaPedidoObj> getAllPedidos()
        {
            List<ListaPedidoObj> list = new List<ListaPedidoObj>();
            try
            {
                Connection c = new Connection();
                MySqlCommand cmd = c.con.CreateCommand();
                cmd.CommandText = "SELECT * from venta WHERE venta.status = 1";
                c.con.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    ListaPedidoObj pedido = new ListaPedidoObj();
                    pedido.id = r.GetInt32("id");
                    pedido.codigo =  r.GetInt32("code");
                    pedido.nombre = r.GetString("name");
                    pedido.unidad = r.GetString("unit");
                    pedido.cantidad = r.GetInt32("cant");
                    pedido.precio =  r.GetDecimal("price");
                    pedido.total = r.GetDecimal("total");
                    
                    list.Add(pedido);
                }
            }
            catch (MySqlException me)
            {

                MessageBox.Show(me.Message);

            }

            return list;
        }
    }
}
