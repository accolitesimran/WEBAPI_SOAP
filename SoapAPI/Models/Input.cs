using System.Runtime.Serialization;

namespace SoapAPI.Models
{
    [DataContract]
    public class Input
    {
        [DataMember]
        public double num1 { get; set; }
        [DataMember]
        public double num2 { get; set; }
    }
}
