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
    public class ServiceController : Controller
    {
        private readonly ContextoBD _context;

        public ServiceController(ContextoBD context)
        {
            _context = context;
        }

        // GET: Service
        public async Task<IActionResult> Index()
        {
            var contextoBD = _context.Services.Include(s => s.Guard).Include(s => s.TriageCode);
            return View(await contextoBD.ToListAsync());
        }

        // GET: Service/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Guard)
                .Include(s => s.TriageCode)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Service/Create
        public IActionResult Create()
        {
            ViewData["GuardId"] = new SelectList(_context.Guards, "Id", "Name");
            ViewData["TriageCodeId"] = new SelectList(_context.TriageCodes, "Id", "Name");
            return View();
        }

        // POST: Service/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NroIncidente,Fecha,Hora,Paciente,Dx,Obs,TriageCodeId,Coseguro,IsPlus,GuardId")] Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GuardId"] = new SelectList(_context.Guards, "Id", "Name", service.GuardId);
            ViewData["TriageCodeId"] = new SelectList(_context.TriageCodes, "Id", "Name", service.TriageCodeId);
            return View(service);
        }

        // GET: Service/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            ViewData["GuardId"] = new SelectList(_context.Guards, "Id", "Name", service.GuardId);
            ViewData["TriageCodeId"] = new SelectList(_context.TriageCodes, "Id", "Name", service.TriageCodeId);
            return View(service);
        }

        // POST: Service/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NroIncidente,Fecha,Hora,Paciente,Dx,Obs,TriageCodeId,Coseguro,IsPlus,GuardId")] Service service)
        {
            if (id != service.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.Id))
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
            ViewData["GuardId"] = new SelectList(_context.Guards, "Id", "Name", service.GuardId);
            ViewData["TriageCodeId"] = new SelectList(_context.TriageCodes, "Id", "Name", service.TriageCodeId);
            return View(service);
        }

        // GET: Service/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Guard)
                .Include(s => s.TriageCode)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Service/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(int id)
        {
            return _context.Services.Any(e => e.Id == id);
        }
    }
}
