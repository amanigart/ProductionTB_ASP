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
    public class ExperienceService : IExperienceRepository
    {
        private string _connectionString;
        private readonly IConfiguration _config;

        public ExperienceService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }

        internal Experience Converter(SqlDataReader rdr)
        {
            return new Experience
            {
                IdExperience = (int)rdr["id_experience"],
                YearStart = (int)rdr["date_start"],
                YearEnd = (int)rdr["date_end"],
                Employer = rdr["employer"].ToString(),
                JobFunction = rdr["job_function"].ToString()
            };
        }

        public IEnumerable<Experience> GetAll()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT * FROM Experience";
            Command cmd = new Command(sql);

            return cnx.ExecuteReader(cmd, Converter);
        }

        public bool Delete(int idExperience)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("DeleteExperience", true);
            cmd.AddParameter("id", idExperience);

            return (cnx.ExecuteNonQuery(cmd) == 0) ? false : true;
        }

        public bool Update(Experience xp)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("UpdateExperience", true);
            cmd.AddParameter("start", xp.YearStart);
            cmd.AddParameter("end", xp.YearEnd);
            cmd.AddParameter("employer", xp.Employer);
            cmd.AddParameter("job", xp.JobFunction);
            cmd.AddParameter("id", xp.IdExperience);

            return (cnx.ExecuteNonQuery(cmd) == 0) ? false : true;
        }

        public bool Create(Experience xp)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("SaveExperience", true);
            cmd.AddParameter("start", xp.YearStart);
            cmd.AddParameter("end", xp.YearEnd);
            cmd.AddParameter("employer", xp.Employer);
            cmd.AddParameter("job", xp.JobFunction);

            return (cnx.ExecuteNonQuery(cmd) == 0) ? false : true;
        }
    }
}
