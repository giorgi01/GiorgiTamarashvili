using EduWiki.Data;
using EduWiki.Services.Abstractions;
using EduWiki.Services.Models;
using EduWiki.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduWiki.Controllers
{
    public class LecturersController : Controller
    {

        private readonly ILecturerService _service;
        private readonly IFileService _fileService;

        public LecturersController(ILecturerService service, IFileService fileManager)
        {
            _service = service;
            _fileService = fileManager;
        }

        public async Task<ActionResult> Index()
        {
            var lecturers = await _service.GetAllAsync();

            var result = new LecturerIndexViewModel
            {
                Lecturers = lecturers.Adapt<List<LecturerViewModel>>()
            };

            return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(LecturerViewModel lecturerVM)
        {
            if (ModelState.IsValid)
            {
                // მესმის რომ ქვედა ლაინი LecturerService-ში გადატანა აჯობებდა, 
                // უბრალოდ IFormFile-ს სერვის ლეიერში მაპინგის დროს ბევრ პრობლემას შევეჩეხე, netstandard-ის ვერსიებზე მიგდებდა ერორებს და აღარ ჩავეძიე
                lecturerVM.ImagePath = await _fileService.UploadAsync(lecturerVM.ImageFile);
                var lecturer = lecturerVM.Adapt<LecturerServiceModel>();
                await _service.CreateAsync(lecturer);

                // მეორე სერვისიც მხოლოდ იმიტომ გამოვიძახე აქ რომ viewbagს სხვანაირად ვერ ვაყოლებდი ინდექსში
                ViewBag.Success = true;
                var lecturersList = await _service.GetAllAsync();
                var indexVM = new LecturerIndexViewModel
                {
                    Lecturers = lecturersList.Adapt<List<LecturerViewModel>>()
                };
                return View("Index", indexVM);
            }
            else
            {
                ModelState.Clear();
                ModelState.AddModelError("ModelError", "Incorrect data format");
                return View(lecturerVM);
            }
        }

        public async Task<ActionResult> Details(int id)
        {
            var lecturer = (await _service.GetAsync(id)).Item2;
            var lecturerVM = lecturer.Adapt<LecturerViewModel>();
            return View(lecturerVM);
        }

        [HttpPost]
        public async Task<ActionResult> Details(LecturerViewModel lecturerVM)
        {
            if (ModelState.IsValid)
            {
                var lecturer = lecturerVM.Adapt<LecturerServiceModel>();
                await _service.UpdateAsync(lecturer);
                return RedirectToAction(nameof(Index));
            }
            else
            {

                ModelState.Clear();
                ModelState.AddModelError("ModelError", "Incorrect data format");
                return View(lecturerVM);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
