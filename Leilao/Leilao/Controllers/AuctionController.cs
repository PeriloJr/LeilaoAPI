using Leilao.Models;
using Leilao.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

            List<Auction> auctions = _auctionRepository.GetAll();

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
        public IActionResult ProductManagement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAuction(Auction auction)
        {
            _auctionRepository.Add(auction);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel productViewModel)
        {
            _auctionRepository.CreateProduct(productViewModel);
            return RedirectToAction("Index");
        }
    }
}
