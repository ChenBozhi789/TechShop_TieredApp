using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        // readonly 修饰符表示：这个字段只能在构造函数中被赋值，一旦赋值就不能再变。
        private readonly ModelContext _context;

        private Repository<Product> _productRepository;
        private Repository<Order> _orderRepository;
        private Repository<Brand> _brandRepository;

        private bool _disposed = false;

        // Constructor
        public UnitOfWork(ModelContext context)
        {
            _context = context;
        }

        // Need to understand
        public IRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new Repository<Product>(_context); // 修改为具体实现类
                }
                return _productRepository;
            }
        }

        // Need to understand
        public IRepository<Order> OrderRepository
        {
            get
            {
                if (_orderRepository == null) // 修复判断语法
                {
                    _orderRepository = new Repository<Order>(_context); // 修改为具体实现类
                }
                return _orderRepository;
            }
        }

        // Need to understand
        public IRepository<Brand> BrandRepository
        {
            get
            {
                if (_brandRepository == null)
                {
                    _brandRepository = new Repository<Brand>(_context); // 添加缺失部分
                }
                return _brandRepository;
            }
        }

        // 这是资源释放的标准写法，确保用完就释放内存。
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing) { _context.Dispose(); }
            }
            this._disposed = true;
        }

        // Releasing resource
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Save all changes for database
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
