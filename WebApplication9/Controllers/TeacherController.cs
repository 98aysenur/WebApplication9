using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())


                return View(dbmodel.Ogretmen3.ToList());
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teacher/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        public ActionResult Create(Ogretmen3 ogretmen)
        {
            try
            {
                using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
                {
                    dbmodel.Ogretmen3.Add(ogretmen);
                    dbmodel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
         
        }

        
        // GET: Teacher/Delete/5
        public ActionResult Delete(int id)
        {
            using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
            {
                return View(dbmodel.Ogretmen3.Where(x => x.OgretmenID == id).FirstOrDefault());
            }
        }

        // POST: Teacher/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (AdminLoginEntities2 dbmodel = new AdminLoginEntities2())
                {
                    Ogretmen3 ogretmen3 = dbmodel.Ogretmen3.Where(x => x.OgretmenID == id).FirstOrDefault();
                    dbmodel.Ogretmen3.Remove(ogretmen3);
                    dbmodel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet] 
        public ActionResult listele()
        {
            return View("Index");
        }
    }
}
