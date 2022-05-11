using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWithEF.Models
{
    //[Table(name:"tblBatch")]
    public class Batch
    {
        public int BatchId { get; set; }
        [Display(Name ="Batch Name")]
        [Column (name:"name", Order =3)]
       
        [Required]
        [StringLength(4, ErrorMessage ="Length shud be 4")]
        public string BatchName { get; set; }
        [Display(Name ="Batch Start Date")]
        [Column("StartingDate" , Order=2)]
        [BatchStartDateAttribute]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime StartDate { get; set; }
        
        [Required]    
        [Display(Name ="Trainer Name")]
        [Column(name:"trainerName")]
[MinLength(10, ErrorMessage ="Min 10 characters needed")]
       [RegularExpression(pattern:"[A-Z a-z]+" , ErrorMessage ="Pattern not correct")]
        public string Trainer { get; set; }
        //[Required(ErrorMessage ="Duration is must")]
        //public string Duration { get; set; }

        [Required(ErrorMessage ="Password is must")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
        [NotMapped]
        [Compare("Password", ErrorMessage ="Password do not match")]
        public string ReTypePasword { get; set; }

        // FKey
        public int CourseCode { get; set; }
        public Course Course { get; set; }

        // 
        public List<Student> Students { get; set; }
    }
}