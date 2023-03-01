using HelpDeskSyste.Models.Database;
using Service_layer.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace HelpDeskSyste.Controllers
{
    public class HomeController : Controller
    {
        private ILogin _login;

      

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Roletable u)
        {
           
            var result = _login.GetinfoByUserCredentials(u.Email, u.Password);
            if (result != null)
            {
                if (result.Roletype=="admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "User");
                }

            }



            return View();
        }

    }
}
