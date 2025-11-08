using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RobotCleaner : Robots
    {
        private int BatteryCharge = 100;
        private string Name = "Чистюля";

        public void Work()
        {
            if (BatteryCharge > 30)
            {
                BatteryCharge -= 30;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Робот по имени {Name} моет полы, энергия робота [%{BatteryCharge}]");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Недостаточно энергии робота [%{BatteryCharge}]!");
                BatteryCharge += 5;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Робот по имени {Name} поменял батарею и востановил немного энергии, энергия робота [%{BatteryCharge}].");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Рекомендуем отправить робота на зарядку.");
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        public void ChargingTheBattery()
        {
            BatteryCharge += 50;
            if (BatteryCharge > 120)
            {
                BatteryCharge = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Робот по имени {Name} перезаряжен и его батарея повреждена, энергия робота [%{BatteryCharge}]");
            }
            else if (BatteryCharge > 100)
            {
                BatteryCharge = 100;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Робот по имени {Name} полностью заряжен, энергия робота [%{BatteryCharge}]");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Робот по имени {Name} заряжается на станции зарядки, энергия робота [%{BatteryCharge}]");
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
