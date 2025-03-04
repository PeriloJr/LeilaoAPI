using Leilao.Models;
using Leilao.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Leilao.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyController(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        [HttpDelete("Property/Delete/{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            Property property = new Property { Id = id };
            _propertyRepository.Delete(property);

            return Ok();
        }
        [HttpPost]
        public IActionResult EditProperty(Property property)
        {
            _propertyRepository.Update(property);
            return RedirectToAction("Index", "ProductView");
        }
    }
}
