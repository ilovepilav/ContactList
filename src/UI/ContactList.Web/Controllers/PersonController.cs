using ContactList.Application.Features.Queries.GetAllPersons;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using ContactList.Application.Features.Queries.GetPersonById;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactList.Application.Dtos;
using ContactList.Application.Features.Commands.PersonCommands.UpdatePerson;
using ContactList.Application.Features.Commands.PersonCommands.DeletePerson;
using ContactList.Application.Features.Commands.PersonCommands.CreatePerson;

namespace ContactList.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var query = new GetAllPersonsQuery();
            var result = await _mediator.Send(query);
            return View(result);
        }

        public async Task<IActionResult> Detail(Guid id)
        {
            var query = new GetPersonByIdQuery() { Id = id };
            var result = await _mediator.Send(query);

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdatePersonCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                ViewBag.Error = "Kişi güncellenemedi. Anasayfaya Yöneldiriliyorsunuz.";
                return View("Error");
            }

            ViewBag.Error = "Kişi bilgileri hatalı. Anasayfaya Yöneldiriliyorsunuz.";
            return View("Error");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var query = new DeletePersonCommand() { Id = id };
            var result = await _mediator.Send(query);
            if (result)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Error = "Kişi silinemedi. Anasayfaya Yönlendiriliyorsunuz.";
            return View("Error");
        }

        public async Task<IActionResult> EditContacts(Guid id)
        {
            var query = new GetPersonByIdQuery() { Id = id };
            var result = await _mediator.Send(query);
            if (result != null)
            {
                TempData["FullName"] = $"{result.FirstName} {result.LastName}";
                return RedirectToAction("List", "Contact", new { id = id });
            }
            ViewBag.Error = "Kişi bulunamadı. Anasayfaya Yönlendiriliyorsunuz.";
            return View("Error");
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePersonCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                ViewBag.Error = "Kişi eklenemedi. Anasayfaya Yönlendiriliyorsunuz.";
            }
            ViewBag.Error = "Kişi bilgileri geçersiz. Anasayafaya Yönlendiriliyorsunuz.";
            return View("Error");
        }
    }
}
