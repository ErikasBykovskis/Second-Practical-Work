using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ireng
{
    class informacija
    {
        public int gamintojo_id;
        public int modelio_id;
        public int garantijos_id;
        public int paveikslelio_id;

        public informacija(int gamintojo_id, int modelio_id, int garantijos_id, int paveikslelio_id)
        {
            this.gamintojo_id = gamintojo_id;
            this.modelio_id = modelio_id;
            this.garantijos_id = garantijos_id;
            this.paveikslelio_id = paveikslelio_id;
        }
    }
}
