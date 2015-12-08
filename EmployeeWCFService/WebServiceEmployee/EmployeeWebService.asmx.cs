using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Services;
using Microsoft.Maps.MapControl.WPF;

namespace WebServiceEmployee
{
    /// <summary>
    /// Description résumée de EmployeeWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    //[System.Web.Script.Services.ScriptService]
    public class EmployeeWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Employee GentEmployeeDb(int id)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            Employee employee = new Employee();

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter("@Id", id);
                cmd.Parameters.Add(parameterId);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employee = new Employee
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        Dateofb = Convert.ToDateTime(reader["Dateofb"])
                    };
                }
            }
            return employee;
        }


        #region random with session

        [WebMethod(EnableSession = true, Description = "This method return a random number", CacheDuration = 20)]
        public int GetRadomNumber()
        {
            List<string> calculations;
            if (Session["RANDOMS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["RANDOMS"];
            }

            Random r = new Random();
            int result = r.Next(1, 1000);

            string strRecentCalculation = " Random :" + DateTime.Now + " is " + result.ToString();

            calculations.Add(strRecentCalculation);
            Session["RANDOMS"] = calculations;

            return result;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetRandoms()
        {
            if (Session["RANDOMS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any ramdom number");
                return calculations;
            }
            else
            {
                return (List<string>)Session["RANDOMS"];
            }
        }

        #endregion




        [WebMethod(EnableSession = true, Description = "This method Set Train Location", CacheDuration = 20)]
        public void SetTrainLocation(double latitude, double longitude)
        {
            List<Location> locations;
            if (Session["LOCATIONS"] == null)
            {
                locations = new List<Location>();
            }
            else
            {
                locations = (List<Location>)Session["LOCATIONS"];
            }

            var location = new Location(Convert.ToDouble(latitude), Convert.ToDouble(longitude));

            locations.Add(location);
            Session["LOCATIONS"] = locations;
        }

        [WebMethod(EnableSession = true, Description = "GetTrainLocations methode")]
        public List<Location> GetTrainLocations()
        {
            if (Session["LOCATIONS"] == null)
            {
                List<Location> locations = new List<Location>();
                locations.Add(new Location(0,0));
                return locations;
            }
            else
            {
                return (List<Location>)Session["LOCATIONS"];
            }
        }



        [WebMethod(EnableSession = true, Description = "This method return a GetRadom Location", CacheDuration = 20)]
        public Location GetRadomLocation()
        {
            Random r = new Random();
            string lat = r.Next(1, 50) + "." + r.Next(10000, 10500);
            string log = r.Next(1, 15) + "." + r.Next(40000, 40500);

            return new Location(Convert.ToDouble(lat), Convert.ToDouble(log));
        }


    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Dateofb { get; set; }

    }
}
