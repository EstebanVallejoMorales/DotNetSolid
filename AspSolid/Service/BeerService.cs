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

            beerDb.Save(beerViewModel); //BeerDB only save a BeerViewModel in DB
            log.Save($"The beer: {beerViewModel.GetInfo()}"); //Log only write a string content in a a file.
        }
    }
}
