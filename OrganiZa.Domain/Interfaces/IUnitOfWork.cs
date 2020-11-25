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
        public IRepository<OrganiZa.Domain.Entities.Calendario> CalendarioRepository { get; }
        public IRepository<OrganiZa.Domain.Entities.Escuela> EscuelaRepository { get; }
        public IRepository<OrganiZa.Domain.Entities.Administrador> AdmministradorRepository { get; }
        public IRepository<OrganiZa.Domain.Entities.Tutor> TutorRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
