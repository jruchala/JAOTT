using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Approved { get; set; }
        public List<Request> Requests { get; set; }

    }
}