using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithEF.Models
{
    public class Student
    {
        
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int batchId { get; set; }
        public Batch Batch { get; set; }
    }
}