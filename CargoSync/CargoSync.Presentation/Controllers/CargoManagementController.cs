using CargoSync.Business.Services;
using CargoSync.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

public class CargoManagementController : Controller
{
    private readonly ICargoService _cargoService;

    public CargoManagementController(ICargoService cargoService)
    {
        _cargoService = cargoService;
    }

    public IActionResult Index()
    {
        List<Cargo> cargos = _cargoService.GetAllCargo();

        return View(cargos);
    }
}