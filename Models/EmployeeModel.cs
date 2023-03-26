using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using EmployeeProjectEx.CustomValidation;
namespace EmployeeProjectEx.Models
{
    public class EmployeeModel
    {
        [Key]
        [ValidateNever]
        public int Id { get; set; }

        [Required(ErrorMessage ="plz enter employee name")]
        [StringLength(100,ErrorMessage ="name must be less than 100")]
        //[Compare("Title")]
        public string? Name { get; set; }

        [StringLength(4000, ErrorMessage = "Description must be less than 4000")]
        public string? Description { get; set; }

        [Required(ErrorMessage ="plz enter Title")]
        [StringLength(80, ErrorMessage = "Title must be less than 100")]
        public string? Title { get; set; }

        [Required(ErrorMessage ="plz enter email ")]
        [EmailAddress(ErrorMessage ="plz enter valid email")]
        [StringLength(100, ErrorMessage = "Email must be less than 100")]
        [Remote(action:"VerfyEmail",controller:"Employees", ErrorMessage ="email found")]
        [ValidateEmail("gmial",ErrorMessage ="u must use gmail")]
        public string? Email { get; set; }

        public string? ImgeName { get; set; }
        public string? Department { get;}
    }
}
