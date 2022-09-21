using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class TeacherDersController : Controller
    {
       
        
        // GET: TeacherDers
        AdminLoginEntities2 dbmodel = new AdminLoginEntities2();
       [HttpGet]
        public ActionResult Index()
        {
            var degerler = dbmodel.Ogretmen3.ToList();
            if (degerler != null)
            {
                ViewBag.data = degerler;
            }
            var degerler2 = dbmodel.Ders.ToList();
            if (degerler2 != null)
            {
                ViewBag.data2 = degerler2;
            }
            return View();
        }
       
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            var degerler = dbmodel.Ogretmen3.ToList();
            if (degerler != null)
            {
                ViewBag.data = degerler;
            }
            var degerler2 = dbmodel.Ders.ToList();
            if (degerler2 != null)
            {
                ViewBag.data2 = degerler2;
            }
            String ogretmenq = formCollection["OgretmenAd"];
            String dersq = formCollection["DersAd"];
            Console.WriteLine(ogretmenq);
        
            using (var ctx = new AdminLoginEntities2())
            {
               
                ctx.Database.ExecuteSqlCommand("INSERT INTO dbo.TeacherDers(OgretmenID, DersID) VALUES( "+ogretmenq + "," + dersq + ")");
            }
                return View();

        }
    }
}