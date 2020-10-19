using System.Collections.Generic;
using System.ServiceModel;

namespace WCFproject
{
    //[ServiceContract]

    //Service contract does not support bindings that initiate sessions.
    //[ServiceContract(SessionMode = SessionMode.NotAllowed)]

    //Service contract requires a binding that supports session. Exception is thrown if the binding does not support sessions.
    //[ServiceContract(SessionMode = SessionMode.Required)]
    
    //Service contract supports sessions if the binding supports them.
    //[ServiceContract(SessionMode = SessionMode.Allowed)]

    [ServiceContract(CallbackContract = typeof(ISimpleServiceCallback))]
    public interface ISimpleService
    {
        [OperationContract]
        int IncrementNumber();

        [OperationContract]
        void DisplaySessionId();

        [OperationContract]
        List<int> GetEvenNumbers();

        [OperationContract]
        List<int> GetOddNumbers();

        //[OperationContract] Works with Reentrand InstanceContextMode
        [OperationContract(IsOneWay = true)] //Works with Single InstanceContextMode
        void ProgressReport();
    }
}