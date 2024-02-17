using ConsoleApp3.DL;
using ConsoleApp3.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

               string x = PutabazUI.showMenu();
                if(x == "1")
                {
                   PutabzDL.ADD (PutabazUI.GetPutabaz(PutabzDL.putabazbacha.Count));
                }
                if(x == "2")
                {
                    PutabazUI.Show(PutabzDL.putabazbacha);
                     PutabzDL.Del(PutabazUI.Remove()-1);
                }
                if(x == "3")
                {
                    PutabazUI.Show(PutabzDL.putabazbacha);
                }
                
                     
                
            }
        }
    }
}
