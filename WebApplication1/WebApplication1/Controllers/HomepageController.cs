using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Classes;

namespace WebApplication1.Controllers
{
    public class HomepageController : Controller
    {
        // GET: Homepage
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.homepages.ToList();
            return View(deger);
        }

        public PartialViewResult images()
        {
            var deger = c.images.ToList();
            return PartialView(deger);
        }
        public PartialViewResult imagesw()
        {
            var deger = c.galeries.ToList();
            return PartialView(deger);
        }
        public PartialViewResult slider()
        {
            var deger = c.sliders.ToList();
            return PartialView(deger);
        }



        public PartialViewResult icons()
        {
            var deger = c.icons.ToList();
            return PartialView(deger);
        }
    }
}