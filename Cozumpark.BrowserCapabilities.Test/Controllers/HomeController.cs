using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cozumpark.BrowserCapabilities;
namespace Cozumpark.BrowserCapabilities.Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
      
            var data = Request.Browser.GetCapabilities();
            return View(data);
        }
    }
}