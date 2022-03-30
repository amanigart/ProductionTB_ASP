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
    public class SkillService : ISkillRepository
    {
        private string _connectionString;
        private readonly IConfiguration _config;

        public SkillService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }

        internal Skill Converter(SqlDataReader rdr)
        {
            return new Skill
            {
                IdSkill = (int)rdr["id_skill"],
                Name = rdr["name"].ToString(),
                Icon = rdr["icon"].ToString()
            };
        }

        public IEnumerable<Skill> GetAll()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT * FROM Skill";
            Command cmd = new Command(sql);

            return cnx.ExecuteReader(cmd, Converter);
        }

        public bool Delete(int idSkill)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("DeleteSkill", true);
            cmd.AddParameter("id", idSkill);

            return cnx.ExecuteNonQuery(cmd) == 0 ? false : true;
        }

        public bool Update(Skill skill)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("UpdateSkill", true);
            cmd.AddParameter("name", skill.Name);
            cmd.AddParameter("icon", skill.Icon);
            cmd.AddParameter("id", skill.IdSkill);
            
            return cnx.ExecuteNonQuery(cmd) == 0 ? false : true;
        }

        public bool Create(string name, string icon)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("SaveSkill", true);
            cmd.AddParameter("name", name);
            cmd.AddParameter("icon", icon);

            return cnx.ExecuteNonQuery(cmd) == 0 ? false : true;
        }
    }
}
