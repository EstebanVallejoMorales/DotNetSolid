using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSolid.SingleResponsability.Wrong
{
    public class WrongBeer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public WrongBeer(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        public void Save()
        {
            Console.WriteLine("Saving beer");
        }

        public void Send()
        {
            Console.WriteLine($"Sending Beer with name: {Name} and brand: {Brand}");
        }
    }
}
