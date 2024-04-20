using FinalEntertainers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var entertainers = _repo.Entertainers.ToList();
            return View(entertainers);
        }

        [HttpGet]
        public IActionResult AddEntertainer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEntertainer(Entertainer entertainer)
        {
         
                _repo.AddEntertainer(entertainer);  // Add entertainer to the database context
                _repo.SaveChanges();  // Save changes in the database

                return RedirectToAction("Entertainers");  // Redirect to the index view, or wherever the list of entertainers is shown
            
         
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var entertainer = _repo.GetEntertainerById(id);
            if (entertainer == null)
            {
                return NotFound();
            }
            return View(entertainer);
        }

        [HttpPost]
        
        public IActionResult Details(Entertainer entertainer)
        {
           
                _repo.UpdateEntertainer(entertainer);  // Assumes UpdateEntertainer is a method in your repository for updating an entertainer
                _repo.SaveChanges();
                return View(entertainer);  // Redirect to a safe page after update
            
           
        }

    }
}
