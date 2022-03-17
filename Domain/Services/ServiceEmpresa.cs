using Domain.Interfaces.InterfaceEmpresa;
using Domain.Interfaces.IServiceEmpresa;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceEmpresa : IServiceEmpresa
    {
        private readonly IEmpresa _repository;
        public ServiceEmpresa(IEmpresa repository)
        {

        }
        public Task AddProduct(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmpresa(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public Task<List<Empresa>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<List<Empresa>> ListarId(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmpresa(Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
