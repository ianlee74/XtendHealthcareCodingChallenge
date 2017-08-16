using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();
    }
}
