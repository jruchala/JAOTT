using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Topic { get; set; }

        public int Duration { get; set; }
        public bool PrepTime { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }
        public Program()
        {
            this.Volunteers = new HashSet<Volunteer>();
            this.Requests = new HashSet<Request>();
        }
    }
}