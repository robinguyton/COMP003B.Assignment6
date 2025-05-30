﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP003B.Assignment6.Data;
using COMP003B.Assignment6.Models;

namespace COMP003B.Assignment6.Controllers
{
    public class ActorsController : Controller
    {
        private readonly WebDevAcademyContext _context;

        public ActorsController(WebDevAcademyContext context)
        {
            _context = context;
        }

        // GET: Actors
        public async Task<IActionResult> Index()
        {

            return View(await _context.Actors.ToListAsync());
        }

        // GET: Actors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) 
            {
                return NotFound();
            }

            var actors = await _context.Actors
                .Include(a => a.ActorID)
                .Include(a => a.Director)
                .FirstOrDefaultAsync(m => m.ActorID == id);
            if (actors == null)
            {
                return NotFound();
            }

            // Get the movies the actors starred in


            ViewBag.Movies = from a in _context.Actors
                             join m in _context.Movies on a.ActorID equals m.Actor
                             join d in _context.Directors on a.Director equals d.DirectorID
                             where a.ActorID == id
                             select m;


            return View(actors);
        }

        // GET: Actors/Create
        public IActionResult Create()
        {
            ViewData["ActorId"] = new SelectList(_context.Actors, "Id", "Id");
            ViewData["DirectorId"] = new SelectList(_context.Directors, "DirectorID", "Name");
            return View();
        }

        // POST: Actors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ActorId,DirectorId")] Actor actors)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActorId"] = new SelectList(_context.Actors, "Id", "Id", actors.ActorID);
            ViewData["DirectorId"] = new SelectList(_context.Directors, "DirectorID", "Name", actors.Director);
            return View(actors);
        }

        // GET: Actors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actors = await _context.Actors.FindAsync(id);
            if (actors == null)
            {
                return NotFound();
            }
            ViewData["ActorId"] = new SelectList(_context.Actors, "Id", "Id", actors.ActorID);
            ViewData["DirectorId"] = new SelectList(_context.Directors, "DirectorID", "Name", actors.Director);
            return View(actors);
        }

        // POST: Actors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ActorId,DirectorId")] Actor actors)
        {
            if (id != actors.ActorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActorsExists(actors.ActorID))
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
            ViewData["ActorId"] = new SelectList(_context.Actors, "Id", "Id", actors.ActorID);
            ViewData["DirectorId"] = new SelectList(_context.Directors, "DirectorID", "Name", actors.Director);
            return View(actors);
        }

        // GET: Actors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actors = await _context.Actors
                .Include(a => a.Name)
                .Include(a => a.Director)
                .FirstOrDefaultAsync(m => m.ActorID == id);
            if (actors == null)
            {
                return NotFound();
            }

            return View(actors);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actors = await _context.Actors.FindAsync(id);
            if (actors != null)
            {
                _context.Actors.Remove(actors);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActorsExists(int id)
        {
            return _context.Actors.Any(e => e.ActorID == id);
        }
    }
}
