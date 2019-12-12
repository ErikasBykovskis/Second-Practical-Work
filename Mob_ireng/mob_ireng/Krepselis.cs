using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ireng
{
    class Krepselis
    {
        public string pavadinimas;
        public double kaina;
        public int kiekis;

        public Krepselis(string pavadinimas, double kaina, int kiekis)
        {
            this.pavadinimas = pavadinimas;
            this.kaina = kaina;
            this.kiekis = kiekis;
        }


        public double ApskaiciuotaKainaBePvm()
        {
            double naujakaina = 0;
            naujakaina = naujakaina + (kiekis * kaina);
            return naujakaina;
        }

        public double ApskaiciuotaKainaSuPvm()
        {
            double naujakaina = 0;
            naujakaina = naujakaina + (kiekis * kaina);
            naujakaina = (naujakaina * 0.21) + naujakaina;
            return naujakaina;
        }
    }
}
