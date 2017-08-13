using System.Runtime.Serialization;

namespace XtendHealthcare.CodingChallenge.Models
{
    [DataContract]
    public class Insurance
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string PlanName { get; set; }

        [DataMember]
        public string Policy { get; set; }

        [DataMember]
        public string GroupNumber { get; set; }
    }
}
