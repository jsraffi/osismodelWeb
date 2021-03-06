﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OsisModel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//This model where classes are added to school
namespace OsisModel.Models
{
    [Table("SchoolClasses")]
    public class SchoolClass
    {
        [Key, Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ClassID { get; set; }

        public string ClassName { get; set; }
        
        [ForeignKey("School")]
        public int SchoolRefID { get; set; }

        public int ClassOrder { get; set; }
    
        //THis proeprty is used by Entity Framework for navigating to school model and getting school Name
        // for the front end, school name selecting drop down.
        public virtual School School { get; set; }
        
    }
}