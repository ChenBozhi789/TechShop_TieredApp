using BusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DataAccessLayer.Models.Admin_App.Forms
{
    public partial class EditItemForm : Form
    {
        private int _productId;
        private ProductModel _currentProduct;
        private readonly ProductService _productService;
        private readonly BrandService _brandService;

        public EditItemForm(int productId, ProductService productService, BrandService brandService)
        {
            InitializeComponent();
            _productId = productId;
            _productService = productService;
            _brandService = brandService;
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = cmbType.SelectedItem.ToString();

            if (selectedType == "Laptop")
            {
                ShowLaptopFields();
            }
            else if (selectedType == "Desktop")
            {
                ShowDesktopFields();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                btnSave.Text = "Saving...";

                // Apply admin input to the selected Product
                ApplyInputToCurrentProduct();

                _productService.UpdateProduct(_currentProduct);

                MessageBox.Show("Product updated successfully!");
                txtLMD.Text = DateTime.Now.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}");
            }
            finally
            {
                btnSave.Enabled = true;
                btnSave.Text = "Save";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // This method used to load the data from selected Product row
        public void LoadData()
        {
            try
            {
                // Get current selected Product (ProductModel)
                _currentProduct = _productService.Get(_productId);

                var brands = _brandService.GetAll();
                
                // Unbinding event temporally
                cmbBrand.SelectedIndexChanged -= cmbBrand_SelectedIndexChanged;

                cmbBrand.DataSource = brands;
                cmbBrand.DisplayMember = "Name";
                cmbBrand.ValueMember = "BrandID";
                
                cmbType.Items.Add("Laptop");
                cmbType.Items.Add("Desktop");

                // Fill out the corresponding field
                FillOutForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        // This method used to display the selected Product details on the Edit Form
        private void FillOutForm()
        {
            if (_currentProduct == null) return;

            // General fields
            txtName.Text = _currentProduct.Name;
            cmbBrand.SelectedValue = _currentProduct.BrandID;
            cmbType.SelectedIndex = 0; // 
            txtPrice.Text = _currentProduct.Price.ToString();
            txtStock.Text = _currentProduct.StockQuantity.ToString();                       
            txtDescription.Text = _currentProduct.Description;            
            txtCPU.Text = _currentProduct.CPU;
            txtGPU.Text = _currentProduct.GPU;
            txtMemory.Text = _currentProduct.Memory;            
            txtLMD.Text = _currentProduct.LastModifiedDate.ToString();
            txtLMD.Enabled = false;

            // Laptop fields
            if (_currentProduct is LaptopModel laptop)
            {
                ShowLaptopFields();
                txtBatteryLife.Text = laptop.BatteryLife.ToString();
                txtWeight.Text = laptop.Weight.ToString();
            }
            // Desktop fields
            else if (_currentProduct is DesktopModel desktop)
            {
                ShowDesktopFields();
                txtTowerSize.Text = desktop.TowerSize.ToString();
                txtPower.Text = desktop.PowerSupplyWattage.ToString();
                txtCoolSystem.Text = desktop.CoolingSystem.ToString();
            }
        }

        private void ShowLaptopFields()
        {
            // Display Laptop field
            lblLaptop.Visible = true;
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

        private void ShowDesktopFields()
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
            lblBatteryLife.Visible = false;
            lblWeight.Visible = false;

            txtBatteryLife.Visible = false;
            txtWeight.Visible = false;
        }

        private void ApplyInputToCurrentProduct()
        {
            // General fields
            _currentProduct.Name = txtName.Text.Trim();

            _currentProduct.BrandID = (int)cmbBrand.SelectedValue;
            // Here is a question
            _currentProduct.ProductType = cmbType.SelectedItem.ToString();
            _currentProduct.Price = decimal.Parse(txtPrice.Text.Trim());
            _currentProduct.StockQuantity = int.Parse(txtStock.Text.Trim());            
            _currentProduct.Description = txtDescription.Text.Trim();
            _currentProduct.CPU = txtCPU.Text.Trim();
            _currentProduct.GPU = txtGPU.Text.Trim();
            _currentProduct.Memory = txtMemory.Text.Trim();

            // Laptop unique field
            if (_currentProduct is LaptopModel laptop)
            {
                laptop.BatteryLife = int.Parse(txtBatteryLife.Text.Trim());
                laptop.Weight = int.Parse(txtWeight.Text.Trim());
            }
            // Desktop unique field
            else if (_currentProduct is DesktopModel desktop)
            {
                desktop.TowerSize = txtTowerSize.Text.Trim();
                desktop.PowerSupplyWattage = int.Parse(txtPower.Text.Trim());
                desktop.CoolingSystem = txtCoolSystem.Text.Trim();
            }
        }
    }
}
