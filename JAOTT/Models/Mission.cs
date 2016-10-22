using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public virtual Volunteer volunteer { get; set; }
        public int VolunteerId { get; set; }
        public DateTime StartTime { get; set; }
        
    }
}