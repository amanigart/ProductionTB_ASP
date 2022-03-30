using System.ComponentModel.DataAnnotations;

namespace AppASP.Models
{
    public class LoginForm
    {
        [Required]  //type password
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Passwd { get; set; }
    }
}
