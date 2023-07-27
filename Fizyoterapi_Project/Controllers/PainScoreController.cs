using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fizyoterapi_Project.Controllers
{
    public class PainScoreController : Controller
    {
        private readonly Context _context;

        public PainScoreController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var painScores = _context.PainScoreEntries.ToList();
            return View(painScores);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PainScoreEntry painScore)
        {
            if (ModelState.IsValid)
            {
                _context.PainScoreEntries.Add(painScore);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(painScore);
        }

        public IActionResult Edit(int id)
        {
            var painScore = _context.PainScoreEntries.Find(id);
            if (painScore == null)
            {
                return NotFound();
            }
            return View(painScore);
        }

        [HttpPost]
        public IActionResult Edit(PainScoreEntry painScore)
        {
            if (ModelState.IsValid)
            {
                _context.PainScoreEntries.Update(painScore);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(painScore);
        }

        public IActionResult Delete(int id)
        {
            var painScore = _context.PainScoreEntries.Find(id);
            if (painScore == null)
            {
                return NotFound();
            }
            return View(painScore);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var painScore = _context.PainScoreEntries.Find(id);
            if (painScore == null)
            {
                return NotFound();
            }

            _context.PainScoreEntries.Remove(painScore);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
