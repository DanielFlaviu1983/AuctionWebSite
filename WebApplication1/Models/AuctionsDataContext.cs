using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class AuctionsDataContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        static AuctionsDataContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AuctionsDataContext>());
        }
    }
}