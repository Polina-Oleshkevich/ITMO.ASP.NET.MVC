using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItogRating4.Models
{
    public class Bid
    {         // ID заявки
         public virtual int BidId { get; set; }

        //ФИО студента
        public virtual string StudentName { get; set; }

        // Баллы

        public virtual int RatingPointJava { get; set; }
        public virtual int RatingPointCSharp { get; set; }
        public virtual int RatingPointPython { get; set; }
        
        public virtual int RatingPointSum { get { return PointSum(); } }

        public int PointSum()
        {
            int sum = RatingPointJava + RatingPointCSharp + RatingPointPython;
            return sum;
        }




    }
}