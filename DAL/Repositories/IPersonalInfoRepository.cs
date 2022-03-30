using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IPersonalInfoRepository
    {
        PersonalInfo GetAll();
        bool Delete(int idInfo);
        bool Update(PersonalInfo info);
        bool Create(PersonalInfo info);
    }
}
