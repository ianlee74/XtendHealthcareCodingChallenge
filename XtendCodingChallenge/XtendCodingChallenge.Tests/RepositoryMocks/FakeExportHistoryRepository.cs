using System.Collections;
using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Interfaces;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendCodingChallenge.Tests.RepositoryMocks
{
    public class FakeExportHistoryRepository : IExportHistoryRepository
    {
        private readonly List<ExportHistory> _history = new List<ExportHistory>();

        public void Add(ExportHistory exportHistory)
        {
            _history.Add(exportHistory);
        }

        public IEnumerable<ExportHistory> GetAll()
        {
            return _history;
        }
    }
}
