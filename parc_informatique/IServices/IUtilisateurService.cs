using ParcInformatiqueData.Entities;

namespace ParcInformatiqueWeb.IServices
{
    public interface IUtilisateurService
    {
        void AddUser(Utilisateur user);
        IEnumerable<Utilisateur> GetAllUsers();
    }
}
