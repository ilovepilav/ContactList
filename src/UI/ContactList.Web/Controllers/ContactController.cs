using AutoMapper;
using ContactList.Application.Features.Commands.ContactCommands.CreateContact;
using ContactList.Application.Features.Commands.ContactCommands.DeleteContact;
using ContactList.Application.Features.Commands.ContactCommands.UpdateContact;
using ContactList.Application.Features.Queries.GetContactsByPersonId;
using ContactList.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactList.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public ContactController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        public async Task<IActionResult> List(Guid id)
        {
            var query = new GetContactsByPersonIdQuery() {PersonId=id };
            var resultList = await mediator.Send(query);


            if (resultList != null)
            {
                var contactModels = mapper.Map<List<UpdateContactCommand>>(resultList);
                ViewData["Contacts"] = contactModels;
                ViewBag.PersonId = id;
                return View();
            }
            ViewBag.Error = "Kişi Bulunamadı. Anasayfaya Yönlendiriliyorsunuz.";
            return View("Error");
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await mediator.Send(command);
                if (result)
                {
                    return RedirectToAction("EditContacts", "Person", new { id= command.PersonId });
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromForm] UpdateContactCommand command, Guid personId)
        {
            if (ModelState.IsValid)
            {
                var result = await mediator.Send(command);
                if (result)
                {
                    return RedirectToAction("EditContacts","Person", new { id = personId });
                }
            }
            return View();
        }

        public async Task<IActionResult> Delete(Guid id, Guid personId)
        {
            var command = new DeleteContactCommand() { Id = id };
            var result = await mediator.Send(command);
            if (result)
            {
                return RedirectToAction("EditContacts", "Person", new { id = personId });
            }

            ViewBag.Error = "Silme işleminde hata! Anasayfaya Yönlendiriliyorsunuz.";
            return View("Error");
        }
    }
}
