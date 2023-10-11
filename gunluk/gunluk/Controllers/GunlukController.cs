using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gunluk.Models.Entity;
namespace gunluk.Controllers
{
    public class GunlukController : Controller
    {
        // GET: Gunluk
        gunlukEntities sb=new gunlukEntities();
        public ActionResult Index()
        {
            var degerler = sb.gun.ToList();
            return View(degerler);
        }
        public ActionResult bilgiTecrubeGetir()
        {
            var degerler = sb.gun.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult gunlukEkle()
        {
            return View();
        }

      
        [HttpPost]
        public ActionResult gunlukEkle(gun b)
        {
            sb.gun.Add(b);
            sb.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult tecrubeEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult tecrubeEkle(gun b)
        {
            sb.gun.Add(b);
            sb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}