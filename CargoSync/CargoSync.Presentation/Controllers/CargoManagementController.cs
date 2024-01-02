using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Models;
using CargoSync.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

public class CargoManagementController : Controller
{
    private readonly ICargoService _cargoService;
    private readonly IRevenueService _revenueService;
    private readonly IUserService _userService;

    public CargoManagementController(ICargoService cargoService, IRevenueService revenueService, IUserService userService)
    {
        _cargoService = cargoService;
        _revenueService = revenueService;
        _userService = userService;
    }

    public async Task<IActionResult> Index()
    {
        List<Cargo> cargos = _cargoService.GetAllCargo(); 

        List<Revenue> revenues = await _revenueService.GetRevenues();
        List<User> users = await _userService.GetUsersAsync();

        var viewModel = new CargoManagementViewModel
        {
            Cargos = cargos,
            Revenues = revenues,
            Users = users
        };

        return View(viewModel);
    }
}
