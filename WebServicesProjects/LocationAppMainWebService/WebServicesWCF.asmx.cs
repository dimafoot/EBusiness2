﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using LocationAppMainWebService.ServiceReference1;
using LocationAppMainWebService.ServiceReference2;
using Microsoft.Maps.MapControl.WPF;

namespace LocationAppMainWebService
{
    /// <summary>
    /// Description résumée de WebServicesWCF
    /// </summary>
    [WebService(Namespace = "http://52.24.191.228/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [System.Web.Script.Services.ScriptService]
    public class WebServicesWCF : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public int Add(int firstNumber, int secondNumber)
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.Add(firstNumber, secondNumber);
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculationsList()
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.GetCalculations().ToList();
        }

        [WebMethod(EnableSession = true)]
        public Location GetRandomLocation()
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.GetRadomLocation();
        }

        [WebMethod(EnableSession = true)]
        public Location SetTrainLocation(string ip,string latitude, string longitude,string altitude)
        {
            //string ipAddress = Context.Request.UserHostAddress;
            var ipAddress = HttpContext.Current.Request.UserHostAddress;

            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.SetTrainLocation(ipAddress, latitude,longitude,altitude);
        }

        [WebMethod(EnableSession = true)]
        public Location SetUserLocation()
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.SetUserLocationByIp(HttpContext.Current.Request.UserHostAddress);
        }


        [WebMethod(EnableSession = true)]
        public List<Location> GetLocations()
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.GetTrainLocations().ToList();
        }

        [WebMethod(EnableSession = true)]
        [XmlInclude(typeof(PartTimeEmployee)), XmlInclude(typeof(FullTimeEmployee))]
        public Employee SetDummyEmployeeMongoDB()
        {
            ServiceReference2.IEmployeeService client = new EmployeeServiceClient();
            return client.SaveDummyEmployee();
        }

        [WebMethod(EnableSession = true)]
        [XmlInclude(typeof(PartTimeEmployee)), XmlInclude(typeof(FullTimeEmployee))]
        public List<Employee> GetDummyEmployeesMongoDB()
        {
            ServiceReference2.IEmployeeService client = new EmployeeServiceClient();
            return client.GetDummyEmployees().ToList();
        }


        //[WebMethod(EnableSession = true)]
        //[XmlInclude(typeof(PartTimeEmployee)), XmlInclude(typeof(FullTimeEmployee))]
        //public Employee GetEmployeeById(int id)
        //{
        //    ServiceReference2.IEmployeeService client = new EmployeeServiceClient();
        //    return client.GetEmployeeById(id);
        //}


        [WebMethod(EnableSession = true)]
        [XmlInclude(typeof(PartTimeEmployee)), XmlInclude(typeof(FullTimeEmployee))]
        public List<Employee> GetEmployeeById(int id)
        {
            ServiceReference2.IEmployeeService client = new EmployeeServiceClient();
            return client.GetEmployeeById(id).ToList();
        }



    }
}
