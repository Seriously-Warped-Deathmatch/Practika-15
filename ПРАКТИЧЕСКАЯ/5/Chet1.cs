using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Chet1 : Interface1
    {
        Chet2 chet = new Chet2();
        private int balance = 10000;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void d()
        {
            if (balance < 100) 
            {
                balance += 1000;
                Console.WriteLine($"Счет 1  {balance}");
            }
            else if (balance > 100)
            {
                balance -= 1000;
                Console.WriteLine($"Счет 1 {balance}");
            }
        }
        public void e() 
        {
            if (balance > 1000)
            {
                Balance += 10000;
                balance -= 10000;
                Console.WriteLine($"Счет 1 {balance}");
                Console.WriteLine($"Счет 2 {Balance}");
            }
            Console.WriteLine($"---------------------------");
        }
    }
}
