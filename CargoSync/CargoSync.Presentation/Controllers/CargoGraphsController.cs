using CargoSync.Business.Interfaces;
using CargoSync.DataAccess.Models;
using CargoSync.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

// Controller class for handling cargo-related graphs Inheritance
public class CargoGraphsController : Controller
{
    private ICargoService _cargoService;
    private IRevenueService _revenueService;
    private IUserService _userService;

    // Constructor to inject dependencies (services) into the controller
    public CargoGraphsController(ICargoService cargoService, IRevenueService revenueService, IUserService userService)
    {
        _cargoService = cargoService;
        _revenueService = revenueService;
        _userService = userService;
    }

    // Action method to handle the index page with optional pagination
    public async Task<IActionResult> Index(int page = 1)
    {
        const int PageSize = 10;

        // Retrieve all cargos from the cargo service
        List<Cargo> cargos = _cargoService.GetAllCargo();

        // Retrieve revenues asynchronously from the revenue service
        List<Revenue> revenues = await _revenueService.GetRevenues();

        // Retrieve all users asynchronously from the user service
        List<User> users = await _userService.GetUsersAsync();

        // Paginate the users based on the specified page and page size
        List<User> paginatedUsers = users.Skip((page - 1) * PageSize).Take(PageSize).ToList();

        // Create a view model to hold the data to be displayed in the view
        CargoGraphsViewModel viewModel = new CargoGraphsViewModel
        {
            Cargos = cargos,
            Revenues = revenues,
            Users = paginatedUsers
        };

        // Pass pagination information to the view
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = (int)Math.Ceiling((double)users.Count / PageSize);

        // Return the view with the populated view model
        return View(viewModel);
    }
}
