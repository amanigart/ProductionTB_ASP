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
    public class UserService : IUserRepository
    {
        private string _connectionString;
        private readonly IConfiguration _config;

        public UserService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }

        internal User Converter(SqlDataReader rdr)
        {
            return new User
            {
                IdUser = (int)rdr["id_user"],
                Login = rdr["login"].ToString(),
            };
        }

        public User Login(string login, string passwd)
        {
            Connection cnx = new Connection(_connectionString);
            Command cmd = new Command("Login", true);
            cmd.AddParameter("login", login);
            cmd.AddParameter("password", passwd);

            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }
    }
}
