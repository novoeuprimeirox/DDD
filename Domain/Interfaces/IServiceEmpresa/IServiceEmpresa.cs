using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.IServiceEmpresa
{
    public interface IServiceEmpresa
    {
        Task<List<Empresa>> GetAll();
        Task<Empresa> Get(int id);
        Task AddEmpresa(Empresa empresa);
        Task UpdateEmpresa(Empresa empresa);
        Task DeleteEmpresa(Empresa empresa);
    }


}
