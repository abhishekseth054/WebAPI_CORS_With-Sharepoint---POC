using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Test.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Mobile { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}