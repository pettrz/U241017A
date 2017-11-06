using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U241017A.Data;

namespace U241017A.Data.Controllers
{
    public class HomeController : Controller
    {
        Repository _repo = Repository.GetRepo;

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }

        public ActionResult currentbookings()
        {
            return View(_repo.Products);
        }

        [HttpGet]
        public ActionResult book()
        {
            return View();
        }

        [HttpPost]
        public ActionResult book(Product p)
        {
            _repo.Add(p);
            return RedirectToAction("currentbookings");
        }

        public ActionResult RemoveProduct(int id)
        {
            _repo.Remove(id);

            return RedirectToAction("currentbookings");
        }

    }
}