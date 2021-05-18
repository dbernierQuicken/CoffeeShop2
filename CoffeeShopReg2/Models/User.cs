using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopReg2.Models {

   public class User {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Email { get; set; }
      public string Password { get; set; }
      public int Age { get; set; }
      public string Telephone { get; set; }
      public DateTime DateRegistered { get; set; }

      public static DateTime todaysDate() {
         return DateTime.Now;
      }
   }
}