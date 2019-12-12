using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class mobiliuju_irenginiu_repository
    {
        List<mobilieji_irenginiai> mobiliuju_irenginiu_sarasu_id = new List<mobilieji_irenginiai>();
        

        public void set_mobiliuju_irenginu_sarasu_id()
        {
            MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from mobilieji_irenginiai";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mobiliuju_irenginiu_sarasu_id.Add(new mobilieji_irenginiai(Convert.ToInt32(reader["mobiliojo_irenginio_id"]), Convert.ToInt32(reader["gamintojas_gamintojo_id"]), Convert.ToInt32(reader["modelis_modelio_id"]), Convert.ToInt32(reader["garantija_garantijos_id"]), Convert.ToInt32(reader["paveikslelis_paveikslelio_id"]), Convert.ToDouble(reader["kaina"])));
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

        public List<mobilieji_irenginiai> get_mobiliuju_irenginiu_sarasu_id()
        {
            return mobiliuju_irenginiu_sarasu_id;
        }
        
    }
}
