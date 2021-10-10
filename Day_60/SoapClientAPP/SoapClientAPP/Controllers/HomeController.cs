using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoapClientAPP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private SoapService _soapService;
        
        public HomeController(SoapService soapService)
        {
            _soapService = soapService;
        }

        /// <summary>
        ///
        /// </summary>
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        /// <summary>
        /// Returns simple string from soap service
        /// </summary>
        /// <param name="num"></param>        
        [HttpPost]
        public IActionResult Index(int num)
        {
            return Ok(_soapService.Get(num));
        }
    }
}
