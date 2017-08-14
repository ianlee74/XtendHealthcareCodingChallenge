using System;
using System.Collections.Generic;
using System.Text;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge
{
    public abstract class AccountExporter
    {
        protected int ClientId { get; }
        protected char Delimiter { get; set; }
        protected string DateFormat { get; set; }
        protected DateTime ExportDate { get; }
        protected FileSplitCriteriaEnum FileSplitCriteria { get; set; }

        protected AccountExporter(int clientId)
        {
            ClientId = clientId;
            ExportDate = DateTime.UtcNow;
        }

        protected abstract string CreateFileName(string splitName);

        protected abstract IEnumerable<string> CreateFieldList(Account account);

        public IEnumerable<AccountExportFile> ExportToFile(IEnumerable<Account> accounts, string folderPath)
        {
            var files = new List<AccountExportFile>();

            // TODO: Implement the FileSplitCriteria to split the data into multiple files if requested.
            var splitName = "someFacilityName";

            var fileName = CreateFileName(splitName);
            var fileData = new StringBuilder();
            foreach (var account in accounts)
            {
                var lineData = new StringBuilder();
                foreach (var field in CreateFieldList(account))
                {
                    lineData.Append(field + Delimiter);
                }
                if (lineData.Length != 0)
                {
                    fileData.AppendLine(lineData.ToString());
                }
            }
            var exportFile = new AccountExportFile() {Data = fileData.ToString(), FileName = fileName};
            return new List<AccountExportFile>() {exportFile};
        }
    }

    public enum FileSplitCriteriaEnum
    {
        Facility
    }
}
