using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Norhtwind.DataAccess.Concrete.NHibernate;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.WebForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {

            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";


            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";


            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";

        }

        private object LoadProducts()
        {
            return dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                {
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    Price = Convert.ToDecimal(tbxAddPrice.Text),
                    ProductName = tbxAddProductName.Text,
                    Unit = tbxAddUnit.Text,

                });
                LoadProducts();
                MessageBox.Show(tbxAddProductName.Text + " isimli Urun Kayit edildi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product()
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpdateProductName.Text,
                CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                Price = Convert.ToDecimal(tbxUpdatePrice.Text),
                Unit = tbxUpdateUnit.Text,
            });
            LoadProducts();
            MessageBox.Show(tbxUpdateProductName.Text + " isimli Urun Guncellendi.");

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdateUnit.Text= dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdatePrice.Text= dgwProduct.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    string propName = dgwProduct.CurrentRow.Cells[1].Value.ToString();
                    _productService.Delete(new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
                    LoadProducts();
                    MessageBox.Show(propName + " isimli Urun Silindi.");
                }
                catch(Exception excaption)
                {
                    MessageBox.Show(excaption.Message);
                }
              
            }
        }

    }
}
