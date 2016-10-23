using JAOTT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Volunteer
    {
        public int Id { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public bool Approved { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Joined { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Mission> Missions { get; set; }

        public Volunteer()
        {
            this.Programs = new HashSet<Program>();
            this.Missions = new HashSet<Mission>();
        }

    }
}