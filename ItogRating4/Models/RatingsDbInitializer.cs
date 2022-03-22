using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ItogRating4.Models
{
    public class RatingsDbInitializer : DropCreateDatabaseIfModelChanges<RatingContext>
    {
        protected override void Seed(RatingContext context)
        {
            context.Ratings.Add(new Rating { Name = "Иванов И.И.", Age = 35, Phone = 188981444, Email = "hckgc@hh.ru" });
            context.Ratings.Add(new Rating { Name = "Новиков О.Д.", Age = 28, Phone = 665543333, Email = "gdhgc@hh.ru" });
            context.Ratings.Add(new Rating { Name = "Нилов У.Д.", Age = 29, Phone = 55543333, Email = "gfgf@hh.ru" });
            context.Ratings.Add(new Rating { Name = "Добров А.К.", Age = 37, Phone = 5554553, Email = "gfggf@hh.ru" });

            base.Seed(context);
        } 
  
    }
}