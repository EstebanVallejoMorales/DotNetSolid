using AspSolid.Models.ViewModels;
using AspSolid.Service;
using Microsoft.AspNetCore.Mvc;

namespace AspSolid.Controllers
{
    public class BeerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BeerViewModel beerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(beerViewModel);
            }

            BeerService beerService = new BeerService();
            beerService.Create(beerViewModel); //The add method only creates a beer.
            
            return Ok();
        }
    }
}
