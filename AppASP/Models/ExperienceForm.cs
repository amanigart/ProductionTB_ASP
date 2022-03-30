using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AppASP.Models
{
    public class ExperienceForm
    {
        [HiddenInput]
        public int IdExperience { get; set; }

        [Required]
        public int YearStart { get; set; }

        [Required]
        public int YearEnd { get; set; }

        [Required]
        public string Employer { get; set; }

        [Required]
        public string JobFunction { get; set; }
    }
}
