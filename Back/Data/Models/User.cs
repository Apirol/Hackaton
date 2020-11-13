using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
   public class User
   {
      [Key]
      public Guid Id { get; set; }
   }
}
