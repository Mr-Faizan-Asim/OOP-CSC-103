using ConsoleApp3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.UI
{
    internal class PutabazUI
    {
        public static Putabaz GetPutabaz(int size)
        {

            Console.WriteLine("Name");
            string name = Console.ReadLine();
            int id = size + 1;
            Console.WriteLine("Jump");
            string Jump = Console.ReadLine();
            Putabaz x = new Putabaz(name, id, Jump);
            return x;

        }
        public static string showMenu()
        {
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Show");
            return Console.ReadLine();
            
        }
        public static int Remove()
        {
            Console.WriteLine("ID");
            return int.Parse(Console.ReadLine());

        }
        public static void Show(List<Putabaz> P)
        {
            foreach(Putabaz x in P)
            {
                Console.WriteLine(x.Id); Console.WriteLine(x.Name);
            }
        }
    }
}
