using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllForClient(int clientId);
    }
}