using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class DersController : Controller
    {
        // GET: Ders
        public ActionResult Index()
        {
            using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())


                return View(dbmodel.Ders.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Ders ders)
        {
            try
            {
                using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
                {
                    dbmodel.Ders.Add(ders);
                    dbmodel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          

        }

        public ActionResult Delete(int id)
        {
            using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
            {
                return View(dbmodel.Ders.Where(x => x.DersID == id).FirstOrDefault());
            }

        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
                {
                    Ders ders = dbmodel.Ders.Where(x => x.DersID == id).FirstOrDefault();
                    dbmodel.Ders.Remove(ders);
                    dbmodel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
           
        }
        public ActionResult dnm() {
            return View();
        }
    }
}