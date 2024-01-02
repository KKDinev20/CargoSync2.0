﻿using CargoSync.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using CargoSync.Business.Interfaces;
public class HomeController : Controller
{
    private  IDeliveryService _deliveryService;

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
