using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using filmtutkunu.Models;
namespace filmtutkunu.Models
{
    public class DefaultController : Controller
    {
        // GET: Default
        filmtutkunuEntities db = new filmtutkunuEntities();
        public ActionResult Encokizlenen()
        {
            return View();
        }
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult İmdb()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(kullanicibilgileri y)
        {
            var m = db.kullanicibilgileri.FirstOrDefault(x => x.kullaniciadi == y.kullaniciadi && x.şifre == y.şifre);
            if (m != null)
            {
                FormsAuthentication.SetAuthCookie(m.kullaniciadi, false);
                return RedirectToAction("HomePage", "Default");
            }
            else
            {
                return RedirectToAction("Login", "Default");

            }
        }
        [HttpGet]
        public ActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signin(kullanicibilgileri y2)
        {
            if (y2.isim == null || y2.soyisim == null || y2.kullaniciadi == null || y2.email == null || y2.şifre == null || y2.dogumtarihi == null)
            {
                return View();
            }
            else
            {
                db.kullanicibilgileri.Add(y2);
                db.SaveChanges();
                return RedirectToAction("Login", "Default");
            }
        }
        public ActionResult Yabancıfilmler()
        {
            return View();
        }
        public ActionResult Yerlifilmler()
        {
            return View();
        }
        public ActionResult film1()
        {
            return View();
        }
        public ActionResult film2()
        {
            return View();
        }
        public ActionResult film3()
        {
            return View();
        }
        public ActionResult film4()
        {
            return View();
        }
        public ActionResult film5()
        {
            return View();
        }
        public ActionResult film6()
        {
            return View();
        }
        public ActionResult film7()
        {
            return View();
        }
        public ActionResult film8()
        {
            return View();
        }
        public ActionResult film9()
        {
            return View();
        }
        public ActionResult film10()
        {
            return View();
        }
        public ActionResult film11()
        {
            return View();
        }
        public ActionResult film12()
        {
            return View();
        }
        public ActionResult film13()
        {
            return View();
        }
        public ActionResult film14()
        {
            return View();
        }
        public ActionResult film15()
        {
            return View();
        }
        public ActionResult film16()
        {
            return View();
        }
        public ActionResult film17()
        {
            return View();
        }
        public ActionResult film18()
        {
            return View();
        }
        public ActionResult film19()
        {
            return View();
        }
        public ActionResult film20()
        {
            return View();
        }
    }
}