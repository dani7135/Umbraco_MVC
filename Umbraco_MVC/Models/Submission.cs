using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Umbraco_MVC.Services;
using System.ComponentModel;

namespace Umbraco_MVC.Models
{
    public class Submission
    {//Busssines logikken skal ligge i model og validationen af den logisk ligger i services
        [Key]
        public int Id { get; set; }
        [AgeServices(18)]
        [DisplayName("Birthday")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public int Age { get; set; }
        [Required]
        [Display(Name = " First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = " Last Name")]
        public string LastName { get; set; }
        [Required] 
        [EmailAddress]
        public string Email { get; set; }
      //  [Required]
        [Range(10000000, 99999999, ErrorMessage = "Must be 8 digits")]
        [Display(Name = "Valid product serial number")]//Collection<SerialNumber>
        public int SerialNumber { get; set; }
    }
}
