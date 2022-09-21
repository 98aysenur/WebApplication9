using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())


                return View(dbmodel.Ogrenci.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Ogrenci ogrenci)
        {
            try
            {
                using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
                {
                    dbmodel.Ogrenci.Add(ogrenci);
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
                return View(dbmodel.Ogrenci.Where(x => x.OgrenciID == id).FirstOrDefault());
            }

        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
                {
                    Ogrenci ogrenci = dbmodel.Ogrenci.Where(x => x.OgrenciID == id).FirstOrDefault();
                    dbmodel.Ogrenci.Remove(ogrenci);
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