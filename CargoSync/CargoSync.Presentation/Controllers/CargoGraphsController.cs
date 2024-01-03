using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Models;
using CargoSync.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

public class CargoGraphsController : Controller
{
    private readonly ICargoService _cargoService;
    private readonly IRevenueService _revenueService;
    private readonly IUserService _userService;

    public CargoGraphsController(ICargoService cargoService, IRevenueService revenueService, IUserService userService)
    {
        _cargoService = cargoService;
        _revenueService = revenueService;
        _userService = userService;
    }


    public async Task<IActionResult> Index(int page = 1)
    {
        const int PageSize = 10;

        List<Cargo> cargos = _cargoService.GetAllCargo();

        List<Revenue> revenues = await _revenueService.GetRevenues();

        List<User> users = await _userService.GetUsersAsync();
        var paginatedUsers = users.Skip((page - 1) * PageSize).Take(PageSize).ToList();

        var viewModel = new CargoGraphsViewModel
        {
            Cargos = cargos,
            Revenues = revenues,
            Users = paginatedUsers
        };

        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = (int)Math.Ceiling((double)users.Count / PageSize);

        return View(viewModel);
    }
}
