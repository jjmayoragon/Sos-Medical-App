﻿using System;
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
    public class GuardController : Controller
    {
        private readonly ContextoBD _context;

        public GuardController(ContextoBD context)
        {
            _context = context;
        }

        // GET: Guard
        public async Task<IActionResult> Index()
        {
            return View(await _context.Guards.ToListAsync());
        }

        // GET: Guard/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guard = await _context.Guards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guard == null)
            {
                return NotFound();
            }

            return View(guard);
        }

        // GET: Guard/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guard/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Start,Finish")] Guard guard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guard);
        }

        // GET: Guard/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guard = await _context.Guards.FindAsync(id);
            if (guard == null)
            {
                return NotFound();
            }
            return View(guard);
        }

        // POST: Guard/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Start,Finish")] Guard guard)
        {
            if (id != guard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuardExists(guard.Id))
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
            return View(guard);
        }

        // GET: Guard/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guard = await _context.Guards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guard == null)
            {
                return NotFound();
            }

            return View(guard);
        }

        // POST: Guard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guard = await _context.Guards.FindAsync(id);
            _context.Guards.Remove(guard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuardExists(int id)
        {
            return _context.Guards.Any(e => e.Id == id);
        }
    }
}