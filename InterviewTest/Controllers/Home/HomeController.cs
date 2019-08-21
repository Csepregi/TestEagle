using InterviewTest.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

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
            return View();
        }

        [HttpGet]
        public ActionResult CustomValidator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomValidatorPost()
        {
            //EXERCISE #3 CODE HERE
            return View();
        }

        public ActionResult HelperSql()
        {
            return View();
        }
    }
}