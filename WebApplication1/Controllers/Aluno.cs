using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Aluno : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
