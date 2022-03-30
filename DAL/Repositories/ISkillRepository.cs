using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetAll();
        bool Delete(int idSkill);
        bool Update(Skill skill);
        bool Create(string name, string icon);
    }
}
