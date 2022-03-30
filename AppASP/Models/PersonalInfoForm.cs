using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AppASP.Models
{
    public class PersonalInfoForm
    {
        [HiddenInput]
        public int IdInfo { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string AdStreet { get; set; }

        [Required]
        public string AdNumber { get; set; }

        [Required]
        public int AdZip { get; set; }

        [Required]
        public string AdCity { get; set; }

        [Required]
        public string DriverLicense { get; set; }

        [Required]
        public string RecruitingAid { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        public int DegreeDate { get; set; }

        [Required]
        public string DegreeSchool { get; set; }

        [Required]
        public string Profile { get; set; }

        [Required]
        public string Strength1 { get; set; }

        [Required]
        public string Strength2 { get; set; }

        [Required]
        public string Strength3 { get; set; }

        [Required]
        public string Weakness1 { get; set; }

        [Required]
        public string Weakness2 { get; set; }

        [Required]
        public string Weakness3 { get; set; }

        [Required]
        public string Github { get; set; }

        [Required]
        public string Discord { get; set; }
    }
}
