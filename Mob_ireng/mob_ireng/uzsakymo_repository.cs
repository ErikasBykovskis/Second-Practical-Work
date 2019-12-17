using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class uzsakymo_repository
    {
        public void insert_uzsakymas(int mobiliojo_irenginio_uzsakymas_mobiliojo_irenginio_uzsakymo_id, int apmokejimas_transakcijos_id)
        {
            MySqlConnection cnn;
            string connectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "insert into uzsakymas (mobiliojo_irenginio_uzsakymas_mobiliojo_irenginio_uzsakymo_id, apmokejimas_transakcijos_id) values ('" + mobiliojo_irenginio_uzsakymas_mobiliojo_irenginio_uzsakymo_id.ToString() + "', '" + apmokejimas_transakcijos_id.ToString() + "');";
            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }
    }
}
