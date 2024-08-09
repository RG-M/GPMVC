using ParcInformatique.Data.Entities;

namespace ParcInformatiqueWeb.IServices
{
    public interface IGererEquipementUserService
    {
        void AddUser(Utilisateur user);
        IEnumerable<Utilisateur> GetAllUsers();
    }
}
