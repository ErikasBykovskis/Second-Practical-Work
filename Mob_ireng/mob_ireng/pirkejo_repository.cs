using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class pirkejo_repository
    {
        public void insert_pirkejas(int naudotojas_naudotojo_id, int bankas_banko_id, string banko_korteles_numeris)
        {
            MySqlConnection cnn;
            string connectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "insert into pirkejas (naudotojas_naudotojo_id, bankas_banko_id, banko_korteles_numeris) values ('" + naudotojas_naudotojo_id.ToString() + "', '" + bankas_banko_id.ToString() + "', '" + banko_korteles_numeris.ToString() + "');";
            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }
        public int get_naudotojo_id(int naudotojas_prisijunges)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from pirkejas where naudotojo_id = '" + naudotojas_prisijunges.ToString() + "';";
            MySqlDataReader reader = command.ExecuteReader();
            int id = Convert.ToInt32(reader["naudotojas_naudotojo_id"]);
            connection.Close();
            return id;
        }

        public int get_pirkejo_id()
        {
            int id = 0;
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT pirkejo_id FROM pirkejas WHERE pirkejo_id=(SELECT max(pirkejo_id) FROM pirkejas);";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["pirkejo_id"]);
            }
            connection.Close();
            return id;
        }
    }
}
