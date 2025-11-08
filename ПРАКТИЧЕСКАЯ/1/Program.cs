using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robots[] team = { new RobotCleaner(), new RobotTheHandyman() };

            foreach (Robots robot in team) 
            {
                robot.Work();
                robot.Work();
                robot.ChargingTheBattery();
                robot.Work();
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
