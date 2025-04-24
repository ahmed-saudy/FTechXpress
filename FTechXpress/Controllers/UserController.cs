using System.Drawing;
using FTechXpress.Models;
using FTechXpress.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FTechXpress.Controllers
{
    public class UserController : Controller
    {
       TechXpressContextcs contxt = new TechXpressContextcs();
        public IActionResult All()
        {
            var users = contxt.Users.ToList();
            List<UserViewModel> userList = new List<UserViewModel>();
            foreach (var user in users)
            { 
                UserViewModel uvm = new UserViewModel()
                {
                    Id = user.Id,   
                    Name = user.Name,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address
                   
                }
                ;
                if (user.Role == "Admin")
                {
                    uvm.Color = "red";
                }
                else if (user.Role == "User")
                {
                    uvm.Color = "green";
                }
                else
                {
                    uvm.Color = "blue";
                }

                userList.Add(uvm);
             }
            return View(userList);
        }
        
        public IActionResult Details(int ID)
        {
            var user = contxt.Users.FirstOrDefault(U => U.Id==ID);
            UserViewModel uvm = new UserViewModel();
            uvm.Name = user.Name;
            uvm.Email = user.Email;
            uvm.PhoneNumber = user.PhoneNumber;
            uvm.Address = user.Address;
            if (user.Role == "Admin")
            {
                uvm.Color = "red";
            }
            else if (user.Role == "User")
            {
                uvm.Color = "green";
            }
            else
            {
                uvm.Color = "blue";
            }
            return View(uvm);
        }
    }
}
