using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ParcInformatique.Data;
using ParcInformatique.Data.Entities;

namespace ParcInformatique.Web.Controllers
{
    public class EquipementsController : Controller
    {
        private readonly ApplicationContext _context;

        public EquipementsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Equipements
        public async Task<IActionResult> Index()
        {
            return View(await _context.Equipements.ToListAsync());
        }

        // GET: Equipements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipement = await _context.Equipements
                .FirstOrDefaultAsync(m => m.num_serie == id);
            if (equipement == null)
            {
                return NotFound();
            }

            return View(equipement);
        }

        // GET: Equipements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("num_serie,libelle,marque")] Equipement equipement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipement);
        }

        // GET: Equipements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipement = await _context.Equipements.FindAsync(id);
            if (equipement == null)
            {
                return NotFound();
            }
            return View(equipement);
        }

        // POST: Equipements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("num_serie,libelle,marque")] Equipement equipement)
        {
            if (id != equipement.num_serie)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipementExists(equipement.num_serie))
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
            return View(equipement);
        }

        // GET: Equipements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipement = await _context.Equipements
                .FirstOrDefaultAsync(m => m.num_serie == id);
            if (equipement == null)
            {
                return NotFound();
            }

            return View(equipement);
        }

        // POST: Equipements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipement = await _context.Equipements.FindAsync(id);
            if (equipement != null)
            {
                _context.Equipements.Remove(equipement);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipementExists(int id)
        {
            return _context.Equipements.Any(e => e.num_serie == id);
        }
    }
}
