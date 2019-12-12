using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class paveiksleliu_repository
    {
        List<paveikslelis> paveiksleliu_sarasas = new List<paveikslelis>();

        public void set_paveiksleliu_sarasas()
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from paveikslelis";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    paveiksleliu_sarasas.Add(new paveikslelis(Convert.ToInt32(reader["paveikslelio_id"]), Convert.ToString(reader["pavadinimas"])));
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

        public List<paveikslelis> get_paveiksleliu_sarasas()
        {
            return paveiksleliu_sarasas;
        }
    }
}
