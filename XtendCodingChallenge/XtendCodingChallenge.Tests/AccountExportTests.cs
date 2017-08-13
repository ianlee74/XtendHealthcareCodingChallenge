using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XtendCodingChallenge.Tests
{
    [TestClass]
    public class AccountExportTests
    {
        /// <summary>
        /// Export requests are supposed to be logged.
        /// </summary>
        [TestMethod]
        public void ExportHistory_is_recorded()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GeneralHospital wants their exports pipe delimited.
        /// </summary>
        [TestMethod]
        public void GeneralHospital_export_is_pipe_delimited()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GeneralHospital wants all account information exported.
        /// </summary>
        [TestMethod]
        public void GeneralHospital_export_includes_correct_fields()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GeneralHospital wants patient’s name in the format [Last],[First Initial]
        /// </summary>
        [TestMethod]
        public void GeneralHospital_export_patient_name_is_formatted_correctly()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GeneralHospital wants all dates formatted as: MM-DD-YYYY.
        /// </summary>
        [TestMethod]
        public void GeneralHospital_export_date_is_formatted_correctly()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GeneralHospital wants the export file name in the format: yyyymmdd-gh.data.dat.
        /// </summary>
        [TestMethod]
        public void GeneralHospital_export_filename_is_formatted_correctly()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// VeteranHospital wants their file comma-delimited.
        /// </summary>
        [TestMethod]
        public void VeteranHospital_export_is_comma_delimited()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// VeteranHospital wants one export file per facility.
        /// </summary>
        [TestMethod]
        public void VeteranHospital_export_creates_one_file_per_facility()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// VeteranHospital wants the following fields exported: account, insurance, and facility data along with just the patient’s SSN
        /// </summary>
        [TestMethod]
        public void VeteranHospital_export_includes_correct_fields()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void VeteranHospital_export_only_includes_accounts_over_100usd()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// VeteranHospital wants their file name formatted as export-yyyy-mm-dd.[FacilityName].csv
        /// </summary>
        [TestMethod]
        public void VeteranHospital_export_filename_is_formatted_correctly()
        {
            throw new NotImplementedException();
        }
    }
}
