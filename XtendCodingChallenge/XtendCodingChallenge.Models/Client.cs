using System.Runtime.Serialization;

namespace XtendHealthcare.CodingChallenge.Models
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
