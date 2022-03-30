using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IExperienceRepository
    {
        IEnumerable<Experience> GetAll();
        bool Delete(int idExperience);
        bool Update(Experience xp);
        bool Create(Experience xp);
    }
}
