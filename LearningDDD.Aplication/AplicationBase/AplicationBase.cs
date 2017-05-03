using System;
using System.Linq;
using LearningDDD.Aplication.Interface.InterfaceBase;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Aplication.AplicationBase
{
    public class AplicationBase<T> : IAplicationBase<T> where T : class, new()
    {
        private readonly IServiceBase<T> _service;
        public AplicationBase(IServiceBase<T> service)
        {
            _service = service;
        }
        public void Delete(T obj)
        {
            try
            {
                _service.Delete(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            _service.Dispose();
        }

        public IQueryable GetAll()
        {
            try
            {
                var result = _service.GetAll();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T GetById(int id)
        {
            try
            {
                var result = _service.GetById(id);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T Insert(T obj)
        {
            try
            {
                _service.Insert(obj);
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T Update(T obj)
        {
            try
            {
                _service.Update(obj);
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
