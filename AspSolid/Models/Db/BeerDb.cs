using AspSolid.Models.ViewModels;

namespace AspSolid.Models.Db
{
    public class BeerDb
    {
        public void Save(BeerViewModel beerViewModel)
        {
            Console.WriteLine($"Saving DB " + beerViewModel.Name);
        }
    }
}
