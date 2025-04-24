using Microsoft.AspNetCore.Mvc;

namespace FTechXpress.Controllers
{
    public class WishlListController : Controller
    {
        public IActionResult Add()
        {
            // Logic to add an item to the wish list
            HttpContext.Session.SetString("wishList", "Added To WishList");
            return Content("Add To Wish List");
        }
    }
}
