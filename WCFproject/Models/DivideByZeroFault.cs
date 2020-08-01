using System.Runtime.Serialization;

namespace WCFproject.Models
{
    [DataContract]
    public class DivideByZeroFault
    {
        [DataMember]
        public string Error { get; set; }

        [DataMember]
        public string Details { get; set; }
    }
}
