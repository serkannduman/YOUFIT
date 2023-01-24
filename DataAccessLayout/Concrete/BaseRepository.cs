using DataAccessLayout.Abstract;
using DataAccessLayout.Context;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class, IBaseEntity
    {

        private readonly YouFitDbContext _youFitDbContext;
        private DbSet<T> _table;

        public BaseRepository(YouFitDbContext youFitDbContext)
        {
            _youFitDbContext = youFitDbContext;
            _table = _youFitDbContext.Set<T>();
        }

        public bool Add(T entity)
        {
            _table.Add(entity);
            return Save() > 0;
        }

        

        public bool AddRange(List<T> entities)
        {
            _table.AddRange(entities);
            return Save() > 0;
        }

        public bool Delete(T entity)
        {
            entity.Status=Status.Deleted;
            return Update(entity);
        }

        public List<T> GetAll()
        {
            return _table.Where(x=>x.Status==Status.Actived||x.Status==Status.Modified).ToList();
        }

        public T GetById(int id)
        {
            return _table.Find(id);
        }

        public int Save()
        {
            return _youFitDbContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            _youFitDbContext.Entry<T>(entity).State=EntityState.Modified;
            return Save() > 0;
        }
    }


}
