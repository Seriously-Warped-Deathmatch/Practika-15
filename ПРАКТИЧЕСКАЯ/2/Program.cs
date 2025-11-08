using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            In[] ins = { new Lamp(), new Fan() };

            foreach (In i in ins) 
            {
                i.OnOff();
                i.Level();

                i.OnOff();
                i.Level();
            }
        }
    }
}
