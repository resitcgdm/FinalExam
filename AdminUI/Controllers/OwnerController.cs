using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Concrete;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AdminUI.Controllers
{
    public class OwnerController : Controller
    {
        IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
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
        public IActionResult ListOwner()
        {
            //Id li getiren list methodumuz.
            var result = _ownerService.GetAll();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddOwner()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOwner(Owner owner)
        {
            OwnerValidation ownerValid = new OwnerValidation();
            ValidationResult results = ownerValid.Validate(owner);
            if (results.IsValid)
            {
                _ownerService.Add(owner);
                TempData.Add("message", String.Format("Kişi başarılı şekilde eklendi"));

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    TempData.Add("message", String.Format("Kişi eklenemedi!!!"));
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateOwner(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Owners.FirstOrDefault(x => x.OwnerId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateOwner(Owner owner)
        {
            _ownerService.Update(owner);
            return RedirectToAction("ListOwner", "Owner");
        }
        [HttpGet]
        public IActionResult DeleteOwnerById(int id)

        {
            var ent = _ownerService.GetId(id);
            _ownerService.Delete(ent);
            return RedirectToAction("ListOwner", "Owner");

        }
    }
}
