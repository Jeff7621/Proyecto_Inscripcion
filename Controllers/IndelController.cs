using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Validacion_WEB.Controllers
{
    public class IndelController : Controller
    {
        [AllowAnonymous]
        public IActionResult Principal()
        {
            return View();
        }


        [AllowAnonymous]
        public IActionResult Mecanica()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Software()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult General()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult FormularioMecanica()
        {
            return View();
        }
    }
}
