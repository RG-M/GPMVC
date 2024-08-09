using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ParcInformatique.Data;
using ParcInformatique.Data.Entities;
using ParcInformatique.Web.Models;

namespace ParcInformatique.Web.Controllers
{
    public class EquipementsController : Controller
    {
        private readonly ApplicationContext _context;
        private object _logger;

        public object Label1 { get; private set; }

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
                .FirstOrDefaultAsync(m => m.Id == id);
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
        public async Task<IActionResult> Create([Bind("num_serie,libelle,marque")] ParcInformatique.Data.Entities.Equipement equipement)
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
            if (id != equipement.Id)
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
                    if (!EquipementExists(equipement.Id))
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
                .FirstOrDefaultAsync(m => m.Id == id);
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
            return _context.Equipements.Any(e => e.Id == id);
        }

        // GET: Equipements/Gerer
        public IActionResult GererEquipementsUser(string? id)
        {
            GereEquipementViewModel gereEquipementViewModel = new();

            List<Equipement> list = _context.Set<Equipement>().Where(x=> x.Utilisateur != null && x.Utilisateur.Id == id).Include(x=>x.Utilisateur).ToList();
            gereEquipementViewModel.Equipements = list;
            gereEquipementViewModel.IdUtilisateur = id;
            return View(gereEquipementViewModel);
        }

        public IActionResult DeleteEquipementsUser(int? id)
        {
            string idUser = "";
            Equipement eq = _context.Set<Equipement>().Where(equipement => equipement.Id == id).Include(x => x.Utilisateur).FirstOrDefault();
            idUser = eq.Utilisateur.Id;
            eq.Utilisateur = null;
            _context.SaveChanges();
            return RedirectToAction("GererEquipementsUser", new { id = idUser });
        }

        //public IActionResult AddEquipementsUser(int idUtilisateur, int idEquipement)
        //{
        //    try
        //    {

        //        //bool isAdded = _equipmentService.AddEquipmentToUser(idUtilisateur, idEquipement);

        //        if (isAdded)
        //        {
        //            TempData["SuccessMessage"] = "L'équipement a été ajouté avec succès à l'utilisateur.";
        //        }
        //        else
        //        {
        //            TempData["ErrorMessage"] = "Une erreur est survenue lors de l'ajout de l'équipement.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        //_EquipementsController.LogError(ex, "Erreur lors de l'ajout de l'équipement {IdEquipement} à l'utilisateur {IdUtilisateur}", idEquipement, idUtilisateur);

        //        TempData["ErrorMessage"] = "Une erreur inattendue est survenue. Veuillez réessayer plus tard.";
        //    }


        //    return RedirectToAction("UserEquipments", new { id = idUtilisateur });
        //}

        [HttpPost]
        public IActionResult AddEquipementsUser(AddEquipementUserViewModel model)
        {
            int a = 0;
            return RedirectToAction();
        }
       


        //public ActionResult AddUtilisateur(int id)
        //{
        //    UtilisateurViewModel Equipements = new UtilisateurtViewModel();
        //    Utilisateurs.PostID = id;
        //    return View(Utilisateurs);
        //}
        //[HttpPost]
        //public ActionResult AddUtilisateurs(UtilisateurViewModel Utilisateurs, HttpPostedFileBase Utilisateurs)
        //{
        //    Utilisateur newUtilisateur = new Utilisateur();
        //    newUtilisateur.ID = Equipement.UtilisateurID;
        //    return View("Index");
        //}
    }
}
