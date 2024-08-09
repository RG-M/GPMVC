using ParcInformatique.Data.Entities;

namespace ParcInformatique.Web.IServices
{
    public interface IEquipementService
    {
        void AddEquipement(Equipement Equipements);
        IEnumerable<Equipement> GetAllEquipements();
    }
}
