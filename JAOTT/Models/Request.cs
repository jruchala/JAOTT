using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Request
    {
        public int Id { get; set; }

        [Display(Name="Teacher")]
        public int TeacherId { get; set; }

        [Display(Name ="Program")]
        public int ProgramId { get; set; }
        public string Topic { get; set; }

        [Display(Name = "Grade Level")]
        public string GradeLevel { get; set; }


        public virtual Teacher teacher { get; set; }
        public virtual Program program { get; set; }



    }
}