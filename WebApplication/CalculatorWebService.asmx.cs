﻿using System.Collections.Generic;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")] // Can be any string but its common to give it internet domain name. Uniquely identify webservice form other webservices which are already on the web.
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)] // Default
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod] // Client wont see method without this decorator
        public string HelloWorld()
        {
            return "Hello World";
        }

        // To use sessions we need include
        //<binding name="CalculatorWebServiceSoap" allowCookies="true">
        //in client appliaction web.config file.
        [WebMethod(EnableSession = true, Description = "This method adds two numbers", CacheDuration = 20)] // Cache dont allow executing this method with same parameters as in previous request and return cached value instead.
        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculations;

            if(Session["calculations"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["calculations"];
            }

            string strRecentCalculation = $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}";
            calculations.Add(strRecentCalculation);
            Session["calculations"] = calculations;

            return firstNumber + secondNumber;
        }

        [WebMethod(MessageName = "AddThreeNumbers")] // After overloading method we need to specify MessageName property to distinguish Add methods.
        public int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if(Session["calculations"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You do not performed any calculations");

                return calculations;
            }
            else
            {
                return (List<string>)Session["calculations"];
            }
        }
    }
}
