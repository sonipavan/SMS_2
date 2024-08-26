using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS_2.Models
{
    public class register
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        
        public List<SelectListItem> Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        //[Required]
        public string Address { get; set; }
        [Required]
        public int SelectGenderId { get; set; }

    }
}