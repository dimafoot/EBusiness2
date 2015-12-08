using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesProjects
{
    /// <summary>
    /// Description résumée de WebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [System.Web.Script.Services.ScriptService]

    public class WebServices : System.Web.Services.WebService
    {


        [WebMethod(EnableSession = true)]
        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculations;

            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }
            string strTransaction = firstNumber.ToString() + " + "
                + secondNumber.ToString()
                + " = " + (firstNumber + secondNumber).ToString();
            calculations.Add(strTransaction);
            Session["CALCULATIONS"] = calculations;

            return firstNumber + secondNumber;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }
        }


        [WebMethod(EnableSession = true)]
        public static List<string> GetCalculationsList()
        {
            if (HttpContext.Current.Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)HttpContext.Current.Session["CALCULATIONS"];
            }

        }


    }
}
