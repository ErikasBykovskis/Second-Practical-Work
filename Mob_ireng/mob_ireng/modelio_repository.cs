using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class modelio_repository
    {
        List<modelis> modeliu_sarasas = new List<modelis>();
        public void set_modeliu_sarasas()
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from modelis";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    modeliu_sarasas.Add(new modelis(Convert.ToInt32(reader["modelio_id"]), Convert.ToInt32(reader["gamintojas_gamintojo_id"]), Convert.ToString(reader["pavadinimas"])));
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

        public List<modelis> get_modeliu_sarasas()
        {
            return modeliu_sarasas;
        }
    }
}
