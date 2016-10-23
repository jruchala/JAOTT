using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public int RequestId { get; set; }

        [Display(Name ="Volunteer")]
        public int VolunteerId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }

        public string About { get; set; }

        public virtual Request request { get; set; }
        public virtual Volunteer volunteer { get; set; }


    }
}