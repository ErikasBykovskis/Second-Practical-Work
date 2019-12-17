using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class apmokejimo_repository
    {
        public void insert_apmokejimas(int pirkejas_pirkejo_id, string apmokejimo_busena, double prekiu_kaina)
        {
            MySqlConnection cnn;
            string connectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "insert into apmokejimas (pirkejas_pirkejo_id, apmokejimo_busena, prekiu_kaina) values ('" + pirkejas_pirkejo_id.ToString() + "', '" + apmokejimo_busena.ToString() + "', '" + prekiu_kaina.ToString() + "');";
            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        public int get_transakcijos_id()
        {
            int id = 0;
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT transakcijos_id FROM apmokejimas WHERE transakcijos_id=(SELECT max(transakcijos_id) FROM apmokejimas);";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["transakcijos_id"]);
            }
            connection.Close();
            return id;
        }
    }
}
