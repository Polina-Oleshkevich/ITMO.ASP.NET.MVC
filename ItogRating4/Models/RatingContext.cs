using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ItogRating4.Models
{
    public class RatingContext : DbContext
    {
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Bid> Bids { get; set; }

     
    }
}