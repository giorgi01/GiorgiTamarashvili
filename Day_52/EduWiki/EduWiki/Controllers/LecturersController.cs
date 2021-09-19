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

        public async Task<ActionResult> Details(int id)
        {
            var lecturer = await _service.GetAsync(id);
            return View(lecturer.Adapt<LecturerViewModel>());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(LecturerViewModel lecturer)
        {
            try
            {
                // მესმის რომ ქვედა ლაინი LecturerService-ში გადატანა აჯობებდა, 
                // უბრალოდ IFormFile-ს სერვის ლეიერში მაპინგის დროს ბევრ პრობლემას შევეჩეხე, netstandard-ის ვერსიებზე მიგდებდა ერორებს და აღარ ჩავეძიე
                lecturer.ImagePath = await _fileService.UploadAsync(lecturer.ImageFile);
                var serviceModel = lecturer.Adapt<LecturerServiceModel>();
                await _service.CreateAsync(serviceModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View("ErrorHandler", ex);
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
