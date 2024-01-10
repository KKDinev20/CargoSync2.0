using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace CargoSync.Presentation.Controllers
{
    public class DeliveryManagementController : Controller
    {
        private IDeliveryRepository _deliveryRepository;
        private const int PageSize = 50;

        public DeliveryManagementController(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public IActionResult Index(int page = 1)
        {
            List<Delivery> deliveries = _deliveryRepository.GetDeliveries(page, PageSize);
            int totalDeliveriesCount = _deliveryRepository.GetTotalDeliveriesCount();

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

            return View("Create", delivery);
        }

        public IActionResult Delete(int id)
        {
            Delivery delivery = _deliveryRepository.GetDeliveryById(id);

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
