using CargoSync.DataAccess.Models; // Import the necessary namespace
using CargoSync.Business.Services; // Import the necessary namespace
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    private readonly IDeliveryService _deliveryService;

    public HomeController(IDeliveryService deliveryService)
    {
        _deliveryService = deliveryService;
    }

    public IActionResult Index()
    {

        var recentOrders = _deliveryService.GetRecentOrders(10);

        return View(recentOrders);
    }
}
