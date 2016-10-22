﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JAOTT.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public bool Approved { get; set; }
        public DateTime Joined { get; set; }



    }
}