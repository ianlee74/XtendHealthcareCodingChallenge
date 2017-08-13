using System.Runtime.Serialization;

namespace XtendHealthcare.CodingChallenge.Models
{
    [DataContract]
    public class Patient
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string SocialSecurityNumber { get; set; }
    }
}
