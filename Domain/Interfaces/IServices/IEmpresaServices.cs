using Domain.Interfaces.Generics;
using Entities;

namespace Domain.Interfaces.IServices
{
    public interface IEmpresaServices :IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        
    }
}
