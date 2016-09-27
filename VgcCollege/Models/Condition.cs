using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgcCollege.Models
{
    public class Condition
    {
        public int ID { get; set; }
        public string State { get; set; }

        public virtual Book Book { get; set; }
    }
}