using CargoSync.DataAccess.Data.Repositories;
using CargoSync.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CargoSync.Presentation.Controllers
{
    public class DeliveryManagementController : Controller
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private const int PageSize = 50;

        public DeliveryManagementController(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public IActionResult Index(int page = 1)
        {
            var deliveries = _deliveryRepository.GetDeliveries(page, PageSize);
            var totalDeliveriesCount = _deliveryRepository.GetTotalDeliveriesCount();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalDeliveriesCount / PageSize);

            return View(deliveries);
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                _deliveryRepository.AddDelivery(delivery);
                return RedirectToAction(nameof(Index));
            }

            // If the model is not valid, return to the Create view with the validation errors.
            return View("Create", delivery);
        }

        public IActionResult Delete(int id)
        {
            var delivery = _deliveryRepository.GetDeliveryById(id);

            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _deliveryRepository.DeleteDelivery(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
