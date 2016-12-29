using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Configuration;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Stream your favorite music anytime anywhere!";
             var list = new List<SelectListItem>();
            list.Add(new SelectListItem(){Text = "English", Value="English"});
            list.Add(new SelectListItem(){Text = "Spanish", Value="Spanish"});
            list.Add(new SelectListItem(){Text = "Hindi", Value="Hindi"});
            list.Add(new SelectListItem(){Text = "Tulu", Value="Tulu"});
            ViewBag.Clients = list;
            ViewBag.Server = ConfigurationManager.AppSettings["ENVIRONMENT_NAME"].ToString();
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
 
    }
}
