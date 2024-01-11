using CargoSync.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using CargoSync.Business.Interfaces;
using System.Collections.Generic;

public class HomeController : Controller
{
    private readonly IDeliveryService _deliveryService;

    public HomeController(IDeliveryService deliveryService)
    {
        _deliveryService = deliveryService;
    }

    // Action method to display the home page with recent delivery orders and package counts
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
