using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge.Interfaces
{
    public interface IExportHistoryRepository
    {
        void Add(ExportHistory exportHistory);
        IEnumerable<ExportHistory> GetAll();
    }
}
