using System;
using System.Runtime.Serialization;

namespace XtendHealthcare.CodingChallenge.Models
{
    [DataContract]
    public class ExportHistory
    {
        [DataMember]
        public int ClientId { get; set; }
        
        [DataMember]
        public DateTime ExportDate { get; set; }

        [DataMember]
        public string ExportedBy{ get; set; }
    }
}
