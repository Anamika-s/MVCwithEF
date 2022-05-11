using MVCWithEF.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEF.Models
{
    public class DurationValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {

                int? duration = (int)value;
                if (duration.HasValue)
                {
                    if (duration > 2 && duration <= 10)
                        return ValidationResult.Success;
                }
            }
                        return new ValidationResult(ErrorMessage ?? "Duration should be in range 2 to 10");
                }
            
       
            }
       
    public class BatchStartDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime dt = (DateTime)value;
                if (dt != null)
                {
                    if (dt >= DateTime.UtcNow)
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return new ValidationResult(ErrorMessage ?? "Make sure your Batch Start date is >= than today");
        }


    }

//    public class SchoolDBInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
//{
//    protected override void Seed(AppDbContext context)
//    {
//        IList<Course> defaultStandards = new List<Course>();

//        defaultStandards.Add(new Course() {  = "Standard 1", Description = "First Standard" });
//        defaultStandards.Add(new Standard() { StandardName = "Standard 2", Description = "Second Standard" });
//        defaultStandards.Add(new Standard() { StandardName = "Standard 3", Description = "Third Standard" });

//        context.Standards.AddRange(defaultStandards);

//        base.Seed(context);
//    }
//}

}
     