using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Abstract
{
    public interface IRepository<T> where T : class,IBaseEntity
    {

        bool Add(T entity);
        bool AddRange(List<T> entities);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
        int Save();
    }
}
