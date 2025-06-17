using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLayer;
using Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace DataAccessLayer.Models.Admin_App.Forms
{
    public partial class MainForm : Form
    {
        private ModelContext _context;
        private UnitOfWork _unitOfWork;
        private ProductService _productService;
        private BrandService _brandService;
        private List<ProductModel> _allProducts;
        private ProductModel _currentProduct;

        public MainForm()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<ModelContext>()
                .UseSqlServer("Server=(localdb)\\SDV701ComputerApp;Database=ComputerStoreDB;Trusted_Connection=True;")
                .Options;

            _context = new ModelContext(options);
            _unitOfWork = new UnitOfWork(_context);

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            IMapper mapper = mapperConfig.CreateMapper();

            _productService = new ProductService(_unitOfWork, mapper);
            _brandService = new BrandService(_unitOfWork, mapper);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBrandFilter();
            
            cmbSelection.Items.Add("Product");
            cmbSelection.Items.Add("Order");
            cmbSelection.SelectedIndex = 0;

            cmbSortBy.Items.Add("Name");
            cmbSortBy.Items.Add("ProductID");
        }

        private void LoadBrandFilter()
        {
            _allProducts = _productService.GetAll();
            var brands = _brandService.GetAll();

            // Unbinding event
            cmbFilter.SelectedIndexChanged -= cmbFilter_SelectedIndexChanged;

            cmbFilter.DataSource = brands;
            cmbFilter.DisplayMember = "Name";
            cmbFilter.ValueMember = "BrandID";

            // Initialize DataGridView control - Display all products
            dataGridView.DataSource = _allProducts.Select(p => new
            {
                p.ProductID,
                p.Name,
                p.Price,
                p.StockQuantity,
                p.PublishedDate,
                Type = p is LaptopModel ? "Laptop" : "Desktop"
            }).ToList();

            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem is BrandModel selectedBrand)
            {
                lblManufacturer.Text = $"Manufacturer: {selectedBrand.Manufacturer}";
                lblCountry.Text = $"Country: {selectedBrand.Country}";
                lblWebsite.Text = $"Website: {selectedBrand.Website}";

                // Store BrandID to variable brandID
                int brandId = selectedBrand.BrandID;

                // _allProducts type: List<ProductModel>
                var filtered = _allProducts
                    .Where(p => p.BrandID == brandId)
                    .Select(p => new
                    {
                        p.ProductID,
                        p.Name,
                        p.Price,
                        p.StockQuantity,
                        p.PublishedDate,
                        Type = p is LaptopModel ? "Laptop" : "Desktop"
                    })
                    .ToList();

                dataGridView.DataSource = filtered;
            }
        }

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort = cmbSortBy.SelectedItem as string;

            var sorted = _allProducts.AsEnumerable();

            if (sort == "Name")
            {
                sorted = sorted.OrderBy(p => p.Name);
            } else if (sort == "ProductID")
            {
                sorted = sorted.OrderBy(p => p.ProductID);
            }

            var displayList = sorted.Select(p => new
            {
                p.ProductID,
                p.Name,
                p.Price,
                p.StockQuantity,
                p.PublishedDate,
                Type = p is LaptopModel ? "Laptop" : "Desktop"
            }).ToList();

            dataGridView.DataSource = displayList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddItemForm(_productService, _brandService);
            addForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            // Select Product row and pass ProductID to EditForm
            var selectedNote = dataGridView.SelectedRows[0];
            int productId = Convert.ToInt32(selectedNote.Cells["ProductID"].Value);

            var editForm = new EditItemForm(productId, _productService, _brandService);
            editForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product to edit.");
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?\r\n (Note: This action is irreversible!)", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var selectedNote = dataGridView.SelectedRows[0];
                        // Get and store ProductID
                        int productId = Convert.ToInt32(selectedNote.Cells["ProductID"].Value);
                        _currentProduct = _productService.Get(productId);
                        _productService.DeleteProduct(_currentProduct);

                        MessageBox.Show("Delete Success", "Delete Success");
                        LoadBrandFilter();
                    }
                    else
                    {
                        MessageBox.Show("This delete operation already canceled.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}");
            }           
        }
    }
}