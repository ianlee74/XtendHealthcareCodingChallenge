using System;
using XtendHealthcare.CodingChallenge.Interfaces;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge
{
    public class Exporter
    {
        private IAccountRepository _accountRepository;
        private IExportHistoryRepository _exportHistoryRepository;

        public Exporter(IAccountRepository accountRepository, IExportHistoryRepository exportHistoryRepository)
        {
            _accountRepository = accountRepository;
            _exportHistoryRepository = exportHistoryRepository;
        }

        public void ExportAccountsToFile(int clientId, string folderPath)
        {
            // Get account data.

            // Export data to a file.
            AccountExport exporter = null;
            switch (clientId)
            {
                case 0:     // GeneralHospital
                    exporter = new GeneralHospitalAccountExport();
                    break;
                case 1:     // VeteranHospital
                    //exporter = new VeteranHospitalAccountExport();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            exporter?.ExportToFile(folderPath);

            // Log the export.
            _exportHistoryRepository.Add(new ExportHistory(){ClientId = clientId, ExportDate = DateTime.UtcNow, ExportedBy = "someUser"});
        }
    }
}
