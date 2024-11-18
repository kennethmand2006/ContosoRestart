using Microsoft.AspNetCore.Mvc;

namespace Contoso.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
