using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Śluber.Data;
using Śluber.Models;

namespace Śluber
{
    [Authorize]
    public class WeddingsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;
        public UserManager<ApplicationUser> UserManager => _userManager;

        public WeddingsController(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Weddings
        public async Task<IActionResult> Index()
        {
          

            var userId = _userManager.GetUserId(User);
            List<Wedding> weddings = new List<Wedding>();
               weddings = await _context.Wedding
                .Where(m => m.OwnerId == userId)
                .ToListAsync();
           // Wedding wedding = weddings.FirstOrDefault(m => m.OwnerId == userId);
          

            return View("Index", weddings);
        }

        // GET: Weddings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wedding = await _context.Wedding
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wedding == null)
            {
                return NotFound();
            }

            return View(wedding);
        }

        // GET: Weddings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Weddings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Wedding wedding)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                Wedding review = new Wedding
                {
                    WifeName = wedding.WifeName,
                    HusbandName = wedding.HusbandName,
                    WeddingDate = wedding.WeddingDate,
                    WeddingPlace = wedding.WeddingPlace,
                    OwnerId = userId,
                    CreatedById = userId,
                    ModifiedById = userId
                };
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wedding);
        }

        // GET: Weddings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wedding = await _context.Wedding.FindAsync(id);
            if (wedding == null)
            {
                return NotFound();
            }
            return View(wedding);
        }

        // POST: Weddings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WifeName,HusbandName,WeddingDate,WeddingPlace,Budget,Cost")] Wedding wedding)
        {
            if (id != wedding.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wedding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeddingExists(wedding.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(wedding);
        }

        // GET: Weddings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wedding = await _context.Wedding
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wedding == null)
            {
                return NotFound();
            }

            return View(wedding);
        }

        // POST: Weddings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wedding = await _context.Wedding.FindAsync(id);
            _context.Wedding.Remove(wedding);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeddingExists(int id)
        {
            return _context.Wedding.Any(e => e.Id == id);
        }
    }
}
