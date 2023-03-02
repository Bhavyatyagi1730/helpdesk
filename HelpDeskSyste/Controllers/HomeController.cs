using HelpDeskSyste.Models.Database;
using Service_layer.Class;
using Service_layer.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Web.UI.WebControls;

namespace HelpDeskSyste.Controllers
{
    public class HomeController : Controller
    {

        Login _log=new Login();
        
        
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Roletable u)
        {
            //Roletable roledata = new Roletable();
            var result = _log.GetinfoByUserCredentials(u.Email, u.Password);
            if (result != null)
            {
                if (result.Roletype=="admin")
                {
                    return RedirectToAction("Dashboard", "Admin");
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
