using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class BrandRepository : Repository, IBrandRepository
    {
        public BrandRepository(ModelContext context) : base(context)
        {

        }

        // It is not a method, is a attribute
        protected virtual IQueryable<Brand> All
        {
            get { return Context.Set<Brand>(); }
        }

        // Add a new Brand row to the database
        public virtual void Add(Brand instance)
        {
            if (instance != null)
            {
                Context.Set<Brand>().Add(instance);
            }
        }

        public List<Brand> GetAll()
        {
            return Context.Set<Brand>().ToList();  // 查询 Brand 表所有记录并返回列表
        }


        // Fina a Brand according to BrandID
        public virtual Brand Get(int id)
        {
            // 告诉 EF 在查询主表数据时，同时把“导航属性”对应的相关表的数据也一并查出来。
            return All.Include(a => a.Products).FirstOrDefault(a => a.BrandID == id);
        }

        // Mark the status of the Brand as "Modified"
        public virtual void Update(Brand instance)
        {
            if (instance != null)
            {
                // Context.Entry(instance) will return a object EntityEntry<Brand>, It is
                // used to represent the state tracking information of this Brand entity in EF Core.
                Context.Entry(instance).State = EntityState.Modified;
            }
        }

        // Find the Brand by Brand and Delete it
        public virtual void Delete(int id)
        {
            Delete(Get(id));
        }

        // Delete the passed-in Brand directly
        public virtual void Delete(Brand instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Deleted;
            }
        }

        // List all Brands
        public virtual IEnumerable List()
        {
            return All.ToList();
        }
    }
}
