using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSolid.SingleResponsability.Right
{
    public class BeerDb
    {
        private Beer _beer;
        public BeerDb(Beer beer)
        {
            _beer = beer;
        }
        public void Save()
        {
            Console.WriteLine("Saving beer");
        }
    }
}
