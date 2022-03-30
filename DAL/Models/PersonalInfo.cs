using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PersonalInfo
    {
        public int IdInfo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AdStreet { get; set; }
        public string AdNumber { get; set; }
        public int AdZip { get; set; }
        public string AdCity { get; set; }
        public string DriverLicense { get; set; }
        public string RecruitingAid { get; set; }
        public string Degree { get; set; }
        public int DegreeDate { get; set; }
        public string DegreeSchool { get; set; }
        public string Profile { get; set; }
        public string Strength1 { get; set; }
        public string Strength2 { get; set; }
        public string Strength3 { get; set; }
        public string Weakness1 { get; set; }
        public string Weakness2 { get; set; }
        public string Weakness3 { get; set; }
        public string Github { get; set; }
        public string Discord { get; set; }
    }
}
