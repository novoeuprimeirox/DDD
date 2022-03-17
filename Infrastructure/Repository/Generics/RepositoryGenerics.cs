using Domain.Interfaces.Generics;
using Entities;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repository.Generics
{
    public class RepositoryGenerics : IRepository
    {
        private readonly ContextBase _contextBase;
        public RepositoryGenerics(ContextBase contextBase)
        {
            this._contextBase = contextBase;
        }


        public void Add<T>(T entity) where T : class
        {
            _contextBase.Add(entity);
            SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _contextBase.Remove(entity);
            SaveChanges();
        }

        public Empresa[] GetAll()
        {
            IQueryable<Empresa> query = _contextBase.Empresas;

            query = query.AsNoTracking()
                         .OrderBy(a => a.Id);

            return query.ToArray();
        }

        public Empresa GetById(int id)
        {
            IQueryable<Empresa> query = _contextBase.Empresas;

            query = query.AsNoTracking()
                         .OrderBy(a => a.Id)
                         .Where(pessoa => pessoa.Id == id);

            return query.FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return (_contextBase.SaveChanges() > 0);
        }

        public void Update<T>(T entity) where T : class
        {
            _contextBase.Update(entity);
            SaveChanges();
        }
    }
}
