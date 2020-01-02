using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Śluber.Data;
using Śluber.Models;

namespace Śluber.Controllers
{
    public class ServiceProvsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceProvsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServiceProvs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServiceProv.ToListAsync());
        }

        // GET: ServiceProvs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProv = await _context.ServiceProv
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceProv == null)
            {
                return NotFound();
            }

            return View(serviceProv);
        }

        // GET: ServiceProvs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceProvs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ServiceType,Price")] ServiceProv serviceProv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceProv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceProv);
        }

        // GET: ServiceProvs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProv = await _context.ServiceProv.FindAsync(id);
            if (serviceProv == null)
            {
                return NotFound();
            }
            return View(serviceProv);
        }

        // POST: ServiceProvs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ServiceType,Price")] ServiceProv serviceProv)
        {
            if (id != serviceProv.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceProv);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceProvExists(serviceProv.Id))
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
            return View(serviceProv);
        }

        // GET: ServiceProvs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProv = await _context.ServiceProv
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceProv == null)
            {
                return NotFound();
            }

            return View(serviceProv);
        }

        // POST: ServiceProvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceProv = await _context.ServiceProv.FindAsync(id);
            _context.ServiceProv.Remove(serviceProv);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceProvExists(int id)
        {
            return _context.ServiceProv.Any(e => e.Id == id);
        }
    }
}
