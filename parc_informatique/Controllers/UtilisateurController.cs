using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParcInformatique.Data.Entities;
using ParcInformatiqueWeb.IServices;

namespace ParcInformatique.Web.Controllers
{
    public class UtilisateurController : Controller
    {
        private readonly IGererEquipementUserService _utilisateurService;

        public UtilisateurController(IGererEquipementUserService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }
        // GET: UtilisateurController
        public ActionResult Index()
        {
            List<Utilisateur> list = _utilisateurService.GetAllUsers().ToList();
            return View("~/Views/Utilisateur/Index.cshtml", list);
        }

        // GET: UtilisateurController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UtilisateurController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UtilisateurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UtilisateurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UtilisateurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
    }
}
