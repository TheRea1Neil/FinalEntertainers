using FinalEntertainers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalEntertainers.Controllers
{
    public class HomeController : Controller
    {
        private IEntertainmentAgnecyRepository _repo;

        public HomeController(IEntertainmentAgnecyRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entertainers()
        {
            return View();
        }
       
    }
}
