//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ParcInformatique.Data;
//using ParcInformatique.Data.Entities;
//using ParcInformatiqueWeb.IServices;
//using System.Collections.Generic;
//using System.Linq;

//namespace ParcInformatique.Web.Controllers
//{
//    public class GererEquipementUserController : Controller
//    {
//        private readonly IGererEquipementUserService _gererEquipementUserService;
//        private readonly ApplicationContext _context;

//        // Correction du constructeur
        
//        public GererEquipementUserController(ApplicationContext context)
//        {
//            _context = context;
//        }

//        // GET: gererEquipementUser/Gerer
//        public IActionResult GererEquipementsUser(string? id)
//        {
//            List<Equipement> list = _context.Set<Equipement>().Where(x => x.Equipement != null && x.Equipement.Id == id).Include(x => x.Equipement).ToList();
//            return View(list);
//        }
//        // GET: gererEquipementUser/Gerer
//        public IActionResult Equipement(string? id)
//        {
//            List<Utilisateur> list = _context.Set<Utilisateur>().Where(x => x.Equipement != null && x.Equipement.Id == id).Include(x => x.Equipement).ToList();
//            return View(list);
//        }

//        // GET: gererEquipementUserController
//        public ActionResult Index()
//        {
//            // Correction de la liste pour utiliser la bonne méthode et le bon type
//            List<gererEquipementUser> list = _gererEquipementUserService.GetAllUsers().ToList();
//            return View("~/Views/GererEquipementUser/Index.cshtml", list);
//        }

//        // GET: GererEquipementUserController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: GererEquipementUserController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: GererEquipementUserController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: GererEquipementUserController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: GererEquipementUserController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: GererEquipementUserController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: GererEquipementUserController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
