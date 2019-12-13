using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class naudotoju_repository
    {
        List<naudotojas> naudotoju_sarasas = new List<naudotojas>();
        public void set_naudotoju_sarasas()
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
                    naudotoju_sarasas.Add(new naudotojas(Convert.ToInt32(reader["naudotojo_id"]), Convert.ToString(reader["vardas"]), Convert.ToString(reader["pavarde"]), Convert.ToString(reader["username"]), Convert.ToString(reader["password"]), Convert.ToString(reader["el_pastas"]), Convert.ToString(reader["telefonas"])));
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

        public List<naudotojas> get_naudotoju_sarasas()
        {
            return naudotoju_sarasas;
        }

        public void insert_naudotoju_sarasas(string vardas, string pavarde, string username, string password, string el_pastas, string telefonas)
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into naudotojas values ('" + vardas + "', '" + pavarde + "', '" + username + "', '" + password + "', '" + el_pastas + "', '" + telefonas + "');";
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
