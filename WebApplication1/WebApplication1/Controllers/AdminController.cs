using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Classes;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.homepages.ToList();
            return View(deger);
        }

        public ActionResult CallHomepage(int Id)
        {
            var ch = c.homepages.Find(Id);
            return View("CallHomepage",ch);
        }
        public ActionResult UpdateHomepage(Homepage x)
        {
            var uh = c.homepages.Find(x.Id);
            uh.PageName = x.PageName;
            uh.AboutMe = x.AboutMe;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        /* İkon İşlemleri*/ 
        public ActionResult CallIcon()
        {
            var deger = c.icons.ToList();
            return View(deger); 
        }
        [HttpGet]
         public ActionResult NewIcon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewIcon(Icon p)
        {
            c.icons.Add(p);
            c.SaveChanges();
            return RedirectToAction("CallIcon");
        }

        public ActionResult BringIcon(int id) 
        {
            var bi = c.icons.Find(id);
            return View("BringIcon", bi);   
        }
        public ActionResult UpdateIcon(Icon x)
        {
            var ui = c.icons.Find(x.Id);
            ui.Link = x.Link;
            ui.IconName = x.IconName;
            c.SaveChanges();
            return RedirectToAction("CallIcon");
        }

        public ActionResult DeleteIcon(int Id)
        {
            var di = c.icons.Find(Id);
            c.icons.Remove(di);
            c.SaveChanges();
            return RedirectToAction("CallIcon");
        }

        /* Projelerim */

        public ActionResult ListProject()
        {
            var deger = c.images.ToList();
            return View(deger);
        }

        public ActionResult DeleteProject(int Id)
        {
            var dp = c.images.Find(Id);
            c.images.Remove(dp);
            c.SaveChanges();
            return RedirectToAction("ListProject");
        }
        [HttpGet]
        public ActionResult NewProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewProject(Images p)
        {
            c.images.Add(p);
            c.SaveChanges();
            return RedirectToAction("ListProject");
        }
        public ActionResult BringProject(int id)
        {
            var bi = c.icons.Find(id);
            return View("BringProject", bi);
        }
        public ActionResult UpdateProject(Images x)
        {
            var up = c.images.Find(x.Id);
            up.pic = x.pic;
            up.header = x.header;
            up.about = x.about;
            c.SaveChanges();
            return RedirectToAction("ListProject");
        }
        /*Slider*/
        public ActionResult ListSlider()
        {
            var deger = c.sliders.ToList();
            return View(deger);
        }
        public ActionResult DeleteSlider(int Id)
        {
            var ds = c.sliders.Find(Id);
            c.sliders.Remove(ds);
            c.SaveChanges();
            return RedirectToAction("ListSlider");
        }

        [HttpGet]
        
        public ActionResult BringSlider(int id)
        {
            var bi = c.sliders.Find(id);
            return View("BringSlider", bi);
        }
        public ActionResult UpdateSlider(Slider x)
        {
            var up = c.sliders.Find(x.Id);
            up.pic = x.pic;
            up.header = x.header;
            c.SaveChanges();
            return RedirectToAction("ListSlider");
        }

        /* Galeri */

        public ActionResult ListGalery()
        {
            var deger = c.galeries.ToList();
            return View(deger);
        }
        public ActionResult DeleteGalery(int Id)
        {
            var ds = c.galeries.Find(Id);
            c.galeries.Remove(ds);
            c.SaveChanges();
            return RedirectToAction("ListGalery");
        }
        [HttpGet]
        public ActionResult NewGalery()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewGalery(Galery p)
        {
            c.galeries.Add(p);
            c.SaveChanges();
            return RedirectToAction("ListGalery");
        }
        public ActionResult BringGaley(int id)
        {
            var bi = c.galeries.Find(id);
            return View("BringGaley", bi);
        }
        public ActionResult UpdateGalery(Galery  x)
        {
            var up = c.galeries.Find(x.Id);
            up.pic = x.pic;
            up.header = x.header;
            c.SaveChanges();
            return RedirectToAction("ListGalery");
        }

        /* Hesaplar */
        public ActionResult ListAdmin()
        {
            var deger = c.admins.ToList();
            return View(deger);
        }
        public ActionResult DeleteAdmin(int Id)
        {
            var da = c.admins.Find(Id);
            c.admins.Remove(da);
            c.SaveChanges();
            return RedirectToAction("ListAdmin");
        }
        [HttpGet]
        public ActionResult NewAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewAdmin(Admin p)
        {
            c.admins.Add(p);
            c.SaveChanges();
            return RedirectToAction("ListAdmin");
        }
        public ActionResult BringAdmin(int id)
        {
            var ba = c.admins.Find(id);
            return View("BringAdmin", ba);
        }
        public ActionResult UpdateAdmin(Admin x)
        {
            var ua = c.admins.Find(x.Id);
            ua.UserName = x.UserName;
            ua.pwd = x.pwd;
            c.SaveChanges();
            return RedirectToAction("ListAdmin");
        }

    }
}