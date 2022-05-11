using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWithEF.Models
{
    [Table(name:"tblCourse")]
    public class Course
    {
        [Key]
        public int CourseCode { get; set; }

        public string Name { get; set; }
        [DurationValidatorAttribute]
        [Required(ErrorMessage = "Duration is must")]
        public int Duration { get; set; }

        public string Description { get; set; }

        public List<Batch> Batches { get; set; }

    }
}