using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CargoSync.Presentation.Controllers
{
    // Controller class for managing Delivery records
    public class DeliveryManagementController : Controller
    {
        private IDeliveryRepository _deliveryRepository;
        private const int PageSize = 50;

        public DeliveryManagementController(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        // Action method to display the list of Delivery records with pagination
        public IActionResult Index(int page = 1)
        {
            List<Delivery> deliveries = _deliveryRepository.GetDeliveries(page, PageSize);
            int totalDeliveriesCount = _deliveryRepository.GetTotalDeliveriesCount();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalDeliveriesCount / PageSize);

            return View(deliveries);
        }

        // Action method to display the create view for adding a new Delivery record
        public IActionResult Create()
        {
            return View("Create");
        }

        // POST action method to handle the creation of a new Delivery record
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                _deliveryRepository.AddDelivery(delivery);
                return RedirectToAction(nameof(Index));
            }

            return View("Create", delivery);
        }

        // Action method to display the delete view for confirming the deletion of a Delivery record
        public IActionResult Delete(int id)
        {
            Delivery delivery = _deliveryRepository.GetDeliveryById(id);

            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // POST action method to handle the deletion of a Delivery record
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _deliveryRepository.DeleteDelivery(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
