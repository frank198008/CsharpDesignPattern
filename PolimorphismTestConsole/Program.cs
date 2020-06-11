using PersonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Kid p = new Kid("Marry",4);
            p.Introduce();
        }
    }
}
