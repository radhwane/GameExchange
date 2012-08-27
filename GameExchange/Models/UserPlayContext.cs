using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameExchange.Models
{
    public class UserPlayContext:DbContext
    {

        public UserPlayContext()
            : base("UserPlay")
        {
        }

        public DbSet<UserPlay> Entries { set; get; }
    }


}