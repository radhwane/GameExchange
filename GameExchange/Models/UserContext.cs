using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameExchange.Models
{
    public class UserContext: DbContext
    {

        // contructor and table name
        public UserContext(): base("User")
        {
        }

        public DbSet<User> Entries { set; get; }

    }
}