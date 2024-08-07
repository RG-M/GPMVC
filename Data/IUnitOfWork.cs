using ParcInformatique.Data.Entities;
using ParcInformatique.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatique.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Utilisateur> UtilisateurRepository { get; }
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void SaveChanges();
    }
}
