using DataAccess.Concrete;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using System;
using Business.Abstract;
using Entities.Concrete;
using System.Linq;
using Business.ValidationRules;
using FluentValidation.Results;

namespace AdminUI.Controllers
{
    public class MissionController : Controller
    {
        IMissionService _missionService;
        public MissionController(IMissionService missionService)
        {
            _missionService = missionService;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult ListCarWithBrandName()
        //{
        //    //İstediğimiz veriyi cekebildiğimiz hali.
        //    var result = _carService.GetCarDetails();
        //    return View(result);

        //}

        [HttpGet]
        public IActionResult ListMission()
        {
            //Id li getiren list methodumuz.
            var result = _missionService.GetAll();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddMission()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMission(Mission mission)
        {
            MissionValidation missionValid = new MissionValidation();
            ValidationResult results = missionValid.Validate(mission);
            if (results.IsValid)
            {
                _missionService.Add(mission);
                TempData.Add("message", String.Format("Görev başarılı şekilde eklendi"));

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    TempData.Add("message", String.Format("Görev eklenemedi!!!"));
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateMission(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Missions.FirstOrDefault(x => x.TaskId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateMission(Mission mission)
        {
            _missionService.Update(mission);
            return RedirectToAction("ListMission", "Mission");
        }
        [HttpGet]
        public IActionResult DeleteMissionById(int id)

        {
            var ent = _missionService.GetId(id);
            _missionService.Delete(ent);
            return RedirectToAction("ListMission", "Mission");

        }
    }
}
