using Microsoft.AspNetCore.Mvc;

namespace AuthTask.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
