using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    class prekiu_repository
    {
        List<preke> prekiu_sarasas = new List<preke>();
        garantijos_repository garantijos = new garantijos_repository();
        modelio_repository modeliai = new modelio_repository();
        gamintoju_repository gamintojai = new gamintoju_repository();
        paveiksleliu_repository paveiksleliai = new paveiksleliu_repository();
        garantijos_instrukcijos_repository instrukcijos = new garantijos_instrukcijos_repository();
        mobiliuju_irenginiu_repository irenginiai = new mobiliuju_irenginiu_repository();
        public string laikinas_preke_gamintojas; //+
        public string laikinas_preke_modelis; //+
        public string laikinas_preke_garantijos_instrukcija; //+
        public string laikinas_preke_garantijos_galiojimo_laiko_baigimo_data; //+
        public string laikinas_preke_paveikslelis; //+

        public void set_prekiu_sarasas()
        {
            garantijos.set_garantiju_sarasas();
            List<garantija> garantiju_sarasas = garantijos.get_garantiju_sarasas();
            modeliai.set_modeliu_sarasas();
            List<modelis> modeliu_sarasas = modeliai.get_modeliu_sarasas();
            gamintojai.set_gamintoju_sarasas();
            List<gamintojas> gamintoju_sarasas = gamintojai.get_gamintoju_sarasas();
            paveiksleliai.set_paveiksleliu_sarasas();
            List<paveikslelis> paveiksleliu_sarasas = paveiksleliai.get_paveiksleliu_sarasas();
            instrukcijos.set_garantiju_instrukciju_sarasas();
            List<garantijos_instrukcija> instrukciju_sarasas = instrukcijos.get_garantiju_instrukciju_sarasas();
            irenginiai.set_mobiliuju_irenginu_sarasu_id();
            List<mobilieji_irenginiai> irenginiu_sarasas = irenginiai.get_mobiliuju_irenginiu_sarasu_id();

            for (int i = 0; i < irenginiu_sarasas.Count; i++)
            {
                for (int j = 0; j < garantiju_sarasas.Count; j++)
                {
                    if (irenginiu_sarasas[i].garantijos_id == garantiju_sarasas[j].id)
                    {
                        laikinas_preke_garantijos_galiojimo_laiko_baigimo_data = garantiju_sarasas[j].garantijos_galiojimo_baigimo_data;
                        for (int k = 0; k < instrukciju_sarasas.Count; k++)
                        {
                            if (garantiju_sarasas[j].garantijos_instrukcija_garantijos_instrukcijos_id == instrukciju_sarasas[k].id)
                            {
                                laikinas_preke_garantijos_instrukcija = instrukciju_sarasas[k].aprasymas;
                            }
                        }
                    }
                }

                for (int j = 0; j < modeliu_sarasas.Count; j++)
                {
                    if (irenginiu_sarasas[i].modelio_id == modeliu_sarasas[j].id)
                    {
                        laikinas_preke_modelis = modeliu_sarasas[j].pavadinimas;
                    }
                }

                for (int j = 0; j < gamintoju_sarasas.Count; j++)
                {
                    if (irenginiu_sarasas[i].gamintojo_id == gamintoju_sarasas[j].id)
                    {
                        laikinas_preke_gamintojas = gamintoju_sarasas[j].pavadinimas;
                    }
                }

                for (int j = 0; j < paveiksleliu_sarasas.Count; j++)
                {
                    if (irenginiu_sarasas[i].paveikslelio_id == paveiksleliu_sarasas[j].id)
                    {
                        laikinas_preke_paveikslelis = paveiksleliu_sarasas[j].pavadinimas;
                    }
                }

                prekiu_sarasas.Add(new preke(laikinas_preke_gamintojas, laikinas_preke_modelis, laikinas_preke_garantijos_instrukcija, laikinas_preke_garantijos_galiojimo_laiko_baigimo_data, laikinas_preke_paveikslelis, irenginiu_sarasas[i].kaina));
            }
        }

        public List<preke> get_prekiu_sarasas()
        {
            return prekiu_sarasas;
        }
    }
}
