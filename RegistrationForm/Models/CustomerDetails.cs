using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class CustomerDetails
    {
        public int Id {  get; set; }
        public int CustomerId { get; set; }
        [Required]
        [Display(Name ="FirstName")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="LastName")]
        public string LastName { get; set; }
        [Required]
        [Range(20,70)]
        public int Age {  get; set; }
        [Required]
        [Phone]
        [Display(Name="Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Language {  get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        

    }
}