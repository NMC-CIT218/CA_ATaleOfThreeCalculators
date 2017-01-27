using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA_ATaleOfThreeCalculators.Controllers
{
    public class UrlCalculatorController : Controller
    {
        // GET: UrlCalculator
        public ActionResult Add(double operand1, double operand2)
        {
            if (operand1 != null && operand2 != null)
            {
                ViewBag.answer = (operand1 + operand2).ToString();
            }
            else
            {
                ViewBag.errorMessage = "You did not enter valid numbers.";
            }

            return View();
        }
    }
}