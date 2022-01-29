using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SosWebApp.Data;
using SosWebApp.Models;

namespace SosWebApp.Controllers
{
    public class TriageCodeController : Controller
    {
        private readonly ContextoBD _context;

        public TriageCodeController(ContextoBD context)
        {
            _context = context;
        }

        // GET: TriageCode
        public async Task<IActionResult> Index()
        {
            return View(await _context.TriageCodes.ToListAsync());
        }

        // GET: TriageCode/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var triageCode = await _context.TriageCodes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (triageCode == null)
            {
                return NotFound();
            }

            return View(triageCode);
        }

        // GET: TriageCode/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TriageCode/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LegalName,TarifaRegular")] TriageCode triageCode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(triageCode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(triageCode);
        }

        // GET: TriageCode/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var triageCode = await _context.TriageCodes.FindAsync(id);
            if (triageCode == null)
            {
                return NotFound();
            }
            return View(triageCode);
        }

        // POST: TriageCode/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,LegalName,TarifaRegular")] TriageCode triageCode)
        {
            if (id != triageCode.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(triageCode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TriageCodeExists(triageCode.Id))
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
            return View(triageCode);
        }

        // GET: TriageCode/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var triageCode = await _context.TriageCodes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (triageCode == null)
            {
                return NotFound();
            }

            return View(triageCode);
        }

        // POST: TriageCode/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var triageCode = await _context.TriageCodes.FindAsync(id);
            _context.TriageCodes.Remove(triageCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TriageCodeExists(int id)
        {
            return _context.TriageCodes.Any(e => e.Id == id);
        }
    }
}
