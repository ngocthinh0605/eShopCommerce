using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IEnumerable<T> GetAll();
        T GetBy(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
