﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF7TEST.Models
{
    public class Dev
    {
        public int DevId { get; set; }
        public string DevName { get; set; }
        public ICollection<Project> Projects { get; set; }

        public Dev()
        {
            Projects = new HashSet<Project>();
        }

        
    }
}