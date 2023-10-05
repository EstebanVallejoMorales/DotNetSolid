using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetSolid.SingleResponsability.Right
{
    public class BeerRequest
    {
        private Beer _beer;
        public BeerRequest(Beer beer)
        {
            _beer = beer;
        }
        public void Send()
        {
            Console.WriteLine($"Sending Beer with name: {_beer.Name} and brand: {_beer.Brand}");
        }
    }
}
