using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface1[] interfaces = {new Phone(), new Computer() };

            foreach (Interface1 iface in interfaces) 
            {
                iface.Price();
                iface.Data();
            }
        }
    }
}
