using Models; // for BrandModel
using DataAccessLayer; // for ModelContext and UnitOfWork
using Microsoft.EntityFrameworkCore; // for DbContextOptionsBuilder
using BusinessLayer; // for BrandService
using DataAccessLayer.Models;

namespace BusinessLayerTESTER
{
    public partial class TEST_FORM : Form
    {
        public TEST_FORM()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBrand_Click_1(object sender, EventArgs e)
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
                // LocalDB instance - SDV701ComputerApp
                var options = new DbContextOptionsBuilder<ModelContext>()
                    .UseSqlServer("Server=(localdb)\\SDV701ComputerApp;Database=ComputerStoreDB;Trusted_Connection=True;")
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
