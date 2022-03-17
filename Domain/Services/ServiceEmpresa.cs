using Domain.Interfaces.Generics;
using Domain.Interfaces.IServices;
using Entities;

namespace Domain.Services
{
    public class ServiceEmpresa : IEmpresaServices
    {
        private readonly IEmpresaServices _repository;
        public ServiceEmpresa(IEmpresaServices repository)
        {
            _repository = repository;
        }

        public void Add<T>(T entity) where T : class
        {
            _repository.Add(entity);
        }
          
        public void Delete<T>(T entity) where T : class
        {
            _repository.Delete(entity);
        }
         

        public Empresa[] GetAll()
        {
           return _repository.GetAll();
        }

        public Empresa GetById(int id)
        {
            return _repository.GetById(id);
        }
         
        public bool SaveChanges()
        {
           return _repository.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            _repository.Update(entity);    
        }
         
    }
}
