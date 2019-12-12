using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class garantijos_instrukcijos_repository
    {
        List<garantijos_instrukcija> garantiju_instrukciju_sarasas = new List<garantijos_instrukcija>();
        public void set_garantiju_instrukciju_sarasas()
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from garantijos_instrukcija";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    garantiju_instrukciju_sarasas.Add(new garantijos_instrukcija(Convert.ToInt32(reader["garantijos_instrukcijos_id"]), Convert.ToString(reader["aprasymas"])));
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

        public List<garantijos_instrukcija> get_garantiju_instrukciju_sarasas()
        {
            return garantiju_instrukciju_sarasas;
        }
    }
}
