using Leilao.Models;
using Leilao.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Leilao.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        [HttpDelete("Vehicle/Delete/{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            Vehicle vehicle = new Vehicle { Id = id};
            _vehicleRepository.Delete(vehicle);

            return Ok();
        }
        [HttpPost]
        public IActionResult EditVehicle(Vehicle vehicle)
        {
            _vehicleRepository.Update(vehicle);
            return RedirectToAction("Index", "ProductView");
        }
    }
}
