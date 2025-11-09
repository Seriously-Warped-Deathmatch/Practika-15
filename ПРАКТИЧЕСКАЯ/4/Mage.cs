using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Mage : Interface1
    {
        public void Ataka()
        {
            Console.WriteLine("Маг атакует!");
        }

        public void Hel()
        {
            Console.WriteLine("Маг лечит...");
        }
    }
}
