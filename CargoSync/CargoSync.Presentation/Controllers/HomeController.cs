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

        List<Delivery> recentOrders = _deliveryService.GetRecentOrders(5);

        int newPackagesCount = _deliveryService.GetNewPackagesCount();
        int inTransitCount = _deliveryService.GetInTransitPackagesCount();
        int deliveredCount = _deliveryService.GetDeliveredPackagesCount();

        ViewData["NewPackagesCount"] = newPackagesCount;
        ViewData["InTransitCount"] = inTransitCount;
        ViewData["DeliveredCount"] = deliveredCount;

        return View(recentOrders);
    }
}
