using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class OrderRepository : Repository, IOrderRepository
    {
        public OrderRepository(ModelContext context) : base(context)
        {

        }

        // It is not a method, is a attribute
        protected virtual IQueryable<Order> All
        {
            // Context.Set<Order>() 的意思是：从数据库中找到 Order 这一张表
            get { return Context.Set<Order>(); }
        }

        // Add a new Order row to the database
        public virtual void Add(Order instance)
        {
            if (instance != null)
            {
                Context.Set<Order>().Add(instance);
            }
        }

        // Fina a Order according to OrderID
        public virtual Order Get(int id)
        {
            // 告诉 EF 在查询主表数据时，同时把“导航属性”对应的相关表的数据也一并查出来。
            return All.Include(a => a.OrderedProduct).FirstOrDefault(a => a.OrderID == id);
        }

        // Find the Order by Order and Delete it
        public virtual void Delete(int id)
        {
            Delete(Get(id));
        }

        // Delete the passed-in Order directly
        public virtual void Delete(Order instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Deleted;
            }
        }

        // Mark the status of the Order as "Modified"
        public virtual void Update(Order instance)
        {
            if (instance != null)
            {
                // Context.Entry(instance) will return a object EntityEntry<Order>, It is
                // used to represent the state tracking information of this Order entity in EF Core.
                Context.Entry(instance).State = EntityState.Modified;
            }
        }

        // List all Orders
        public virtual IEnumerable List()
        {
            return All.ToList();
        }
    }
}
