using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
   public class Client
   {
      [Key]
      public string ID { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Telephone { get; set; }
      public string CompanyName { get; set; }
      public List<Camping> Campings { get; set; }
   }
}
