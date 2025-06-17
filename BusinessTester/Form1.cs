using BusinessLayer;
using DataAccessLayer.Models;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DALTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 从用户输入获取品牌信息
                var brandModel = new BrandModel
                {
                    Name = txtName.Text.Trim(),                    
                    Manufacturer = txtManufacturer.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    Website = txtWebsite.Text.Trim()
                };

                // 2. 初始化数据库上下文（确保连接字符串设置正确）
                var options = new DbContextOptionsBuilder<ModelContext>()
                    .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SDV701ComputerApp;Trusted_Connection=True;")
                    .Options;

                using var context = new ModelContext(options);

                // 3. 创建 UnitOfWork 和 BrandService
                var unitOfWork = new UnitOfWork(context);
                var brandService = new BrandService(unitOfWork);

                // 4. 添加品牌
                brandService.Add(brandModel);

                // 5. 弹出成功提示
                MessageBox.Show("品牌添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加失败：{ex.Message}");
            }
        }
    }
}
