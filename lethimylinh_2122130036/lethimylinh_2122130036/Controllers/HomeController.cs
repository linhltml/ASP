using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lethimylinh_2122130036.Context;
using lethimylinh_2122130036.Models;

namespace lethimylinh_2122130036.Controllers
{
    public class HomeController : Controller
    {
        BanHangEntities objBanHangEntities = new BanHangEntities();
        public ActionResult Index()
        {

            HomeModel objHomeModel = new HomeModel();
            objHomeModel.listCategory = objBanHangEntities.Categories.ToList();

            objHomeModel.listProduct = objBanHangEntities.Products.ToList();
            return View(objHomeModel);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}