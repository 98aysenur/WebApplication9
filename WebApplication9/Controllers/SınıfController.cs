using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class SınıfController : Controller
    {
        // GET: Sınıf
        public ActionResult Index()
        {
            using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())


                return View(dbmodel.Sınıf.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Sınıf sınıf)
        {
            try
            {
                using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
                {
                    dbmodel.Sınıf.Add(sınıf);
                    dbmodel.SaveChanges();
                }
            }
            catch
            {
                return View();
            }
            return View();

        }

        public ActionResult Delete(int id)
        {
            using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
            {
                return View(dbmodel.Sınıf.Where(x => x.SınıfID == id).FirstOrDefault());
            }

        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
                {
                    Sınıf sınıf = dbmodel.Sınıf.Where(x => x.SınıfID == id).FirstOrDefault();
                    dbmodel.Sınıf.Remove(sınıf);
                    dbmodel.SaveChanges();
                }

            }
            catch
            {
                return View();
            }
            return View();
        }
    }
}