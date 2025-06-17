using BusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer.Models.Admin_App.Forms
{
    public partial class AddItemForm : Form
    {
        private readonly ProductService _productService;
        private readonly BrandService _brandService;

        public AddItemForm(ProductService productService, BrandService brandService)
        {
            InitializeComponent();

            _productService = productService;
            _brandService = brandService;
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            var brands = _brandService.GetAll();
            cmbBrand.DataSource = brands;
            cmbBrand.DisplayMember = "Name";
            // Real value is the BrandID (For saving)
            cmbBrand.ValueMember = "BrandID";
            if (cmbBrand.Items.Count > 0) cmbBrand.SelectedIndex = 0;

            cmbType.Items.Add("Laptop");
            cmbType.Items.Add("Desktop");
            cmbType.SelectedIndex = 0;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbType.SelectedItem.ToString();

            if (selectedType == "Laptop")
            {
                // Display Laptop field
                lblBatteryLife.Visible = true;
                lblWeight.Visible = true;
                txtBatteryLife.Visible = true;
                txtWeight.Visible = true;

                // Hide Desktop field
                lblDesktop.Visible = false;
                lblTowerSize.Visible = false;
                lblPower.Visible = false;
                lblCoolSystem.Visible = false;

                txtTowerSize.Visible = false;
                txtPower.Visible = false;
                txtCoolSystem.Visible = false;
            }
            else if (selectedType == "Desktop")
            {
                // Display Desktop field
                lblDesktop.Visible = true;
                lblTowerSize.Visible = true;
                lblPower.Visible = true;
                lblCoolSystem.Visible = true;

                txtTowerSize.Visible = true;
                txtPower.Visible = true;
                txtCoolSystem.Visible = true;

                // Hide Laptop field
                lblLaptop.Visible = false;
                lblLaptop.Visible = false;
                lblBatteryLife.Visible = false;
                lblWeight.Visible = false;

                txtBatteryLife.Visible = false;
                txtWeight.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var productModel = new ProductModel
                {
                    // Convert string to the int
                    BrandID = (int)cmbBrand.SelectedValue,
                    Name = txtName.Text.Trim(),
                    ProductType = cmbType.SelectedItem.ToString(),
                    Price = decimal.Parse(txtPrice.Text.Trim()),
                    StockQuantity = int.Parse(txtStock.Text.Trim()),
                    Description = txtDescription.Text.Trim(),
                    LastModifiedDate = DateTime.Now,
                };

                if (productModel.ProductType == "Laptop")
                {
                    var newLaptop = new LaptopModel
                    {
                        BrandID = productModel.BrandID,
                        Name = productModel.Name,
                        Description = productModel.Description,
                        Price = productModel.Price,

                        ProductImage = "TEST.jpg",
                        PublishedDate = DateTime.Now,

                        StockQuantity = productModel.StockQuantity,
                        LastModifiedDate = productModel.LastModifiedDate,

                        CPU = txtCPU.Text.Trim(),
                        GPU = txtCPU.Text.Trim(),
                        Memory = txtMemory.Text.Trim(),
                        BatteryLife = int.Parse(txtBatteryLife.Text.Trim()),
                        Weight = int.Parse(txtWeight.Text.Trim()),

                        ProductType = productModel.ProductType
                    };

                    _productService.AddLaptop(newLaptop);
                }
                else if (productModel.ProductType == "Desktop")
                {
                    var newDesktop = new DesktopModel
                    {
                        BrandID = productModel.BrandID,
                        Name = productModel.Name,
                        Description = productModel.Description,
                        Price = productModel.Price,

                        ProductImage = "TEST.jpg",
                        PublishedDate = DateTime.Now,

                        StockQuantity = productModel.StockQuantity,
                        LastModifiedDate = productModel.LastModifiedDate,

                        CPU = txtCPU.Text.Trim(),
                        GPU = txtCPU.Text.Trim(),
                        Memory = txtMemory.Text.Trim(),
                        TowerSize = txtTowerSize.Text.Trim(),
                        PowerSupplyWattage = int.Parse(txtPower.Text.Trim()),
                        CoolingSystem = txtCoolSystem.Text.Trim(),
                        
                        ProductType = productModel.ProductType
                    };
                    _productService.AddDesktop(newDesktop);
                }

                MessageBox.Show("Item added successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // GPT suggestion: To print the inner error
                string error = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show($"Error: {error}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
