using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WebApplication3.Models
{
    public class Applicant
    {
        public int ApplicantId { get; }
        [Required]
        public string FirstName  { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Name { get => FirstName + LastName; }
        [Required]
        public Nationality NationalityName { get; set; }
        [Required]
        public Gender GenderName { get; set; }
        [Required(ErrorMessage = "Phone Number should 10 digit number")]
        
        [RegularExpression("[0-9]")]
        public int PhoneNumber { get; set; }
        [Required]
        public int Adhar { get; set; }
        public Address Address { get; set; }
        public enum Gender
        {
            Male,
            Female
        }
        public enum Nationality
        {
            India,
            Others
        }


    }
}
