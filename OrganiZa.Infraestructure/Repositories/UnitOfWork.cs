using OrganiZa.Domain.Interfaces;
using OrganiZa.Infraestructure.Data;
using OrganiZa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrganiZa.Infraestructure.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly OrganizarecContext _context;

     
        private readonly IRepository<User> _usuarioRepository;

        public UnitOfWork(OrganizarecContext context)
        {
            this._context = context;
        }

      
        public IRepository<User> UsuarioRepository => _usuarioRepository ?? new SQLRepository<User>(_context);

        public void Dispose()
        {
            if (_context == null)
                _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
