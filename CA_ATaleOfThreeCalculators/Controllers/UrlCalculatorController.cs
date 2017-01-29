using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA_ATaleOfThreeCalculators.Controllers
{
    public class UrlCalculatorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(string operand1, string operand2)
        {
            double operand1Num;
            double operand2Num;
            List<string> errorMessageText = new List<string>();
            ViewBag.errorMessage = null;

            if (double.TryParse(operand1, out operand1Num) && double.TryParse(operand2, out operand2Num))
            {
                ViewBag.answer = (operand1 + operand2).ToString();
            }
            else
            {
                errorMessageText.Add("It appears that you did not enter valid operation.");
                errorMessageText.Add("Please click the Try Again button below to reenter your numbers.");
                ViewBag.errorMessage = errorMessageText;
            }

            return View();
        }
    }
}