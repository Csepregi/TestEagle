using InterviewTest.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System;

namespace InterviewTest.Controllers.Home
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BannerTrackingReport()
        {
            // EXERCISE #1 CODE HERE
            BannerRiport bannerRiport = new BannerRiport();
            List<Banner> banner = bannerRiport.Banners.ToList();
            return View(banner);
        }
       
        public ActionResult HotelsWebService()
        {
            // EXERCISE #2 CODE HERE
            HotelService.HotelsSoapClient hotel = new HotelService.HotelsSoapClient();
            hotel.ClientCredentials.UserName.UserName = "aeTraining";
            hotel.ClientCredentials.UserName.Password = "ZZZ";
            hotel.GetHotel(hotel,false, 105304);
      
            return View();
        }

        [HttpGet]
        public ActionResult CustomValidator()
        {
            var model = new Validation();
            return View(model);
        }

        //Common/AtLeastOneRequired class 
        [HttpPost]
        public ActionResult CustomValidatorPost(Validation model) 
        {
            //EXERCISE #3 CODE HERE
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }

        public ActionResult HelperSql()
        {
            return View();
        }
    }
}