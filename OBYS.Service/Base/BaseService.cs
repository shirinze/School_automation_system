using OBYS.Core.Entity;
using OBYS.Core.Service;
using OBYS.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Service.Base
{
    // T ifadesinin CoreEntity türünden olmasını istedik
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    { 
        private readonly OBYSContext _db;

        public BaseService(OBYSContext db)
        {
            _db = db;
        }

        public bool Add(T item)
        {
            try
            {
                _db.Set<T>().Add(item);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _db.Set<T>().Remove(GetByID(id));
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<T> GetAll() => _db.Set<T>().ToList();

        public T GetByID(int id) => _db.Set<T>().Find(id);

        public int Save()
        {
            return _db.SaveChanges();
        }

        public bool Update(T item)
        {
            try
            {
                _db.Set<T>().Update(item);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
