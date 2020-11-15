using Data.Models;
using System.Linq;
using System.Collections.Generic;
namespace Web.RequestModels
{
    public class SearchCampingRequestModel
    {
        public string ParkingType { get; set; }
        public float Rating { get; set; }
        public float PricePerDay { get; set; }

        public Facilities facilities { get; set; }

        public List<Location> locations { get; set; }
    }
}
