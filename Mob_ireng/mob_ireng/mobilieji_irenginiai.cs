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
        public int gamintojo_id;
        public int modelio_id;
        public int garantijos_id;
        public int paveikslelio_id;
        public double kaina;

        public mobilieji_irenginiai(int id, int gamintojo_id, int modelio_id, int garantijos_id, int paveikslelio_id, double kaina)
        {
            this.id = id;
            this.gamintojo_id = gamintojo_id;
            this.modelio_id = modelio_id;
            this.garantijos_id = garantijos_id;
            this.paveikslelio_id = paveikslelio_id;
            this.kaina = kaina;
        }
    }
}
