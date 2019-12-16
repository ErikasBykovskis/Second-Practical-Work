using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ireng
{
    public class naudotojas
    {
        public int id;
        public string vardas;
        public string pavarde;
        public string username;
        public string password;
        public string el_pastas;
        public string telefonas;

        public naudotojas(int id, string vardas, string pavarde, string username, string password, string el_pastas, string telefonas)
        {
            this.id = id;
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.username = username;
            this.password = password;
            this.el_pastas = el_pastas;
            this.telefonas = telefonas;
        }
    }
}
