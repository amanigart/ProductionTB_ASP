using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Experience
    {
        public int IdExperience { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public string Employer { get; set; }
        public string JobFunction { get; set; }
    }
}
