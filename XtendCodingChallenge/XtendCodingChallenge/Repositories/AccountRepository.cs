using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtendHealthcare.CodingChallenge.Interfaces;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public IEnumerable<Account> GetAllForClient(int clientId)
        {
            // TODO: insert some Dapper code to get data from a database.
            throw new NotImplementedException();
        }
    }
}
