using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Umbraco_MVC.Models
{
    public class SerialNumber
    {//Busssines logikken skal ligge i model og validationen af den logisk ligger i services
        [Key]
        public int KeyId { get; set; }

        public string KeyCode { get; set; }

        public int NumberOfUses { get; set; }

        public bool Validity { get; set; } = true;
        public Submission Submission { get; set; }
    }
}
