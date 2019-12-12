using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class garantijos_repository
    {
        List<garantija> garantiju_sarasas = new List<garantija>();

        public void set_garantiju_sarasas()
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from garantija";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    garantiju_sarasas.Add(new garantija(Convert.ToInt32(reader["garantijos_id"]), Convert.ToInt32(reader["garantijos_instrukcija_garantijos_instrukcijos_id"]), Convert.ToString(reader["garantijos_galiojimo_baigimo_data"])));
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

        public List<garantija> get_garantiju_sarasas()
        {
            return garantiju_sarasas;
        }

    }
}
