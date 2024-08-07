using ParcInformatique.Data;
using ParcInformatique.Data.Entities;
using ParcInformatiqueWeb.IServices;
using System.Reflection.Metadata.Ecma335;

namespace ParcInformatiqueWeb.Service.cs
{
    public class UtilisateurService:IUtilisateurService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UtilisateurService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddUser(Utilisateur user)
        {
            // Additional logic, if any...

            _unitOfWork.SaveChanges();
        }

        public IEnumerable<Utilisateur> GetAllUsers()
        {
            IEnumerable<Utilisateur> listUsers =_unitOfWork.UtilisateurRepository.GetAll();
            return listUsers;
        }
    }

}
