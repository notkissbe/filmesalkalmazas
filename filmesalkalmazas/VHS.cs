using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesalkalmazas
{
    internal class VHS : Film
    {
        private int szalaghossz;
        public VHS(string cim, int korhatar, int szalaghossz) : base(cim, korhatar)
        {
            this.szalaghossz = szalaghossz;
        }
    }
}
