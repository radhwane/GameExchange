using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameExchange.Models
{
    public class GameContext: DbContext
    {
        // First is the database table name
        // Contructor

        public GameContext(): base ("Game")
        {          
        }

        // Second is the data set POJO object
        public DbSet<Game> Entries { get; set; }

    }
}