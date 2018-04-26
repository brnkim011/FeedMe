using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedMe.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Outlet> Outlets { get; set; }
    }
}