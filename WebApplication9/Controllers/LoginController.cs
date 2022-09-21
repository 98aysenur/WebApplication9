using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(WebApplication9.Models.Admin userModel)
        {
            using (AdminLoginEntities2 db = new AdminLoginEntities2())
            {
                
                var userDetails = db.Admin.Where(x => x.AdminAd == userModel.AdminAd && x.Parola == userModel.Parola).FirstOrDefault();
                if(userDetails == null)
                {
                    userModel.LoginErrorMessage = "Kullanıcı adı veya parola hatalı.";

                }
                else
                {
                    Session["AdminID"] = userDetails.AdminID;
                    Session["AdminAd"] = userDetails.AdminAd;
                    return RedirectToAction("Index", "Home");
                }


            }

            return View();
        }
        public ActionResult LogOut()
        {
            int AdminID = (int) Session["AdminID"];
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}