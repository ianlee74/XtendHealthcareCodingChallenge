using System.Collections.Generic;
using System.Web.Http;
using XtendHealthcare.CodingChallenge.Models;
using XtendHealthcare.CodingChallenge.Repositories;

namespace XtendCodingChallenge.Web.ApiControllers
{
    public class ClientController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Client> Get()
        {
            var repo = new ClientRepository();
            return repo.GetAll();
        }        
    }
}