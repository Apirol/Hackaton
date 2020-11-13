using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
   public class Camping
   {
      [Key]
      public Guid Id { get; set; }
      public string Owner { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public string ParkingSize { get; set; }
      public string ParkingType { get; set; }
      public float Rating { get; set; }
      public float PricePerDay { get; set; }
      public Location Loc { get; set; }
      public Uri URL { get; set; }
   }

   public class Facilities
   {
      [Key]
      public Guid Id { get; set; }
      public bool sanitary = false;
      public bool food = false;
      public bool shops = false;
   }

   public class Location
   {
      [Key]
      public string Region { get; set; }
      public string City { get; set; }
      public string Street { get; set; }
      public string House { get; set; }
   }
}
