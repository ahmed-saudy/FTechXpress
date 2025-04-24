using Microsoft.AspNetCore.Mvc;

namespace FTechXpress.Controllers
{
    public class CartController : Controller
    {
      public IActionResult Add()
        {
          //  HttpContext.Session.SetString("cart", "Added");
         Response.Cookies.Append("cart", "Added to cart");
            return Content("Product added to cart");
        }
    }
}
