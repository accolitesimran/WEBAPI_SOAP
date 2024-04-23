using System.Runtime.Serialization;

namespace SoapAPI.Models
{
    [DataContract]
    public class Output
    {
        [DataMember]
        public double? Response { get; set; }
        [DataMember]
        public string? ErrorMessage {  get; set; }
    }
}
