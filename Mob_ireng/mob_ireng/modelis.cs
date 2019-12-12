using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ireng
{
    class modelis
    {
        public int id;
        public int gamintojo_id;
        public string pavadinimas;

        public modelis(int id, int gamintojo_id, string pavadinimas)
        {
            this.id = id;
            this.gamintojo_id = gamintojo_id;
            this.pavadinimas = pavadinimas;
        }
    }
}
