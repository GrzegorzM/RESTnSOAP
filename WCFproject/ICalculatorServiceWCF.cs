using System.ServiceModel;

namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorServiceWCF
    {
        [OperationContract]
        int Divide(int numerator, int denominator);
    }
}
