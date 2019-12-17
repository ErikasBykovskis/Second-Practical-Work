using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class mobiliojo_irenginio_uzsakymo_repository
    {
        List<int> pirkejo_id = new List<int>();
        public void ivesti_mob_ireng_uzs(int mobilieji_irenginiai_mobiliojo_irenginio_id, int pirkejas_pirkejo_id, int kiekis)
        {
            MySqlConnection cnn;
            string connectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "insert into mobiliojo_irenginio_uzsakymas (mobilieji_irenginiai_mobiliojo_irenginio_id, pirkejas_pirkejo_id, kiekis) values ('" + mobilieji_irenginiai_mobiliojo_irenginio_id.ToString() + "', '" + pirkejas_pirkejo_id.ToString() + "', '" + kiekis.ToString() + "');";
            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        public int get_mob_ireng_uzs_id(int pirkejo_id)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select mobilieji_irenginiai_mobiliojo_irenginio_id from mobiliojo_irenginio_uzsakymas where pirkejas_pirkejo_id = '" + pirkejo_id.ToString() + "';";
            MySqlDataReader reader = command.ExecuteReader();
            int id = Convert.ToInt32(reader["mobilieji_irenginiai_mobiliojo_irenginio_id"]);
            connection.Close();
            return id;
        }

        public List<int> get_mob_ireng_uzs_main_id(int pirkejo_id)
        {
            List<int> ids = new List<int>();
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select mobiliojo_irenginio_uzsakymo_id from mobiliojo_irenginio_uzsakymas where pirkejas_pirkejo_id = '" + pirkejo_id.ToString() + "';";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ids.Add(Convert.ToInt32(reader["mobiliojo_irenginio_uzsakymo_id"]));
            }
            connection.Close();
            return ids;
        }
    }
}
