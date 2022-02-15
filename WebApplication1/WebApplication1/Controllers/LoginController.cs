using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models.Classes;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var bilgiler = c.admins.FirstOrDefault(x => x.UserName == ad.UserName && x.pwd == ad.pwd);
            if (bilgiler !=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.UserName, false);
                Session["UserName"] = bilgiler.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }

    }
}