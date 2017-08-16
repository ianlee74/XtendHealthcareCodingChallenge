using System.Collections.Generic;
using System.Web.Http;
using XtendHealthcare.CodingChallenge;
using XtendHealthcare.CodingChallenge.Models;
using XtendHealthcare.CodingChallenge.Repositories;

namespace XtendCodingChallenge.Web.ApiControllers
{
    public class AccountController : ApiController
    {
        // GET api/<controller>/exportfiles?clientId=0
        public IEnumerable<AccountExportFile> GetExportFiles(int clientId)
        {
            var exporter = new GeneralHospitalAccountExporter();
            var repo = new AccountRepository();
            return exporter.ExportToFile(repo.GetAllForClient(0), null);
        }
    }
}