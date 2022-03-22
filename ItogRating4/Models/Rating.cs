using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItogRating4.Models
{
    public class Rating
    { // ID кредита
      public virtual int RatingId { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}