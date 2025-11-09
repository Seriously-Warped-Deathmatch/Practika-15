using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface1[] interface1 = { new warrior(), new Mage() };
            foreach (Interface1 interface11 in interface1) 
            {
                interface11.Ataka();
                interface11.Hel();
            }
        }
    }
}
