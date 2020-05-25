using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Umbraco_MVC.Models
{
    public class Submission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = " First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = " Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Must be 8 digits")]
        [Display(Name = "Valid product serial number")]
        public int SerialNumber { get; set; }
    }
}
