using System;
using Data.Models;

namespace Web.RequestModels
{
    public class ClientRequestModelcs
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string CompanyName { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
