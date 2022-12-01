using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AdminUI.Controllers
{
    public class StatuController : Controller
    {
        IStatuService _statuService;
        public StatuController(IStatuService statuService)
        {
            _statuService = statuService;
        }
        public IActionResult Index()
        {
            return View();
        }
      
  
        [HttpGet]
        public IActionResult ListStatu()
        {
            //Id li getiren list methodumuz.
            var result = _statuService.GetAll();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddStatu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStatu(Statu statu)
        {

            _statuService.Add(statu);

            return RedirectToAction("ListStatu");
        }
        [HttpGet]
        public IActionResult UpdateStatu(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Status.FirstOrDefault(x => x.StatuId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateStatu(Statu statu)
        {
            _statuService.Update(statu);
            return RedirectToAction("ListStatu", "Statu");
        }
        [HttpGet]
        public IActionResult DeleteStatuById(int id)

        {
            var ent = _statuService.GetId(id);
            _statuService.Delete(ent);
            return RedirectToAction("ListStatu", "Statu");

        }






    }

      
    }


