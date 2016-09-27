using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgcCollege.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Year { get; set; }
        public int KindID { get; set; }
        public int ConditionID { get; set; }
        public int NumberInStock { get; set; }
        public double Price { get; set; }


        public virtual Kind Kind { get; set; }
        public virtual Condition Condition { get; set; }
    }
}