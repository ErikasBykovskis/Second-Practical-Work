using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ireng
{
    class preke
    {
        public string preke_gamintojas;
        public string preke_modelis;
        public string preke_garantijos_instrukcija;
        public string preke_garantijos_galiojimo_laiko_baigimo_data;
        public string preke_paveikslelis;
        public double preke_kaina;

        public preke(string preke_gamintojas, string preke_modelis, string preke_garantijos_instrukcija, string preke_garantijos_galiojimo_laiko_baigimo_data, string preke_paveikslelis, double preke_kaina)
        {
            this.preke_gamintojas = preke_gamintojas;
            this.preke_modelis = preke_modelis;
            this.preke_garantijos_instrukcija = preke_garantijos_instrukcija;
            this.preke_garantijos_galiojimo_laiko_baigimo_data = preke_garantijos_galiojimo_laiko_baigimo_data;
            this.preke_paveikslelis = preke_paveikslelis;
            this.preke_kaina = preke_kaina;
        }
    }
}
