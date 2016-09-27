using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgcCollege.Models
{
    public class Kind
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public virtual Book Book { get; set; }
    }
}