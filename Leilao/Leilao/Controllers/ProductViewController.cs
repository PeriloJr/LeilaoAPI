using Leilao.Models;
using Leilao.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Leilao.Controllers
{
    public class ProductViewController : Controller
    {
        private readonly IProductViewModel _productViewRepository;
        public ProductViewController(IProductViewModel productViewRepository)
        {
            _productViewRepository = productViewRepository;
        }
        public IActionResult Index()
        {
            var products = _productViewRepository.GetAll();
            return View(products);
        }
        public IActionResult ProductRegister()
        {
            return View();
        }
        public IActionResult EditVehicle()
        {
            return View();
        }
        public IActionResult EditProperty()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id, string type)
        {
            if (type == "Vehicle")
            {
                Vehicle vehicle = _productViewRepository.FindVehicle(id);
                
                if (vehicle == null)
                    return NotFound();

                return View("EditVehicle", vehicle);
            }
            else if (type == "Property")
            {
                Property property = _productViewRepository.FindProperty(id);
                if (property == null)
                    return NotFound();

                return View("EditProperty", property);
            }

            return BadRequest("Tipo de produto inválido");
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel product)
        {
            _productViewRepository.Add(product);
            return RedirectToAction("Index");
        }
    }
}
