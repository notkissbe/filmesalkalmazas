using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesalkalmazas
{
    internal class Film
    {
        private string cim;
        private int korhatar;

        public Film(string cim, int korhatar)
        {
            this.cim = cim;
            this.korhatar = korhatar;
        }
        protected string Cim { get => cim; set => cim = value; }
        protected int Korhatar { get => korhatar; set => korhatar = value; }

        protected bool IsAjanlott(int vizsgaltKorhatar)
        {
            if (vizsgaltKorhatar > korhatar)
            {
                return true;
            }
            return false;
        }

        protected string getCim()
        {
            return cim;
        }

        protected int GetKorhatar() 
        { 
            return korhatar;
        }


    }
}
