using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        protected DbSet<T> Entities => Context.Set<T>();

        public Repository(ModelContext context)
        {
            Context = context;
        }

        // Lamba expression to get all entities of type T (Need to understand)
        //public virtual void Add(T entity) => Entities.Add(entity);

        public virtual void Add(T instance)
        {
            if (instance != null)
            {
                Context.Set<T>().Add(instance);
            }
        }

        //public virtual T Get(int id) => Entities.Find(id);

        public virtual T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        //public virtual List<T> GetAll() => Entities.ToList();

        public List<T> GetAll()
        {
            // Quary all product table and return list
            return Context.Set<T>().ToList();
        }

        public virtual void Update(T entity)
        {
            if (entity != null)
                Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            if (entity != null)
                Context.Entry(entity).State = EntityState.Deleted;
        }

        public virtual void Delete(int id)
        {
            var entity = Get(id);
            if (entity != null) Delete(entity);
        }



        public virtual IEnumerable<T> List() => Entities.ToList();
    }
}
