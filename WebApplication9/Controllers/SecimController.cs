using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
using WebApplication9.ModelView;

namespace WebApplication9.Controllers
{
    public class SecimController : Controller
    {
        // GET: Main
        AdminLoginEntities2 dbmodel = new AdminLoginEntities2();
        [HttpGet]
        public ActionResult Index()
        {
      
           
            var degerler = dbmodel.TeacherDers.Select(x => new TeacherDersListClass
            {
                TeacherDersID = x.TeacherDersID,
                DersId = x.DersID,
                DersAdi = x.Ders.DersAd,
                OgretmenAdi = x.Ogretmen3.OgretmenAd,
                OgretmenID = x.OgretmenID
            }).ToList();
          
            if (degerler != null)
            {

                ViewBag.Ogretmen = degerler;
            }

            var degerler2 = dbmodel.Ders.ToList();
            if (degerler2 != null)
            {
                ViewBag.Dersler = degerler2;
            }
            var degerler3 = dbmodel.Ogrenci.ToList();
            if (degerler3 != null)
            {
                ViewBag.Ogrenci = degerler3;
            }
            return View();
        }
     

        [HttpPost]
        public JsonResult a_method(string data1,string data2,string data3)
        {

            using (var ctx = new AdminLoginEntities2())
            {
                ctx.Database.ExecuteSqlCommand("INSERT INTO dbo.Secim(OgrenciID, OgretmenID, DersID) VALUES( " + data2 + "," + data1 + "," + data3 + ")");


            }
            TempData["Success"] = "Ders Seçiminiz Başarılı!";

            return Json(JsonRequestBehavior.AllowGet);
        }
        

}
}