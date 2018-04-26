using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedMe.Models
{
    public class Outlet
    {

        public int OutletID { get; set; }
        public string Name { get; set; }
        public int ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public int LocationID { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}