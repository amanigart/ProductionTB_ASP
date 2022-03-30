using AdoToolbox;
using DAL.Models;
using DAL.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class PersonalInfoService : IPersonalInfoRepository
    {
        private string _connectionString;
        private readonly IConfiguration _config;

        public PersonalInfoService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }

        internal PersonalInfo Converter(SqlDataReader rdr)
        {
            return new PersonalInfo
            {
                IdInfo = (int)rdr["id_info"],
                LastName = rdr["lastname"].ToString(),
                FirstName = rdr["firstname"].ToString(),
                Email = rdr["email"].ToString(),
                Phone = rdr["phone"].ToString(),
                AdStreet = rdr["ad_street"].ToString(),
                AdNumber = rdr["ad_number"].ToString(),
                AdZip = (int)rdr["ad_zip"],
                AdCity = rdr["ad_city"].ToString(),
                DriverLicense = rdr["driver_license"].ToString(),
                RecruitingAid = rdr["recruiting_aid"].ToString(),
                Degree = rdr["degree"].ToString(),
                DegreeDate = (int)rdr["degree_date"],
                DegreeSchool = rdr["degree_school"].ToString(),
                Profile = rdr["profile"].ToString(),
                Strength1 = rdr["strength_1"].ToString(),
                Strength2 = rdr["strength_2"].ToString(),
                Strength3 = rdr["strength_3"].ToString(),
                Weakness1 = rdr["weakness_1"].ToString(),
                Weakness2 = rdr["weakness_2"].ToString(),
                Weakness3 = rdr["weakness_3"].ToString(),
                Github = rdr["github"].ToString(),
                Discord = rdr["discord"].ToString()
            };
        }

        public PersonalInfo GetAll()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT * FROM Personal_Info";
            Command cmd = new Command(sql);

            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }

        public bool Delete(int idInfo)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("DeletePersonalInfo", true);
            cmd.AddParameter("id", idInfo);

            return cnx.ExecuteNonQuery(cmd) == 0 ? false : true;
        }

        public bool Update(PersonalInfo info)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("UpdatePersonalInfo", true);
            cmd.AddParameter("name", info.LastName);
            cmd.AddParameter("fName", info.FirstName);
            cmd.AddParameter("email", info.Email);
            cmd.AddParameter("phone", info.Phone);
            cmd.AddParameter("street", info.AdStreet);
            cmd.AddParameter("number", info.AdNumber);
            cmd.AddParameter("zip", info.AdZip);
            cmd.AddParameter("city", info.AdCity);
            cmd.AddParameter("driverLicense", info.DriverLicense);
            cmd.AddParameter("recruitingAid", info.RecruitingAid);
            cmd.AddParameter("degree", info.Degree);
            cmd.AddParameter("degreeDate", info.DegreeDate);
            cmd.AddParameter("degreeSchool", info.DegreeSchool);
            cmd.AddParameter("profile", info.Profile);
            cmd.AddParameter("strength1", info.Strength1);
            cmd.AddParameter("strength2", info.Strength2);
            cmd.AddParameter("strength3", info.Strength3);
            cmd.AddParameter("weakness1", info.Weakness1);
            cmd.AddParameter("weakness2", info.Weakness2);
            cmd.AddParameter("weakness3", info.Weakness3);
            cmd.AddParameter("github", info.Github);
            cmd.AddParameter("discord", info.Discord);

            return cnx.ExecuteNonQuery(cmd) == 0 ? false : true;
        }

        public bool Create(PersonalInfo info)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("SavePersonalInfo", true);
            cmd.AddParameter("name", info.LastName);
            cmd.AddParameter("fName", info.FirstName);
            cmd.AddParameter("email", info.Email);
            cmd.AddParameter("phone", info.Phone);
            cmd.AddParameter("stree", info.AdStreet);
            cmd.AddParameter("number", info.AdNumber);
            cmd.AddParameter("zip", info.AdZip);
            cmd.AddParameter("city", info.AdCity);
            cmd.AddParameter("driverLicense", info.DriverLicense);
            cmd.AddParameter("recruitingAid", info.RecruitingAid);
            cmd.AddParameter("degree", info.Degree);
            cmd.AddParameter("degreeDate", info.DegreeDate);
            cmd.AddParameter("degreeSchool", info.DegreeSchool);
            cmd.AddParameter("profile", info.Profile);
            cmd.AddParameter("strength1", info.Strength1);
            cmd.AddParameter("strength2", info.Strength2);
            cmd.AddParameter("strength3", info.Strength3);
            cmd.AddParameter("weakness1", info.Weakness1);
            cmd.AddParameter("weakness2", info.Weakness2);
            cmd.AddParameter("weakness3", info.Weakness3);
            cmd.AddParameter("github", info.Github);
            cmd.AddParameter("discord", info.Discord);

            return cnx.ExecuteNonQuery(cmd) == 0 ? false : true;
        }
    }
}
