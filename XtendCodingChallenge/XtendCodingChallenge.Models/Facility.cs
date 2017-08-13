using System.Runtime.Serialization;

namespace XtendHealthcare.CodingChallenge.Models
{
    [DataContract]
    public class Facility
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FacilityName { get; set; }

        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }
    }
}
