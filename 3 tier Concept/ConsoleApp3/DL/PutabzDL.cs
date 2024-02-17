using ConsoleApp3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DL
{
    internal class PutabzDL
    {
        public static List<Putabaz> putabazbacha = new List<Putabaz> { };

        public static void ADD(Putabaz p)
        {
            putabazbacha.Add(p);
        }

        public static void Del(int x)
        {
            putabazbacha.RemoveAt(x);
        }

    }
}
