using Microsoft.AspNetCore.Mvc;
using CargoSync.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace CargoSync.Presentation.Controllers
{
    // Controller class for handling CRUD operations for Delivery records
    public class CreateRecordController : Controller
    {
        // Mock repository to store Delivery records
        private static List<Delivery> MockRepository = new List<Delivery>();

        // Action method to display the index page with the list of Delivery records
        public ActionResult Index()
        {
            List<Delivery> deliveries = MockRepository;
            return View(deliveries);
        }

        // Action method to display details of a specific Delivery record
        public ActionResult Details(int id)
        {
            Delivery delivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // Action method to display the create view for adding a new Delivery record
        public ActionResult Create()
        {
            return View();
        }

        // POST action method to handle the creation of a new Delivery record
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Delivery delivery)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Assign a unique ID and add the new Delivery record to the repository
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

        // Action method to display the edit view for updating a Delivery record
        public ActionResult Edit(int id)
        {
            Delivery delivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // POST action method to handle the update of an existing Delivery record
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

                // Update the properties of the existing Delivery record
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

        // Action method to display the delete view for confirming the deletion of a Delivery record
        public ActionResult Delete(int id)
        {
            Delivery delivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // POST action method to handle the deletion of a Delivery record
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Delivery delivery = MockRepository.FirstOrDefault(d => d.DeliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            // Remove the specified Delivery record from the repository
            MockRepository.Remove(delivery);
            return RedirectToAction(nameof(Index));
        }
    }
}
