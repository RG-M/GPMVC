using ParcInformatique.Data.Entities;

namespace ParcInformatique.Web.Models
{
    public class GereEquipementViewModel
    {
        public List<Equipement> Equipements { get; set; } 
        public string IdUtilisateur { get; set; }
        public GereEquipementViewModel() {
            Equipements = new List<Equipement>();
        }
    }

    public class AddEquipementUserViewModel
    {
        public int idEquipement { get; set; }
        public string? idUtilisateur { get; set; }
    }
}
