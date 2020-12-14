using Domain.Repository;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        protected readonly eShopContext _eShopContext;
        public EFRepository(eShopContext eShopContext)
        {
            _eShopContext = eShopContext;
        }

        public void Add(T entity)
        {
            _eShopContext.Set<T>().Add(entity);
            _eShopContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _eShopContext.Set<T>().Remove(entity);
            _eShopContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _eShopContext.Set<T>().ToList();
        }

        public T GetBy(int id)
        {
            return _eShopContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _eShopContext.Set<T>().Update(entity);
            _eShopContext.SaveChanges();
        }
    }
}
