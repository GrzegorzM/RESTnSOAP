using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace WCFproject.Models
{
    public class GlobalErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error) // Executing asynchronously after ProvideFault method call. Since its called asynchronously it doesn't block clients.
        {
            // Place to implement code for logging an exception

            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if(error is FaultException)
            {
                return;
            }

            FaultException faultException = new FaultException("A general service error occured");
            MessageFault messageFault = faultException.CreateMessageFault();
            fault = Message.CreateMessage(version, messageFault, null);
        }
    }
}
