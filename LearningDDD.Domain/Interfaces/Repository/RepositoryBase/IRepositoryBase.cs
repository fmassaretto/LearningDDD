using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDDD.Domain.Interfaces.Repository.RepositoryBase
{
    public interface IRepositoryBase<T> : IDisposable where T : class, new()
    {
        IQueryable GetAll();
        T GetById(int id);
        T Insert(T obj);
        T Update(T obj);
        void Delete(T obj);

    }
}
