using Asp = AppASP.Models;
using Dal = DAL.Models;

namespace AppASP.Tools
{
    public static class Mappers
    {
        #region Experience
        public static Asp.Experience DalExperienceToAspExperience(this Dal.Experience xp)
        {
            return new Asp.Experience
            {
                IdExperience = xp.IdExperience,
                YearStart = xp.YearStart,
                YearEnd = xp.YearEnd,
                Employer = xp.Employer,
                JobFunction = xp.JobFunction
            };
        }

        public static Dal.Experience AspExperienceToDalExperience(this Asp.Experience xp)
        {
            return new Dal.Experience
            {
                IdExperience = xp.IdExperience,
                YearStart = xp.YearStart,
                YearEnd = xp.YearEnd,
                Employer = xp.Employer,
                JobFunction = xp.JobFunction
            };
        }

        public static Asp.ExperienceForm DalExperienceToAspExperienceForm(this Dal.Experience xp)
        {
            return new Asp.ExperienceForm
            {
                IdExperience = xp.IdExperience,
                YearStart = xp.YearStart,
                YearEnd = xp.YearEnd,
                Employer = xp.Employer,
                JobFunction = xp.JobFunction
            };
        }

        public static Dal.Experience AspExperienceFormToDalExperience(this Asp.ExperienceForm form)
        {
            return new Dal.Experience
            {
                IdExperience = form.IdExperience,
                YearStart = form.YearStart,
                YearEnd = form.YearEnd,
                Employer = form.Employer,
                JobFunction = form.JobFunction
            };
        }
        #endregion


        #region PersonalInfo
        public static Asp.PersonalInfo DalInfosToAspInfos (this Dal.PersonalInfo infos)
        {
            return new Asp.PersonalInfo
            {
                IdInfo = infos.IdInfo,
                LastName = infos.LastName,
                FirstName = infos.FirstName,
                Email = infos.Email,
                Phone = infos.Phone,
                AdStreet = infos.AdStreet,
                AdNumber = infos.AdNumber,
                AdZip = infos.AdZip,
                AdCity = infos.AdCity,
                DriverLicense = infos.DriverLicense,
                RecruitingAid = infos.RecruitingAid,
                Degree = infos.Degree,
                DegreeDate = infos.DegreeDate,
                DegreeSchool = infos.DegreeSchool,
                Profile = infos.Profile,
                Strength1 = infos.Strength1,
                Strength2 = infos.Strength2,
                Strength3 = infos.Strength3,
                Weakness1 = infos.Weakness1,
                Weakness2 = infos.Weakness2,
                Weakness3 = infos.Weakness3,
                Github = infos.Github,
                Discord = infos.Discord
            };
        }

        public static Dal.PersonalInfo AspInfosToDalInfos(this Asp.PersonalInfo infos)
        {
            return new Dal.PersonalInfo
            {
                IdInfo = infos.IdInfo,
                LastName = infos.LastName,
                FirstName = infos.FirstName,
                Email = infos.Email,
                Phone = infos.Phone,
                AdStreet = infos.AdStreet,
                AdNumber = infos.AdNumber,
                AdZip = infos.AdZip,
                AdCity = infos.AdCity,
                DriverLicense = infos.DriverLicense,
                RecruitingAid = infos.RecruitingAid,
                Degree = infos.Degree,
                DegreeDate = infos.DegreeDate,
                DegreeSchool = infos.DegreeSchool,
                Profile = infos.Profile,
                Strength1 = infos.Strength1,
                Strength2 = infos.Strength2,
                Strength3 = infos.Strength3,
                Weakness1 = infos.Weakness1,
                Weakness2 = infos.Weakness2,
                Weakness3 = infos.Weakness3,
                Github = infos.Github,
                Discord = infos.Discord
            };
        }

        public static Asp.PersonalInfoForm DalInfosToAspInfosForm(this Dal.PersonalInfo infos)
        {
            return new Asp.PersonalInfoForm
            {
                IdInfo = infos.IdInfo,
                LastName = infos.LastName,
                FirstName = infos.FirstName,
                Email = infos.Email,
                Phone = infos.Phone,
                AdStreet = infos.AdStreet,
                AdNumber = infos.AdNumber,
                AdZip = infos.AdZip,
                AdCity = infos.AdCity,
                DriverLicense = infos.DriverLicense,
                RecruitingAid = infos.RecruitingAid,
                Degree = infos.Degree,
                DegreeDate = infos.DegreeDate,
                DegreeSchool = infos.DegreeSchool,
                Profile = infos.Profile,
                Strength1 = infos.Strength1,
                Strength2 = infos.Strength2,
                Strength3 = infos.Strength3,
                Weakness1 = infos.Weakness1,
                Weakness2 = infos.Weakness2,
                Weakness3 = infos.Weakness3,
                Github = infos.Github,
                Discord = infos.Discord
            };
        }

        public static Dal.PersonalInfo AspInfosFormToDalInfos(this Asp.PersonalInfoForm form)
        {
            return new Dal.PersonalInfo
            {
                IdInfo = form.IdInfo,
                LastName = form.LastName,
                FirstName = form.FirstName,
                Email = form.Email,
                Phone = form.Phone,
                AdStreet = form.AdStreet,
                AdNumber = form.AdNumber,
                AdZip = form.AdZip,
                AdCity = form.AdCity,
                DriverLicense = form.DriverLicense,
                RecruitingAid = form.RecruitingAid,
                Degree = form.Degree,
                DegreeDate = form.DegreeDate,
                DegreeSchool = form.DegreeSchool,
                Profile = form.Profile,
                Strength1 = form.Strength1,
                Strength2 = form.Strength2,
                Strength3 = form.Strength3,
                Weakness1 = form.Weakness1,
                Weakness2 = form.Weakness2,
                Weakness3 = form.Weakness3,
                Github = form.Github,
                Discord = form.Discord
            };
        }
        #endregion


        #region Skill
        public static Asp.Skill DalSkillToAspSkill(this Dal.Skill skill)
        {
            return new Asp.Skill
            {
                IdSkill = skill.IdSkill,
                Name = skill.Name,
                Icon = skill.Icon
            };
        }

        public static Dal.Skill AspSkilltoDalSkill(this Asp.Skill skill)
        {
            return new Dal.Skill
            {
                IdSkill = skill.IdSkill,
                Name = skill.Name,
                Icon = skill.Icon
            };
        }

        public static Asp.SkillForm DalSkillToAspSkillForm(this Dal.Skill skill)
        {
            return new Asp.SkillForm
            {
                IdSkill = skill.IdSkill,
                Name = skill.Name,
                Icon = skill.Icon
            };
        }

        public static Dal.Skill AspSkillFormToDalSkill(this Asp.SkillForm form)
        {
            return new Dal.Skill
            {
                IdSkill = form.IdSkill,
                Name = form.Name,
                Icon = form.Icon
            };
        }
        #endregion


        #region User
        public static Asp.User DalUserToAspUser(this Dal.User user)
        {
            return new Asp.User
            {
                IdUser = user.IdUser,
                Login = user.Login
            };
        }

        public static Dal.User AspUserToDalUser(this Asp.User user)
        {
            return new Dal.User
            {
                IdUser = user.IdUser,
                Login = user.Login
            };
        }

        /*public static Asp.LoginForm DalUserToAspLoginForm(this UserSecretsConfigurationExtensions user)
        {
            return new Asp.LoginForm
            {
                
            };
        }*/
        #endregion
    }
}
