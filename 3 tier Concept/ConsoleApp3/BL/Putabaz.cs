using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BL
{
    internal class Putabaz
    {
        private string name;
        private int id;
        private string jump;


        public Putabaz(string name, int id, string jump)
        {
            this.Name = name;
            this.Id = id;
            this.Jump = jump;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public string Jump { get => jump; set => jump = value; }
    }
}
