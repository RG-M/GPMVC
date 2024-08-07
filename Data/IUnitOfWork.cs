using ParcInformatiqueData.Entities;
using ParcInformatiqueData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatiqueData
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Utilisateur> UtilisateurRepository { get; }
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void SaveChanges();
    }
}
