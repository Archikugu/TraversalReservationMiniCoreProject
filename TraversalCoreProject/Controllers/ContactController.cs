using AutoMapper;
using Entity.Concrete;
using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using DTO.DTOs.ContactDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactController(IMapper mapper, IContactUsService contactUsService = null)
        {
            _mapper = mapper;
            _contactUsService = contactUsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDTO model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    MessageBody = model.MessageBody,
                    Mail = model.Mail,
                    MessageStatus = model.MessageStatus,
                    Name = model.Name,
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                });
                return RedirectToAction("Index","Default");
            }
            return View(model);
        }
    }
}
