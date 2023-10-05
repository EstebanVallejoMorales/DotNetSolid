using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSolid.SingleResponsability.Right
{
    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Alcohol { get; set; }

        public Beer(string name, string brand)
        {
            Name = name;
            Brand = brand;                           
        }
    }
}
