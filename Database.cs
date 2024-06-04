using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem
{
     class Database
    {
        private static String connectionString = "server=localhost;uid=root;pwd=poszeidon50;database=cafe";

        public Database()
        {

        }

        public static DataSet loadData(String query)
        {
            DataSet dataSet = new DataSet();

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {  
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataSet);
                }
            }

            return dataSet;
        }

        public static void addItem(string name, string category, double price)
        {
            String query = "insert into item (name,category,price) values (@p1, @p2, @p3);";   

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Add("@p1", MySqlDbType.VarChar);
                    command.Parameters.Add("@p2", MySqlDbType.VarChar);
                    command.Parameters.Add("@p3", MySqlDbType.Double);
                    command.Parameters["@p1"].Value = name;
                    command.Parameters["@p2"].Value = category;
                    command.Parameters["@p3"].Value = price;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void updateItem(int id, string name, string category, double price)
        {
            String query = $"update item set name=@p1,category=@p2,price=@p3 where id=@p4;";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Add("@p1", MySqlDbType.VarChar);
                    command.Parameters.Add("@p2", MySqlDbType.VarChar);
                    command.Parameters.Add("@p3", MySqlDbType.Double);
                    command.Parameters.Add("@p4", MySqlDbType.Int32);
                    command.Parameters["@p1"].Value = name;
                    command.Parameters["@p2"].Value = category;
                    command.Parameters["@p3"].Value = price;
                    command.Parameters["@p4"].Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void removeItem(int id)
        {
            String query = $"delete from item where id=@p;";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Add("@p", MySqlDbType.Int32);
                    command.Parameters["@p"].Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void placeOrder(double sum, int worker, List<OrderedItem> orderedItems)
        {
            String ordersQuery = $"insert into orders(date, sum, worker) values(@p1, @p2, @p3);";
            String orderItemsQuery = $"insert into order_item(orderid, itemid, quantity, price) values(@p1, @p2, @p3, @p4);";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(ordersQuery, connection))
                {
                    command.Parameters.Add("@p1", MySqlDbType.Timestamp);
                    command.Parameters.Add("@p2", MySqlDbType.Double);
                    command.Parameters.Add("@p3", MySqlDbType.Int32);
                    command.Parameters["@p1"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                    command.Parameters["@p2"].Value = sum;
                    command.Parameters["@p3"].Value = worker;
                    command.ExecuteNonQuery();
                }

                var set = loadData("select max(id) from orders").Tables[0];
                var value = set.Rows[0][0];
                int orderId = Convert.ToInt32(value);


                for(int i = 0; i < orderedItems.Count; i++)
                {
                    int itemId = orderedItems[i].id;
                    int quantity = orderedItems[i].quantity;
                    double price = orderedItems[i].priceSum;

                    using (MySqlCommand command = new MySqlCommand(orderItemsQuery, connection))
                    {
                        command.Parameters.Add("@p1", MySqlDbType.Int32);
                        command.Parameters.Add("@p2", MySqlDbType.Int32);
                        command.Parameters.Add("@p3", MySqlDbType.Int32);
                        command.Parameters.Add("@p4", MySqlDbType.Double);
                        command.Parameters["@p1"].Value = orderId;
                        command.Parameters["@p2"].Value = itemId;
                        command.Parameters["@p3"].Value = quantity;
                        command.Parameters["@p4"].Value = price;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
