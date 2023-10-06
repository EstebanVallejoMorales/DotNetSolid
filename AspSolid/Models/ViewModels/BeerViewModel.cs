namespace AspSolid.Models.ViewModels
{
    public class BeerViewModel
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Alcohol { get; set; }

        public string GetInfo() => $"Name: {Name}, Brand: {Brand}, Alcohol: {Alcohol} ";
    }
}
