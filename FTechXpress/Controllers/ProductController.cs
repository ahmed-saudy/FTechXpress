using FTechXpress.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FTechXpress.Controllers
{
    public class ProductController : Controller
    {
        TechXpressContextcs context = new TechXpressContextcs();
       public IActionResult All()
        {
            // This action method will return a view that displays all products.
            var prd = context.Products.Include(p => p.Category).ToList();
            //viewbag is used to pass data from the controller to the view 
            //var usr = context.Users.ToList();
            //ViewBag.user = usr;
            ViewBag.WishList = HttpContext.Session.GetString("wishList");
            ViewBag.Cart = Request.Cookies["cart"];
            return View(prd);
        }
       
        public IActionResult Details(int id)
        {
            // This action method will return a view that displays the details of a specific product.
            var prd = context.Products.Include(P=>P.Category).FirstOrDefault(p => p.ID == id);
            if (prd == null)
            {
                return NotFound();
            }
            return View(prd);
           
        }
       
        public IActionResult New ()
        {
            // This action method will return a view that displays a form for adding a new product.
           
          
            ViewBag.category = context.Categories.ToList();
            return View(new Product());
        }
        [HttpPost]
       
        public IActionResult SaveNew(Product prd)
        {
            var CAT = context.Categories.FirstOrDefault(c => c.ID == prd.Category.ID);
            prd.Category = CAT;
            // This action method will handle the form submission for adding a new product.
            if (ModelState.IsValid)
            {
                context.Products.Add(prd);
                context.SaveChanges();
                TempData["Added"] = "Product Added Successfully";
                return RedirectToAction("All");
            }
            //Product prd = new Product()
            //{ Name = Name, Description = Description, Price = Price, Stock = stock };   
            //context.Products.Add(prd);
            //context.SaveChanges();
            //return RedirectToAction("All");
            ViewBag.category = context.Categories.ToList();
            return View("New", new Product());
        }
      
        public IActionResult Delete(int id)
        {
            // This action method will delete a product and redirect to the All action.
            var prd = context.Products.FirstOrDefault(p => p.ID == id);
            if (prd != null)
            {
                context.Products.Remove(prd);
                context.SaveChanges();
                TempData["Deleted"] = "Product Deleted Successfully";
                return RedirectToAction("All");

            }
            return RedirectToAction("All");
        }
      
        public IActionResult Edit(int id)
        {
            // This action method will return a view that displays a form for editing an existing product.
          var prd = context.Products.Include(prd => prd.Category).FirstOrDefault(p => p.ID == id);
            ViewBag.Category = context.Categories.ToList();
            return View(prd);
        }
        [HttpPost]
      
        public IActionResult SaveEdit(Product prd)
        {
            var old = context.Products.Include(P=>P.Category).FirstOrDefault(p => p.ID == prd.ID);
            if (ModelState.IsValid)
            {
                    old.Name = prd.Name;
                    old.Description = prd.Description;
                    old.Price = prd.Price;
                    old.Stock = prd.Stock;
                    old.Category = prd.Category;
                context.Products.Update(old);
                    context.SaveChanges();
                    TempData["Edited"] = "Product Edited Successfully";
                     return RedirectToAction("All");
            }

            ViewBag.Category = context.Categories.ToList();
            return View("Edit", prd);
           
        }


    }
}
