using MySql.Data.MySqlClient;

namespace Pedidos
{
    public class SellObj
    {
        public static List<SellObj> sell = new List<SellObj>();
        public static List<SellObj> re = new List<SellObj>();
        public int product_id;
        public int q;        
        public int id;
        public int person_id;
        public int operation_type_id;
        public int box_id;
        public DateTime created_at;

        public static List<SellObj> getAllByOperationTypeId(int kind)
        {
            List<SellObj> list = new List<SellObj>();
            try
            {
                Connection c = new Connection();
                MySqlCommand cmd = c.con.CreateCommand();
                cmd.CommandText = "select * from sell where operation_type_id=" + kind + " order by created_at desc";
                c.con.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    SellObj product = new SellObj();
                    product.id = r.GetInt32("id");
                    if (!r.IsDBNull(1))
                    {
                        product.person_id = r.GetInt32("person_id");
                    }
                    else
                    {
                        product.person_id = 0;
                    }

                    if (!r.IsDBNull(4))
                    {
                        product.box_id = r.GetInt32("box_id");
                    }
                    else
                    {
                        product.box_id = 0;
                    }
                    product.operation_type_id = r.GetInt32("operation_type_id");
                    product.created_at = r.GetDateTime("created_at");
                    list.Add(product);
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
