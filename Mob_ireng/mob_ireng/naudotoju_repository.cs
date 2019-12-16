using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    public class naudotojo_repository
    {
        List<naudotojas> prisijunges_naudotojas = new List<naudotojas>();
        public void set_naudotojas(string username, string password)
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from naudotojas";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["username"].ToString() == username && reader["password"].ToString() == password)
                    {
                        prisijunges_naudotojas.Add(new naudotojas(Convert.ToInt32(reader["naudotojo_id"]), Convert.ToString(reader["vardas"]), Convert.ToString(reader["pavarde"]), Convert.ToString(reader["username"]), Convert.ToString(reader["password"]), Convert.ToString(reader["el_pastas"]), Convert.ToString(reader["telefonas"])));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<naudotojas> get_naudotojas()
        {
            return prisijunges_naudotojas;
        }

        public void insert_naudotojas(string vardas, string pavarde, string username, string password, string el_pastas, string telefonas)
        {
            MySqlConnection cnn;
            string connectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "insert into naudotojas (vardas, pavarde, username, password, el_pastas, telefonas) values ('" + vardas + "', '" + pavarde + "', '" + username + "', '" + password + "', '" + el_pastas + "', '" + telefonas + "');";
            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        public void set_naudotojas_by_id(int id)
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from naudotojas where naudotojo_id = '" + id + "';";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["naudotojo_id"]) == id)
                    {
                        prisijunges_naudotojas.Add(new naudotojas(Convert.ToInt32(reader["naudotojo_id"]), Convert.ToString(reader["vardas"]), Convert.ToString(reader["pavarde"]), Convert.ToString(reader["username"]), Convert.ToString(reader["password"]), Convert.ToString(reader["el_pastas"]), Convert.ToString(reader["telefonas"])));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
