using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ireng
{
    class garantija
    {
        public int id;
        public int garantijos_instrukcija_garantijos_instrukcijos_id;
        public string garantijos_galiojimo_baigimo_data;

        public garantija(int id, int garantijos_instrukcija_garantijos_instrukcijos_id, string garantijos_galiojimo_baigimo_data)
        {
            this.id = id;
            this.garantijos_instrukcija_garantijos_instrukcijos_id = garantijos_instrukcija_garantijos_instrukcijos_id;
            this.garantijos_galiojimo_baigimo_data = garantijos_galiojimo_baigimo_data; 
        }
    }
}
