using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ProductRepository : Repository, IProductRepository
    {
        public ProductRepository(ModelContext context) : base(context)
        {

        }

        // It is not a method, is a attribute
        protected virtual IQueryable<Product> All
        {
            // Context.Set<Product>() 的意思是：从数据库中找到 Product 这一张表
            get { return Context.Set<Product>(); }
        }

        // Add a new product row to the database
        public virtual void Add(Product instance)
        {
            if (instance != null)
            {
                Context.Set<Product>().Add(instance);
            }
        }

        public virtual Product Get(int id)
        {
            // FirstOrDefault 会返回符合条件的第一条记录；如果找不到就返回 null。
            // 告诉 EF 在查询主表数据时，同时把“导航属性”对应的相关表的数据也一并查出来。
            return All.Include(a => a.Orders).FirstOrDefault(a => a.ProductID == id);
        }

        public List<Product> GetAll()
        {
            // Quary all product table and return list
            return Context.Set<Product>().ToList();
        }

        // Find the Product by Product and Delete it
        public virtual void Delete(int id)
        {
            Delete(Get(id));
        }

        // Delete the passed-in Product directly
        public virtual void Delete(Product instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Deleted;
            }
        }

        // Mark the status of the Product as "Modified"
        public virtual void Update(Product instance)
        {
            if (instance != null)
            {
                // Context.Entry(instance) will return a object EntityEntry<Product>, It is
                // used to represent the state tracking information of this Product entity in EF Core.
                Context.Entry(instance).State = EntityState.Modified;
            }
        }

        // List all products
        public virtual IEnumerable List()
        {
            return All.ToList();
        }
    }
}
