using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA_ATaleOfThreeCalculators.Controllers
{
    public class FormCalculatorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate(string operation, string operand1, string operand2)
        {
            double operand1Num;
            double operand2Num;
            double answerNum = 0;
            List<string> errorMessageText = new List<string>();
            ViewBag.errorMessage = null;
            ViewBag.answer = null;

            if ((double.TryParse(operand1, out operand1Num)) && (double.TryParse(operand2, out operand2Num)))
            {
                switch (operation)
                {
                    case "add":
                        {
                            answerNum = operand1Num + operand2Num;
                            break;
                        }
                    case "subtract":
                        {
                            answerNum = operand1Num - operand2Num;
                            break;
                        }
                    case "multiply":
                        {
                            answerNum = operand1Num * operand2Num;
                            break;
                        }
                    case "divide":
                        {
                            if (operand2Num != 0)
                            {
                                answerNum = operand1Num / operand2Num;
                            }
                            else
                            {
                                errorMessageText.Add("It appears that you are dividing by zero.");
                                errorMessageText.Add("Please click the Try Again button below to reenter your numbers.");
                            }
                            break;
                        }
                    default:
                        errorMessageText.Add("It appears that you did not enter valid operation.");
                        errorMessageText.Add("Please click the Try Again button below to reenter your numbers.");
                        break;
                }
                ViewBag.answer = answerNum;
            }
            else
            {
                errorMessageText.Add("It appears that you did not enter valid numbers.");
                errorMessageText.Add("Please click the Try Again button below to reenter your numbers.");
            }

            ViewBag.errorMessage = errorMessageText;

            return View();
        }
    }
}