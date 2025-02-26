using Leilao.Models;
using Leilao.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Leilao.Controllers
{
    public class AuctionController : Controller
    {
        private readonly IAuctionRepository _auctionRepository;
        public AuctionController(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }
        public IActionResult Index()
        {
            Auction auction = new Auction();

            List<Auction> auctions = _auctionRepository.ReturnAll();

            return View(auctions);
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult AuctionRegister()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAuction(Auction auction)
        {
            _auctionRepository.AddAuction(auction);
            return RedirectToAction("Index");
        }
    }
}
