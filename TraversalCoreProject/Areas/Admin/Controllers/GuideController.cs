﻿using Business.Abstract;
using Business.ValidationRules;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
        [Route("AddGuide")]
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [Route("AddGuide")]
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }
        [Route("EditGuide")]
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetByID(id);
            return View(values);
        }
        [Route("EditGuide")]
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");

        }
        [Route("ChangeToEnable/{id}")]
        public IActionResult ChangeToEnable(int id)
        {
            _guideService.TChangeToEnableByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        [Route("ChangeToDisable/{id}")]
        public IActionResult ChangeToDisable(int id)
        {
            _guideService.TChangeToDisableByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
