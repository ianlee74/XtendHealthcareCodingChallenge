using System;
using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge
{
    public class GeneralHospitalAccountExport : AccountExport
    {
        public GeneralHospitalAccountExport() : base(0)
        {
            DateFormat = "MM-dd-yyyy";
            Delimiter = '|';
        }

        protected override string CreateFileName()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<string> CreateFieldList(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
