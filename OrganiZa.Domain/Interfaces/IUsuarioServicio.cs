using OrganiZa.Domain.Entities;
using OrganiZa.Infraestructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenCoolMart.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task AddUsuario(User producto);
        Task DeleteUsuario(int id);
        Task<IEnumerable<User>> GetUsuarios();
        Task<User> GetUsuario(int id);
        Task UpdateUsuario(User producto);
    }
}
