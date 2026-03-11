using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Services;

namespace WebApplication1.Controllers
{
    public class RegisterController : Controller
    {

        [HttpPost]
        public IActionResult RegisterClient(Clients model)
        {
            ClientServices cs = new ClientServices();
            if (!cs.AddClient(model))
            {

                TempData["error"] = "User Not Registered!!!";

                return RedirectToAction("ClientRegister", "Home");

            }
            TempData["success"] = "User Registered You Can Login Now!!!";
             return RedirectToAction("ClientRegister", "Home");


        }

        [HttpPost]
        public IActionResult LoginCheck(LoginModel model)
        {
            

            if (!ClientServices.isValid(model))
            {
                TempData["LoginFailed"] = "Invalid Login Credentials";

                return RedirectToAction("LoginForm", "Home");
               
            }


            return RedirectToAction("ClientHome", "Home");
        }
        
    }
}

