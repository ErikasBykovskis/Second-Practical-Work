using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class gamintoju_repository
    {
        List<gamintojas> gamintoju_sarasas = new List<gamintojas>();

        public void set_gamintoju_sarasas()
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from gamintojas";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    gamintoju_sarasas.Add(new gamintojas(Convert.ToInt32(reader["gamintojo_id"]), Convert.ToString(reader["pavadinimas"])));
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

        public List<gamintojas> get_gamintoju_sarasas()
        {
            return gamintoju_sarasas;
        }
    }
}
