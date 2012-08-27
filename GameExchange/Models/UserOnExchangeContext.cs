using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameExchange.Models
{
    public class UserOnExchangeContext:DbContext
    {

        public UserOnExchangeContext()
            : base("UserOnExchange")
        {
        }

        public DbSet<UserOnExchange> Entries { set; get; }
    }

}