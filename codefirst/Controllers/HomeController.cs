using System;
using codefirst.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deneme.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
         {
             var context = new NobetYonetimDbContext();
             List<Doktorlar> Doktorlar = context.Doktorlar.ToList();
             return View(Doktorlar);
         }
}
}