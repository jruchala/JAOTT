using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        public string School { get; set; }
        public string About { get; set; }
        public bool Approved { get; set; }
        public virtual ICollection<Request> Requests { get; set; }

        public Teacher()
        {
            this.Requests = new HashSet<Request>();
        }

    }
}