using AppASP.Models;
using AppASP.Tools;
using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExperienceRepository _serviceXp;
        private readonly IPersonalInfoRepository _serviceInfo;
        private readonly ISkillRepository _serviceSkill; 

        public HomeController(ILogger<HomeController> logger, IExperienceRepository serviceXp, IPersonalInfoRepository serviceInfo, ISkillRepository serviceSkill)
        {
            _logger = logger;
            _serviceXp = serviceXp;
            _serviceInfo = serviceInfo;
            _serviceSkill = serviceSkill;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.PersonalInfos = _serviceInfo.GetAll().DalInfosToAspInfos();
            model.Experiences = _serviceXp.GetAll().Select(xp => xp.DalExperienceToAspExperience()).OrderByDescending(xp => xp.YearStart);
            model.Skills = _serviceSkill.GetAll().Select(s => s.DalSkillToAspSkill());

            return View(model);
        }

        #region Create
        [AuthRequiredAttributes]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(CreateFormViewModel form)
        {
            if (!ModelState.IsValid)
                return View(form);

            _serviceXp.Create(form.ExperienceForm.AspExperienceFormToDalExperience());
            return RedirectToAction("Create");
        }

        [HttpPost]
        public IActionResult CreateSkill(CreateFormViewModel form)
        {
            _serviceSkill.Create(form.SkillForm.Name, form.SkillForm.Icon);
            // todo: viewbag erreur et succes (afficher message que ça a été ajouté)
            return RedirectToAction("Create");
        }
        #endregion


        #region Edit
        [AuthRequiredAttributes]
        public IActionResult Edit()
        {
            EditFormViewModel model = new EditFormViewModel();
            model.PersonalInfoForm = _serviceInfo.GetAll().DalInfosToAspInfosForm();
            model.ExperienceForms = _serviceXp.GetAll().Select(xp => xp.DalExperienceToAspExperienceForm()).ToList();
            model.SkillForms = _serviceSkill.GetAll().Select(s => s.DalSkillToAspSkillForm()).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditFormViewModel form)
        {
            if (!ModelState.IsValid) 
                return View(form);

            _serviceInfo.Update(form.PersonalInfoForm.AspInfosFormToDalInfos());

            foreach (ExperienceForm xp in form.ExperienceForms)
            {
                _serviceXp.Update(xp.AspExperienceFormToDalExperience());
            }

            foreach (SkillForm skill in form.SkillForms)
            {
                _serviceSkill.Update(skill.AspSkillFormToDalSkill());
            }

            return RedirectToAction("Index");
        }
        #endregion


        #region Delete
        public IActionResult DeleteExperience(int id)
        {
            _serviceXp.Delete(id);
            return RedirectToAction("Edit");
        }

        public IActionResult DeleteSkill(int id)
        {
            _serviceSkill.Delete(id);
            return RedirectToAction("Edit");
        }
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}