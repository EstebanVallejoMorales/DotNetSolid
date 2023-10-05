using AspSolid.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspSolid.Controllers
{
    public class BeerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(BeerViewModel beerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(beerViewModel);
            }

            //Guardado en DB

            //Guardado en log

            return Ok();
        }
    }
}
