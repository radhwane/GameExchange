using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameExchange.Models
{
    public class UserWantedContext:DbContext
    {
        public UserWantedContext()
            : base("UserWanted")
        {
        }

        public DbSet<UserWanted> Entries { set; get; }
    }
}