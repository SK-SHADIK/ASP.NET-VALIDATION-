using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VALIDATION.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Please provide user name")]
        [StringLength(20, ErrorMessage = "User name must not exceed 20")]
        [RegularExpression("^[a-zA-Z+\\.+\\-+\\ ]+$", ErrorMessage = "User name is not contains any charecter like @,#,% etc. only takes letter and . or -")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide id")]
        [RegularExpression("^[0-9]{2}?[-]{1}?[0-9-]{5}?[-]{1}?[0-9]{1}$", ErrorMessage = "Please provide id correctly (like 11-11111-1)")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Please provide email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please provide email correct formet (like abc@gmail.com)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide email")]
        [RegularExpression("^[0-9]{2}?[-]{1}?[0-9-]{5}?[-]{1}?[0-9]{1}?@student.aiub.edu$", ErrorMessage = "Please provide email correctly (like 11-11111-1@student.aiub.edu)")]
        public string Emailb { get; set; }

        [Required(ErrorMessage = "Please provide date of birth")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Please provide date of birth mm/dd/yyyy (like 12/15/1999)")]

        public string Dob { get; set; }

        [Required(ErrorMessage = "Please provide age")]
        [Range(18, 60, ErrorMessage = "Please provide age thats minmum 18 and maximum 60")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Please provide phone number")]
        [StringLength(14, ErrorMessage = "Please check phone number length ")]
        [RegularExpression("^[+]{1}[8]{2}[0-9]{11}$", ErrorMessage = "Please provide a valid phone number (like +8801711223344)")]
        public string Phn { get; set; }

        public string Bg { get; set; }

        public string Gnd { get; set; }

        [Required(ErrorMessage = "Please provide password")]
        [RegularExpression("^[A-Za-z0-9@#$]{8,}$", ErrorMessage = "Please provide minimum 8 charecter for password. Also symbol @,#,$ is allow")]
        //[RegularExpression("^[+]{1}[8]{2}[0-9]{11}$", ErrorMessage = "Please provide minimum 8 charecter for password")]
        public string Pass { get; set; }

        [Required(ErrorMessage = "Please provide confirm password")]
        [Compare("Pass", ErrorMessage ="Confirm password is not macth with password. Please check and try again")]
        public string Cpass { get; set; }

        [Required(ErrorMessage = "Please provide address")]
        public string Add { get; set; }
    }
}