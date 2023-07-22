using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
public IActionResult Create()
        {
            return View();
        }

public IActionResult Edit()
{
   return View();
}

public IActionResult Details()
{
    return View();
}

public IActionResult Delete()
{
    return View();
}
    }
}