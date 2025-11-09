using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface1[] interface14 = {new Chet1(), new Chet2() };
            
            foreach (Interface1 interface11 in interface14)
            {
                interface11.d();
                interface11.e();
            }
        }
    }
}
