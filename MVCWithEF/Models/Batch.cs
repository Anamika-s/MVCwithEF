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
        public int Id { get; set; }
        [Display(Name ="Batch Name")]
        [Column (name:"name", Order =3)]
       
        [Required]
        [StringLength(4, ErrorMessage ="Length shud be 4")]
        public string BatchName { get; set; }
        [Display(Name ="Batch Start Date")]
        [Column("StartingDate" , Order=2)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime StartDate { get; set; }
        
        [Required]     [Display(Name ="Trainer Name")]
        [Column(name:"trainerName")]
[MinLength(10, ErrorMessage ="Min 10 characters needed")]
       [RegularExpression(pattern:"[A-Z a-z]+" , ErrorMessage ="Pattern not correct")]
        public string Trainer { get; set; }
        [Required(ErrorMessage ="Duration is must")]
        public string Duration { get; set; }

        [Required(ErrorMessage ="Password is must")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Password do not match")]
        public string ReTypePasword { get; set; }
    }
}