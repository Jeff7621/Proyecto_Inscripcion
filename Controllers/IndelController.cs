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
    }
}
