using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AppASP.Models
{
    public class SkillForm
    {
        [HiddenInput]
        public int IdSkill { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Icon { get; set; }
    }
}
