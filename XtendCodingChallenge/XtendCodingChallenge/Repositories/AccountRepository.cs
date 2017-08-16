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
            //       Hard coding some data for demonstration purposes.

            var generalHospitalClient = new Client() { Id = 0, Name = "GeneralHospital" };
            var veteranHospitalClient = new Client() { Id = 1, Name = "VeteranHospital" };

            var ghFacility = new Facility() { Id = 0, FacilityName = "GHFacility0" };
            var vhFacility1 = new Facility() { Id = 1, FacilityName = "VHFacility1" };
            var vhFacility2 = new Facility() { Id = 2, FacilityName = "VHFacility2" };

            return new List<Account>
            {
                // Sample GeneralHospital accounts.
                new Account() {Id = 0, Client = generalHospitalClient, AccountNumber = 1000, Balance = 1234.56, Facility = ghFacility, AdminDate = new DateTime(2017, 1, 1), DischargeDate = new DateTime(2017, 1, 2), Patient = new Patient() {Id = 0, FirstName = "John", LastName = "Doe", SocialSecurityNumber = "123456789"}},
                new Account() {Id = 1, Client = generalHospitalClient, AccountNumber = 1001, Balance = 2345.67, Facility = ghFacility, AdminDate = new DateTime(2017, 2, 1), DischargeDate = new DateTime(2017, 2, 2), Patient = new Patient() {Id = 0, FirstName = "Jane", LastName = "Doe", SocialSecurityNumber = "234567890"}},
                new Account() {Id = 2, Client = generalHospitalClient, AccountNumber = 1002, Balance = 345.00, Facility = ghFacility, AdminDate = new DateTime(2017, 3, 1), DischargeDate = new DateTime(2017, 3, 2), Patient = new Patient() {Id = 0, FirstName = "Joseph", LastName = "Smith", SocialSecurityNumber = "345678901"}},

                // Sample VeteranHospital accounts.
                new Account() {Id = 3, Client = veteranHospitalClient, AccountNumber = 2000, Balance = 1234.56, Facility = vhFacility1, AdminDate = new DateTime(2017, 1, 1), DischargeDate = new DateTime(2017, 1, 2), Patient = new Patient() {Id = 0, FirstName = "John", LastName = "Doe", SocialSecurityNumber = "123456789"}},
                new Account() {Id = 4, Client = veteranHospitalClient, AccountNumber = 2001, Balance = 2345.67, Facility = vhFacility1, AdminDate = new DateTime(2017, 2, 1), DischargeDate = new DateTime(2017, 2, 2), Patient = new Patient() {Id = 0, FirstName = "Jane", LastName = "Doe", SocialSecurityNumber = "234567890"}},
                new Account() {Id = 5, Client = veteranHospitalClient, AccountNumber = 2002, Balance = 345.00, Facility = vhFacility2, AdminDate = new DateTime(2017, 3, 1), DischargeDate = new DateTime(2017, 3, 2), Patient = new Patient() {Id = 0, FirstName = "Joseph", LastName = "Smith", SocialSecurityNumber = "345678901"}},
            }.FindAll(a => a.Client.Id == clientId);
        }
    }
}
