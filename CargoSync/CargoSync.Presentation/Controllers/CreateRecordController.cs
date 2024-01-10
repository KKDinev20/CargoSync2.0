using Microsoft.AspNetCore.Mvc;
using CargoSync.DataAccess.Models;

namespace CargoSync.Presentation.Controllers
{
    public class CreateRecordController : Controller
    {
        private static List<Delivery> MockRepository = new List<Delivery>();

        public ActionResult Index()
        {
            List<Delivery> deliveries = MockRepository; 
            return View(deliveries);
        }

        public ActionResult Details(int id)
        {
            Delivery delivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Delivery delivery)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    delivery.DeliveryId = MockRepository.Count + 1; 
                    MockRepository.Add(delivery);

                    return RedirectToAction(nameof(Index));
                }

                return View(delivery);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Delivery delivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Delivery updatedDelivery)
        {
            try
            {
                Delivery existingDelivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
                if (existingDelivery == null)
                {
                    return NotFound();
                }

                existingDelivery.Destination = updatedDelivery.Destination;
                existingDelivery.ETA = updatedDelivery.ETA;
                existingDelivery.Status = updatedDelivery.Status;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Delivery delivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Delivery delivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            MockRepository.Remove(delivery);
            return RedirectToAction(nameof(Index));
        }
    }
}
