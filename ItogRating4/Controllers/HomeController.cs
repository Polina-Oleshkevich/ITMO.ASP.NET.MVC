using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItogRating4.Models;
using System.Data.Entity;
using System.Collections;

namespace ItogRating4.Controllers
{
    public class HomeController : Controller
    {
        private RatingContext db = new RatingContext();
        public ActionResult Index()
        {
            GiveStudents();


            return View();
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
        private void GiveStudents()
        {
            var allRatings = db.Ratings.ToList<Rating>();
            ViewBag.Ratings = allRatings;
        }

        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveStudents();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Студент успешно добавлен";
        }
        public ActionResult BidSearch(string studentname)
        {
            var allBids = db.Bids.Where(a => a.StudentName.Contains(studentname)).ToList();
            if (allBids.Count == 0)
            {
                return Content("Указанный студент " + studentname + " не найден");
                //return HttpNotFound();
            }
            return PartialView(allBids);
        }



        
}
}