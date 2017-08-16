using System.Collections.Generic;
using XtendHealthcare.CodingChallenge.Interfaces;
using XtendHealthcare.CodingChallenge.Models;

namespace XtendHealthcare.CodingChallenge.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public IEnumerable<Client> GetAll()
        {
            return new[]
            {
                new Client() {Id = 0, Name = "GeneralHospital"},
                new Client() {Id = 1, Name = "VeteranHospital"}
            };
        }
    }
}
