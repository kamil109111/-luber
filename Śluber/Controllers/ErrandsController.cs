using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Śluber.Data;
using Śluber.Models;

namespace Śluber.Controllers
{
    [Authorize]
    public class ErrandsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ErrandsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Errands
       // public async Task<IActionResult> Index()
       // {
       //     return View(await _context.Errand.ToListAsync());
      //  }

        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
                               var errands = from e in _context.Errand
                               select e;
                switch (sortOrder)
                {
                    
                    case "Date":
                       errands = errands.OrderBy(e => e.ErrandDate);
                        break;
                    case "date_desc":
                        errands = errands.OrderByDescending(e => e.ErrandDate);
                        break;
                    default:
                        errands = errands.OrderBy(e => e.ErrandDate);
                        break;
                }
            return View(await errands.AsNoTracking().ToListAsync());
            
        }

        // GET: Errands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var errand = await _context.Errand
                .FirstOrDefaultAsync(m => m.Id == id);
            if (errand == null)
            {
                return NotFound();
            }

            return View(errand);
        }

        // GET: Errands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Errands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ErrandDate,ErrandStatus,ErrandPrice,Note")] Errand errand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(errand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(errand);
        }

        // GET: Errands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var errand = await _context.Errand.FindAsync(id);
            if (errand == null)
            {
                return NotFound();
            }
            return View(errand);
        }

        // POST: Errands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ErrandDate,ErrandStatus,ErrandPrice,Note")] Errand errand)
        {
            if (id != errand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(errand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ErrandExists(errand.Id))
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
            return View(errand);
        }

        // GET: Errands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var errand = await _context.Errand
                .FirstOrDefaultAsync(m => m.Id == id);
            if (errand == null)
            {
                return NotFound();
            }

            return View(errand);
        }

        // POST: Errands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var errand = await _context.Errand.FindAsync(id);
            _context.Errand.Remove(errand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ErrandExists(int id)
        {
            return _context.Errand.Any(e => e.Id == id);
        }
    }
}
