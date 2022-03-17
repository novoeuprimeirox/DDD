using Domain.Interfaces.InterfaceEmpresa;
using Domain.Interfaces.IServiceEmpresa;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceEmpresa : IServiceEmpresa
    {
        private readonly IEmpresa _repository;
        public ServiceEmpresa(IEmpresa repository)
        {
            _repository = repository;   
        }
        public Task AddEmpresa(Empresa empresa)
        {
          return  _repository.Add(empresa);
        }

        public Task DeleteEmpresa(Empresa empresa)
        {
            return _repository.Delete(empresa);
        }

        public Task<List<Empresa>> GetAll()
        {
            return _repository.List();
        }

        public Task<Empresa> Get(int id)
        {
            return _repository.GetEntityById(id);
        }

        public Task UpdateEmpresa(Empresa empresa)
        {
            return _repository.Update(empresa);
        }
    }
}
