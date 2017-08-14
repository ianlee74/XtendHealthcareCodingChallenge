using System;
using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge
{
    public abstract class AccountExport
    {
        protected int ClientId { get; }
        protected char Delimiter { get; set; }
        protected string DateFormat { get; set; }
        protected DateTime ExportDate { get; }
        protected FileSplitCriteriaEnum FileSplitCriteria { get; set; }

        protected AccountExport(int clientId)
        {
            ClientId = clientId;
            ExportDate = DateTime.UtcNow;
        }

        protected abstract string CreateFileName();

        protected abstract IEnumerable<string> CreateFieldList(Account account);

        public IEnumerable<AccountExportFile> ExportToFile(string folderPath)
        {
            return null;
        }
    }

    public enum FileSplitCriteriaEnum
    {
        Facility
    }
}
