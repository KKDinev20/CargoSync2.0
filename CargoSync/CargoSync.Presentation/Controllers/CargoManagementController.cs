using CargoSync.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CargoSync.Presentation.Controllers
{
    public class CargoManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
