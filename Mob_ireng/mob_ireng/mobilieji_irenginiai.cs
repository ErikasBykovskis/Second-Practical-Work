using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ireng
{
    class mobilieji_irenginiai
    {
        public int id;
        public string gamintojas;
        public string modelis;
        public string garantijos_instrukcija;
        public int paveikslelio_id;
        public double kaina;

        public mobilieji_irenginiai(int id, string gamintojas, string modelis, string garantijos_instrukcija, int paveikslelio_id, double kaina)
        {
            this.id = id;
            this.gamintojas = gamintojas;
            this.modelis = modelis;
            this.garantijos_instrukcija = garantijos_instrukcija;
            this.paveikslelio_id = paveikslelio_id;
            this.kaina = kaina;
        }
    }
}
