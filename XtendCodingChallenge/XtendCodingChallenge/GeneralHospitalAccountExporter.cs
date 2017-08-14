using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge
{
    public class GeneralHospitalAccountExporter : AccountExporter
    {
        public GeneralHospitalAccountExporter() : base(0)
        {
            DateFormat = "MM-dd-yyyy";
            Delimiter = '|';
        }

        protected override string CreateFileName(string splitName)
        {
            return $"{ExportDate:yyyyMMdd}-gh.data.dat";
        }

        protected override IEnumerable<string> CreateFieldList(Account account)
        {
            var fieldList = new List<string>
            {
                account.Id.ToString(),
                account.Client.Id.ToString(),
                account.AccountNumber.ToString(),
                account.Balance.ToString("C"),
                account.Facility.Id.ToString(),
                account.AdminDate.ToString(DateFormat),
                account.DischargeDate.ToString(DateFormat),
                $"{account.Patient.LastName}, {account.Patient.FirstName.Substring(0, 1)}"
            };
            return fieldList;
        }
    }
}
