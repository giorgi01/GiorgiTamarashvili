using EduWiki.Services.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduWiki.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILecturerService _lecturerService;
        public HomeController(ILecturerService lecturerService)
        {
            _lecturerService = lecturerService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
