using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class informaciju_repository
    {
        List<informacija> informaciju_sarasas = new List<informacija>();
        garantijos_repository garantijos = new garantijos_repository();
        List<garantija> garantiju_sarasas = new List<garantija>();
        modelio_repository modeliai = new modelio_repository();
        List<modelis> modeliu_sarasas = new List<modelis>();
        gamintoju_repository gamintojai = new gamintoju_repository();
        List<gamintojas> gamintoju_sarasas = new List<gamintojas>();
        paveiksleliu_repository paveiksleliai = new paveiksleliu_repository();
        List<paveikslelis> paveiksleliu_sarasas = new List<paveikslelis>();
        public int laikinas_gamintojo_id;
        public int laikinas_modelio_id;
        public int laikinas_garantijos_id;
        public int laikinas_paveikslelio_id;

        public List<garantija> get_garantiju_sarasas()
        {
            return garantiju_sarasas;
        }

        public List<modelis> get_modeliu_sarasas()
        {
            return modeliu_sarasas;
        }

        public List<gamintojas> get_gamintoju_sarasas()
        {
            return gamintoju_sarasas;
        }

        public List<paveikslelis> get_paveiksleliu_sarasas()
        {
            return paveiksleliu_sarasas;
        }

        public void set_informaciju_sarasas()
        {
            garantijos.set_garantiju_sarasas();
            garantiju_sarasas = garantijos.get_garantiju_sarasas();
            modeliai.set_modeliu_sarasas();
            modeliu_sarasas = modeliai.get_modeliu_sarasas();
            gamintojai.set_gamintoju_sarasas();
            gamintoju_sarasas = gamintojai.get_gamintoju_sarasas();
            paveiksleliai.set_paveiksleliu_sarasas();
            paveiksleliu_sarasas = paveiksleliai.get_paveiksleliu_sarasas();
        }

        public void insert_informaciju_sarasas(string gamintojas, string modelis, string garantija, string paveikslelis, double kaina)
        {
            garantijos.set_garantiju_sarasas();
            garantiju_sarasas = garantijos.get_garantiju_sarasas();
            modeliai.set_modeliu_sarasas();
            modeliu_sarasas = modeliai.get_modeliu_sarasas();
            gamintojai.set_gamintoju_sarasas();
            gamintoju_sarasas = gamintojai.get_gamintoju_sarasas();
            paveiksleliai.set_paveiksleliu_sarasas();
            paveiksleliu_sarasas = paveiksleliai.get_paveiksleliu_sarasas();
            for (int i = 0; i < gamintoju_sarasas.Count; i++)
            {
                if (gamintojas == gamintoju_sarasas[i].pavadinimas)
                {
                    laikinas_gamintojo_id = gamintoju_sarasas[i].id;
                }
            }
            for (int i = 0; i < modeliu_sarasas.Count; i++)
            {
                if (modelis == modeliu_sarasas[i].pavadinimas)
                {
                    laikinas_modelio_id = modeliu_sarasas[i].id;
                }
            }
            for (int i = 0; i < garantiju_sarasas.Count; i++)
            {
                if (garantija == garantiju_sarasas[i].garantijos_galiojimo_baigimo_data)
                {
                    laikinas_garantijos_id = garantiju_sarasas[i].id;
                }
            }
            for (int i = 0; i < paveiksleliu_sarasas.Count; i++)
            {
                if (paveikslelis == paveiksleliu_sarasas[i].pavadinimas)
                {
                    laikinas_paveikslelio_id = paveiksleliu_sarasas[i].id;
                }
            }
            informaciju_sarasas.Add(new informacija(laikinas_gamintojo_id, laikinas_modelio_id, laikinas_garantijos_id, laikinas_paveikslelio_id));
            MySqlConnection cnn;
            string connectionString = "server = 127.0.0.1; uid = root; pwd = Materlink259874; database = mob_ireng";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "insert into mobilieji_irenginiai (gamintojas_gamintojo_id, modelis_modelio_id, garantija_garantijos_id, paveikslelis_paveikslelio_id, kaina) values ('" + informaciju_sarasas[0].gamintojo_id.ToString() + "', '" + informaciju_sarasas[0].modelio_id.ToString() + "', '" + informaciju_sarasas[0].garantijos_id.ToString() + "', '" + informaciju_sarasas[0].paveikslelio_id.ToString() + "', '" + kaina.ToString() + "');";
            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }
    }
}
