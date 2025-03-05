using Leilao.Models;
using Leilao.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Leilao.Controllers
{
    public class FinancialInstitutionController : Controller
    {
        private readonly IFinancialInstituionRepository _financialInstituionRepository;
        public FinancialInstitutionController(IFinancialInstituionRepository financialInstituionRepository)
        {
            _financialInstituionRepository = financialInstituionRepository;
        }
        public IActionResult Index()
        {
            FinancialInstitution financialInstitution = new FinancialInstitution();

            List<FinancialInstitution> financialInstitutions = _financialInstituionRepository.GetAll();

            return View(financialInstitutions);
        }
        public IActionResult FIRegister() 
        {
            return View();
        }
        public IActionResult FIEdit(int id)
        {
            FinancialInstitution financialInstitution = _financialInstituionRepository.GetById(id);
            return View(financialInstitution);
        }
        [HttpPost]
        public IActionResult CreateFI(FinancialInstitution FI)
        {
            _financialInstituionRepository.Add(FI);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult EditFI(FinancialInstitution FI)
        {
            _financialInstituionRepository.Update(FI);
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public IActionResult RemoveFI(FinancialInstitution financialInstitution)
        {
            _financialInstituionRepository.Delete(financialInstitution);
            return Ok();
        }
    }
}
