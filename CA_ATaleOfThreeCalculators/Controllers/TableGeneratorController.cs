using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA_ATaleOfThreeCalculators.Controllers
{
    public class TableGeneratorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string temperature, string windSpeed)
        {
            double temperatureNum;
            double windSpeedNum;
            List<string> errorMessageText = new List<string>();
            ViewBag.errorMessage = null;

            if (!(double.TryParse(temperature, out temperatureNum)) || !(double.TryParse(windSpeed, out windSpeedNum)))
            {
                errorMessageText.Add("It appears that you did not enter valid numbers.");
                errorMessageText.Add("Please click the Try Again button below to reenter your numbers.");
            }

            ViewBag.errorMessage = errorMessageText;

            return View("DisplayTable");
        }
    }
}