using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesStoreFE.ServiceReference1;

namespace ShoesStoreFE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Service1Client o = new Service1Client();
            List<tbl_Stores> li =  o.GetStores().ToList();
            List<tbl_Articles> li2 = o.GetArticles().ToList();

            ViewBag.Stores.List = li;
            ViewBag.Articles.List = li2;
            return View();
        }

        public ActionResult AddStore(tbl_Stores sobj)
        {
            return View();
        }

       
    }
}