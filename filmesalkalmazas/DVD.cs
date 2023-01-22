using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesalkalmazas
{
    internal class DVD : Film
    {
        private List<string> nyelvek = new List<string>();

        public DVD(string cim, int korhatar, List<string> nyelvek) : base(cim, korhatar)
        {
            this.nyelvek = nyelvek;
        }

        public override string ToString()
        {
            string nyelvout = nyelvek.ToString();
            return $"{cim} - korhatar: {korhatar} - nyelvek: {nyelvout}";
        }
    }
}
