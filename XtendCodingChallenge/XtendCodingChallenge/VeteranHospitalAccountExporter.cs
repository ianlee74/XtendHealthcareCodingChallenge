using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge
{
    public class VeteranHospitalAccountExporter : AccountExporter
    {
        public VeteranHospitalAccountExporter() : base(0)
        {
            DateFormat = "MM-dd-yyyy";
            Delimiter = ',';
        }

        protected override string CreateFileName(string splitName)
        {
            return $"{ExportDate:yyyyMMdd}-gh.data.dat";
        }

        protected override IEnumerable<string> CreateFieldList(Account account)
        {
            // Only export accounts where the balance is > $100.00.
            if (account.Balance <= 100.00) return null;

            var fieldList = new List<string>
            {
                account.Id.ToString(),
                account.Client.Id.ToString(),
                account.AccountNumber.ToString(),
                account.Balance.ToString("C"),
                account.Facility.Id.ToString(),
                account.AdminDate.ToString(DateFormat),
                account.DischargeDate.ToString(DateFormat),
                account.Patient.SocialSecurityNumber,
            };
            return fieldList;
        }
    }
}
