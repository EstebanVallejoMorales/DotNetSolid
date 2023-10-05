using AspSolid.Models.Db;
using AspSolid.Models.ViewModels;

namespace AspSolid.Service
{
    public class BeerService
    {
        public void Create(BeerViewModel beerViewModel)
        {
            BeerDb beerDb = new BeerDb();
            var log = new Utils.Log();
            Console.WriteLine();
        }
    }
}
