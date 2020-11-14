using System;
using Data.Models;

namespace Web.RequestModels
{
    public class CampingRequestModel
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ParkingType { get; set; }
        public int ParkingSize { get; set; }

        public float Rating { get; set; }
        public float PricePerDay { get; set; }

        public Uri URL { get; set; }
        public Guid Id { get; set; }

        public Facilities facilities { get; set; }

        public Location location { get; set; }
    }
}
