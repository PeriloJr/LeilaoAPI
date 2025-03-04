using Leilao.Models;
using Leilao.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Leilao.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public IActionResult Index()
        {
            Client client = new Client();

            List<Client> clients = _clientRepository.GetAll();

            return View(clients);
        }
        public IActionResult ClientRegister()
        {
            return View();
        }
        public IActionResult ClientEdit(int id)
        {
            Client client = _clientRepository.GetById(id);
            return View(client);
        }
        [HttpPost]
        public IActionResult CreateClient(Client client)
        {
            _clientRepository.Add(client);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult EditClient(Client client)
        {
            _clientRepository.Update(client);
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public IActionResult RemoveClient(Client client)
        {
            _clientRepository.Delete(client);
            return Ok();
        }
    }
}
