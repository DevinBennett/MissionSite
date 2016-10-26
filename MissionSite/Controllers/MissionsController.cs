using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MissionFAQ(String mission)
        {
            ViewBag.missionLink = mission;
            
            switch (mission)
            {
                case "Korea":
                    ViewBag.mission = "Korea Seoul Mission";
                    ViewBag.presName = " President Brent Christiansen";
                    ViewBag.missionAddress = "Jongno-Gu";
                    ViewBag.language = "Korean";
                    ViewBag.climate = "Temperate";
                    ViewBag.domReligion = "Buddhist";
                    ViewBag.image = "Korea.gif";
                    
                    break;
                case "Philippines":
                      ViewBag.mission = "Philippines Olangapo Mission";
                    ViewBag.presName = "President Roberto Querido";
                    ViewBag.missionAddress = "Somewhere in the Philippines";
                    ViewBag.language = "Tagalog";
                    ViewBag.climate = "Tropical";
                    ViewBag.domReligion = "Catholicism";
                    ViewBag.image = "Philippines.gif";
                    
                    break;

                case "Houston":
                    ViewBag.mission = "Texas Houston";
                    ViewBag.presName = "President James Harden";
                    ViewBag.missionAddress = "Somewhere in Houston";
                    ViewBag.language = "English,Spanish, and many other languages";
                    ViewBag.climate = "Humid";
                    ViewBag.domReligion = "Southern Baptist";
                    ViewBag.image = "Houston.jpg";

                    break;
            }

            return View();
        }

    }
}