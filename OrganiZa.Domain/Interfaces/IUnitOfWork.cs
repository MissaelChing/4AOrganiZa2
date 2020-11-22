using OrganiZa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrganiZa.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {

        public IRepository<OrganiZa.Domain.Entities.User> UsuarioRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
