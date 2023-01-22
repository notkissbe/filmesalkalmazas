using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesalkalmazas
{
    internal class Film
    {
        protected string cim;
        protected int korhatar;

        public Film(string cim, int korhatar)
        {
            this.cim = cim;
            this.korhatar = korhatar;
        }
        protected string Cim { get => cim; set => cim = value; }
        protected int Korhatar { get => korhatar; set => korhatar = value; }

        public bool IsAjanlott(int vizsgaltKorhatar)
        {
            if (vizsgaltKorhatar > korhatar)
            {
                return true;
            }
            return false;
        }

        public string getCim()
        {
            return cim;
        }

        public int GetKorhatar() 
        { 
            return korhatar;
        }

        public override string ToString()
        {
            return $"{cim} - korhatar: {korhatar}";
        }


    }
}
