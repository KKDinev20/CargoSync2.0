using CargoSync.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            return View();
        }

        [HttpPost]
        public IActionResult Create(Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                _deliveryRepository.AddDelivery(delivery);
                return RedirectToAction(nameof(Index));
            }

            return View(delivery);
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            _deliveryRepository.RemoveDelivery(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
