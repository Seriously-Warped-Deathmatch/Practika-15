using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Chet2 : Interface1
    {
        private int balance = 10000;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void d()
        {
            if (balance < 10000)
            {
                balance += 1000;
                Console.WriteLine($"Счет 2 {balance}");
            }
            else if (balance > 10000)
            {
                balance -= 1000;
                Console.WriteLine($"Счет 2 {balance}");
            }
        }
        public void e()
        {

        }
    }
}
