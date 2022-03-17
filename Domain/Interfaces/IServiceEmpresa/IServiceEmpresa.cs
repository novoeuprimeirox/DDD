using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IServiceEmpresa
{
    public interface IServiceEmpresa
    {
        Task<List<Empresa>> Listar();
        Task<List<Empresa>> ListarId(int id);
        Task AddProduct(Empresa empresa);
        Task UpdateEmpresa(Empresa empresa);
        Task DeleteEmpresa(Empresa empresa);
    }


}
