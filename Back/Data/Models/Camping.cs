﻿using System;
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

      public string ParkingType { get; set; }
      public int ParkingSize { get; set; }

      public float Rating { get; set; }
      public float PricePerDay { get; set; }

      public Uri URL { get; set; }
      public DateTime CreateOn { get; set; }

      public Facilities facilities { get; set; }
      public Location location { get; set; }
      
   }

   public class Facilities
   {
      [Key]
      public Guid Id { get; set; }
      public bool sanitary { get; set; }
      public bool food { get; set; }
      public bool shops { get; set; }
   }

   public class Location
   {
      [Key]
      public Guid Id { get; set; }
      public string Region { get; set; }
      public string City { get; set; }
      public string Street { get; set; }
      public string House { get; set; }
   }
}
