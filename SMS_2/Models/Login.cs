using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS_2.Models
{
    public class Login
    {
        public int id { get; set; }
        
        [Required]
        [StringLength(10)]
        [Display(Name="Enter Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name="Enter Password")]
        public string Password { get; set; }       

    }
}