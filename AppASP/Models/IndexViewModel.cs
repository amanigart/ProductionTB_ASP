namespace AppASP.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Experience> Experiences { get; set; }
        public PersonalInfo PersonalInfos { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
