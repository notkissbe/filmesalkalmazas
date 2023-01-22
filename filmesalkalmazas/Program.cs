using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesalkalmazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film f1 = new Film("majom",12);

            Console.WriteLine(f1);
            Console.ReadLine();
        }
    }
}
