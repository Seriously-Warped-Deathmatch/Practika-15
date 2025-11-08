using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Phone : Interface1
    {
        private int price = 10000;
        private int datawarranty = 100; // дней

        public void Price()
        {
            Console.WriteLine(price);
        }

        public void Data()
        {
            Console.WriteLine(datawarranty);
        }
    }
}
