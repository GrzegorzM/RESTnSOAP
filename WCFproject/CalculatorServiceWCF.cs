using System;
using System.ServiceModel;
using WCFproject.Models;

namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorServiceWCF" in both code and config file together.
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)] // Send details about occured exception to the client
    [GlobalErrorHandlerBehavior(typeof(GlobalErrorHandler))]
    public class CalculatorServiceWCF : ICalculatorServiceWCF
    {
        public int Divide(int numerator, int denominator)
        {
            //if (denominator == 0)
            //    throw new FaultException("Denominator cannot be zero", new FaultCode("DividedByZeroFault")); // Throwing .Net exception will result in shutting down communication. Throwing Fault exception will keep communication alive.
            //return numerator / denominator;

            // Strongly typed exception handling
            //try
            //{
            //    return numerator / denominator;
            //}
            //catch(DivideByZeroException ex)
            //{
            //    DivideByZeroFault divideByZeroFault = new DivideByZeroFault();
            //    divideByZeroFault.Error = ex.Message;
            //    divideByZeroFault.Details = "Denominator cannot be zero";

            //    throw new FaultException<DivideByZeroFault>(divideByZeroFault);
            //}

            // Global exception handling
            return numerator / denominator;
        }
    }
}
