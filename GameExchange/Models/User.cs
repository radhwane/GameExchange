using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameExchange.Models
{
    public class User
    {
        // 11 fields
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public string Signature { get; set; }
        public string Mobile { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
    }
}