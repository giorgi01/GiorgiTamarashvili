using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using XSSPlayground.ViewModels;

namespace XSSPlayground.Controllers
{
    public class SecurityController : Controller
    {
        private HtmlEncoder _htmlEncoder;
        private JavaScriptEncoder _javaScriptEncoder;
        private UrlEncoder _urlEncoder;

        public SecurityController(HtmlEncoder htmlEncoder, JavaScriptEncoder javaScriptEncoder, UrlEncoder urlEncoder)
        {
            _htmlEncoder = htmlEncoder;
            _javaScriptEncoder = javaScriptEncoder;
            _urlEncoder = urlEncoder;
        }

        public IActionResult XSSWithSecurityOff()
        {
            return View();
        }

        [HttpPost]
        public IActionResult XSSWithSecurityOff(XSSViewModel xssVM)
        {
            return View(xssVM);
        }

        public IActionResult XSSWithSecurityOn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult XSSWithSecurityOn(XSSViewModel xssVM)
        {
            var text = _htmlEncoder.Encode(xssVM.Text);
            text = _javaScriptEncoder.Encode(text);

            xssVM.Text = text;

            return View(xssVM);
        }

        public IActionResult UrlEncode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UrlEncode(XSSViewModel xssVM)
        {
            xssVM.Text = _urlEncoder.Encode(xssVM.Text);
            return View(xssVM);
        }
    }
}
