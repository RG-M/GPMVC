using Microsoft.EntityFrameworkCore;
using ParcInformatique.Data.Entities;
using ParcInformatique.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatique.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private Dictionary<Type, object> _repositories;

        private IRepository<Utilisateur> _UtilisateurRepository;
        private IRepository<Equipement> _EquipementRepository;


        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return (IRepository<TEntity>)_repositories[typeof(TEntity)];
            }

            var repository = new Repository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public IRepository<Utilisateur> UtilisateurRepository => _UtilisateurRepository ?? (_UtilisateurRepository = new Repository<Utilisateur>(_context));
        public IRepository<Equipement> EquipementRepository => _EquipementRepository ?? (_EquipementRepository = new Repository<Equipement>(_context));

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
