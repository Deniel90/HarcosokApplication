using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosokApplication
{
    class Harcos
    {
        int id;
        string nev;
        DateTime letrehozas;

        public Harcos(int id, string nev, DateTime letrehozas)
        {
            this.Id = id;
            this.Nev = nev;
            this.Letrehozas = letrehozas;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Letrehozas { get => letrehozas; set => letrehozas = value; }

        public override string ToString()
        {
            return String.Format("{0} ({1}.{2}.{3})", Nev, Letrehozas.Year, Letrehozas.Month, Letrehozas.Day);
        }
    }
}
