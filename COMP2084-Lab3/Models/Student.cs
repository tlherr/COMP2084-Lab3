using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace COMP2084_Lab2.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public String lastName { get; set; }
        public String firstName { get; set; }
        public DateTime enrollmentDate { get; set; }


    }
}