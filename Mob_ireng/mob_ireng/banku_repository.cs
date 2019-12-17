using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class banku_repository
    {
        List<bankas> banku_sarasas = new List<bankas>();

        public void set_banku_sarasas()
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from bankas";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    banku_sarasas.Add(new bankas(Convert.ToInt32(reader["banko_id"]), Convert.ToString(reader["pavadinimas"])));
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

        public List<bankas> get_banku_sarasas()
        {
            return banku_sarasas;
        }
    }
}
