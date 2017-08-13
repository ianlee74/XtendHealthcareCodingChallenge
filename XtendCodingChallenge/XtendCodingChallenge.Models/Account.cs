using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace XtendHealthcare.CodingChallenge.Models
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Client Client { get; set; }

        [DataMember]
        public int AccountNumber { get; set; }

        [DataMember]
        public Patient Patient { get; set; }        // adding this because of the assumed relationship of AccountNumber -> Patient.Id

        [DataMember]
        public double Balance { get; set; }

        [DataMember]
        public Facility Facility { get; set; }

        [DataMember]
        public DateTime AdminDate { get; set; }

        [DataMember]
        public DateTime DischargeDate { get; set; }

        [DataMember]
        public IEnumerable<Insurance> Insurance { get; set; }
    }
}
