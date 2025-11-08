using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Lamp: In
    {
        private int levels = 0;
        private bool on_off = false;

        public void OnOff()
        {
            if (on_off)
            {
                on_off = false;
                levels = 0;
                Console.WriteLine($"Лампу выключили. Уровень яркости установлен [%{levels}].");
            }
            else
            {
                on_off = true;
                levels = 100;
                Console.WriteLine($"Лампу включили. Уровень яркости установлен [%{levels}].");
            }
            Console.WriteLine();
        }
        public void Level()
        {
            if (on_off)
            {
                levels = 30;
                Console.WriteLine($"Уровень яркости установлен [%{levels}].");
            }
            Console.WriteLine();
        }
    }
}
