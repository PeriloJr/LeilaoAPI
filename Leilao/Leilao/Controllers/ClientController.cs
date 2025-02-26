using Leilao.Models;
using Leilao.Repository;
using Microsoft.AspNetCore.Mvc;

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

            List<Client> clients = _clientRepository.ReturnAll();

            return View(clients);
        }
        public IActionResult ClientRegister()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateClient(Client client)
        {
            _clientRepository.AddClient(client);
            return RedirectToAction("Index");
        }
    }
}
