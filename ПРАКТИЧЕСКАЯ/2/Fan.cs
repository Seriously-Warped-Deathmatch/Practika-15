using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Fan : In
    {
        private int levels = 0;
        private bool on_off = false;
        
        public void OnOff()
        {
            if (on_off)
            {
                on_off = false;
                levels = 0;
                Console.WriteLine($"Вентелятор выключили. Уровень мощности установлен [%{levels}].");
            }
            else
            {
                on_off = true;
                levels = 100;
                Console.WriteLine($"Вентелятор включили. Уровень мощности установлен [%{levels}].");
            }
            Console.WriteLine();
        }
        public void Level()
        {
            Console.WriteLine();
        }
    }
}
