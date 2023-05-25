using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyák
{
    internal class Kutyak
    {
        int kutyaid;
        string fajta;
        string fajta_eredeti;
        string nev;
        int eletkor;
        string utolso_ellen;

        public Kutyak(int kutyaid, string fajta, string fajta_eredeti, string nev, int eletkor, string utolso_ellen)
        {
            this.kutyaid = kutyaid;
            this.fajta = fajta;
            this.fajta_eredeti = fajta_eredeti;
            this.nev = nev;
            this.eletkor = eletkor;
            this.utolso_ellen = utolso_ellen;
        }
        public int Kutyaid { get => kutyaid; }
        public string Fajta { get => fajta; }
        public string Fajta_eredeti { get => fajta_eredeti; }
        public string Nev { get => nev; }
        public int Eletkor { get => eletkor; }
        public string Utolso_ellen { get => utolso_ellen; }
    }
}
