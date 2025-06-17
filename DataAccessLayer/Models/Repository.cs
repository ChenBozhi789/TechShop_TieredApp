using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    // Need to understand
    public abstract class Repository
    {
        // Constructor
        // Confusion: 它接受一个 DbContext（比如你的 ModelContext）并保存起来，供子类使用。 DONE
        public Repository(DbContext context)
        {
            Context = context;
        }

        protected DbContext Context { get; private set; }
    }
}
