using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CargoSync.DataAccess.Models;

namespace CargoSync.Presentation.Controllers
{
    public class CreateRecordController : Controller
    {
        private static List<Delivery> MockRepository = new List<Delivery>();

        public ActionResult Index()
        {
            var deliveries = MockRepository; 
            return View(deliveries);
        }

        public ActionResult Details(int id)
        {
            var delivery = MockRepository.FirstOrDefault(d => d.DeliveryID == id);
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
                    delivery.DeliveryID = MockRepository.Count + 1; 
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
            var delivery = MockRepository.FirstOrDefault(d => d.DeliveryID == id);
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
                var existingDelivery = MockRepository.FirstOrDefault(d => d.DeliveryID == id);
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
            var delivery = MockRepository.FirstOrDefault(d => d.DeliveryID == id);
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
            var delivery = MockRepository.FirstOrDefault(d => d.DeliveryID == id);
            if (delivery == null)
            {
                return NotFound();
            }

            MockRepository.Remove(delivery);
            return RedirectToAction(nameof(Index));
        }
    }
}
