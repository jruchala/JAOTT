using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int ProgramId { get; set; }
        public string Topic { get; set; }
        public string GradeLevel { get; set; }


        public virtual Teacher teacher { get; set; }
        public virtual Program program { get; set; }



    }
}