using ParcInformatique.Data;
using ParcInformatique.Data.Entities;
using ParcInformatique.Web.IServices;
using ParcInformatiqueWeb.IServices;
using System.Reflection.Metadata.Ecma335;

namespace ParcInformatiqueWeb.Service.cs
{
    public class EquipementService : IEquipementService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EquipementService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddEquipement(Equipement Equipements)
        {
            _unitOfWork.EquipementRepository.Add(Equipements);

            _unitOfWork.SaveChanges();
        }
        public IEnumerable<Equipement> GetAllEquipements()
        {
            IEnumerable<Equipement> listEquipements = _unitOfWork.EquipementRepository.GetAll();
            return listEquipements;
        }

    }

}
