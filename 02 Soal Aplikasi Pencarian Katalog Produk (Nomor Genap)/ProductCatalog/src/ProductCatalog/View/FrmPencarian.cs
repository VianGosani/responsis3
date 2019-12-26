using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProductCatalog.Model.Entity;
using ProductCatalog.Controller;

namespace ProductCatalog.View
{
    public partial class FrmPencarian : Form
    {
        private List<Product> listOfProduct = new List<Product>();
        private ProductController controller;
        public FrmPencarian()
        {
            InitializeComponent();
            controller = new ProductController();
            InisialisasiListView();
            cmbFilter.SelectedIndex = 0;
        }

        private void InisialisasiListView()
        {
            lvwProduct.View = System.Windows.Forms.View.Details;
            lvwProduct.FullRowSelect = true;
            lvwProduct.GridLines = true;

            lvwProduct.Columns.Add("No.", 40, HorizontalAlignment.Center);
            lvwProduct.Columns.Add("Product Id", 120, HorizontalAlignment.Left);
            lvwProduct.Columns.Add("Product Name", 650, HorizontalAlignment.Left);
            lvwProduct.Columns.Add("Stock", 40, HorizontalAlignment.Center);
            lvwProduct.Columns.Add("Price", 70, HorizontalAlignment.Right);
            lvwProduct.Columns.Add("Category", 200, HorizontalAlignment.Left);
            lvwProduct.Columns.Add("Supplier", 200, HorizontalAlignment.Left);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // TODO: lengkapi kode untuk button cari
            lvwProduct.Items.Clear();
            if (cmbFilter.Text == "Category")
            {
                // panggil method ReadByNama dan tampung datanya ke dalam collection
                listOfProduct = controller.ReadByCategory(txtKeyword.Text);
                try
                {
                    // ekstrak objek mhs dari collection
                    foreach (var prd in listOfProduct)
                    {
                        var noUrut = lvwProduct.Items.Count + 1;
                        var stock = Convert.ToString(prd.stock);
                        var price = Convert.ToString(prd.price);

                        var item = new ListViewItem(noUrut.ToString());
                        item.SubItems.Add(prd.product_id);
                        item.SubItems.Add(prd.product_name);
                        item.SubItems.Add(stock);
                        item.SubItems.Add(price);
                        item.SubItems.Add(prd.category);
                        item.SubItems.Add(prd.supplier);


                        // tampilkan data mhs ke listview
                        lvwProduct.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Pencarian data product tidak ditemukan !!!", 
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else if (cmbFilter.Text == "Product Name")
            {
                // panggil method ReadByNama dan tampung datanya ke dalam collection
                listOfProduct = controller.ReadByProductName(txtKeyword.Text);
                try
                {
                    // ekstrak objek mhs dari collection
                    foreach (var prd in listOfProduct)
                    {
                        var noUrut = lvwProduct.Items.Count + 1;
                        var stock = Convert.ToString(prd.stock);
                        var price = Convert.ToString(prd.price);

                        var item = new ListViewItem(noUrut.ToString());
                        item.SubItems.Add(prd.product_id);
                        item.SubItems.Add(prd.product_name);
                        item.SubItems.Add(stock);
                        item.SubItems.Add(price);
                        item.SubItems.Add(prd.category);
                        item.SubItems.Add(prd.supplier);


                        // tampilkan data mhs ke listview
                        lvwProduct.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Pencarian data product tidak ditemukan !!!", 
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else if (cmbFilter.Text == "Supplier")
            {
                // panggil method ReadByNama dan tampung datanya ke dalam collection
                listOfProduct = controller.ReadBySupplier(txtKeyword.Text);
                try
                {
                    // ekstrak objek mhs dari collection

                    foreach (var prd in listOfProduct)
                    {
                        var noUrut = lvwProduct.Items.Count + 1;
                        var stock = Convert.ToString(prd.stock);
                        var price = Convert.ToString(prd.price);

                        var item = new ListViewItem(noUrut.ToString());
                        item.SubItems.Add(prd.product_id);
                        item.SubItems.Add(prd.product_name);
                        item.SubItems.Add(stock);
                        item.SubItems.Add(price);
                        item.SubItems.Add(prd.category);
                        item.SubItems.Add(prd.supplier);


                        // tampilkan data mhs ke listview
                        lvwProduct.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Pencarian data product tidak ditemukan !!!", 
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
