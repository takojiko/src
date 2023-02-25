using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hoimi.Models;
using Hoimi.SqlServer;

namespace Hoimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DataTableReadButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            dataGridView1.DataSource = ProductSqlServer.GetDataTable();
            sw.Stop();
            this.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void ReaderReadButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            dataGridView1.DataSource = ProductSqlServer.GetDataReader();
            sw.Stop();
            this.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void InsertCommandButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, price);
            ProductSqlServer.Insert(entity);
        }

        private void UpdateCommandButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, price);
            ProductSqlServer.Update(entity);
        }

        private void DeleteCommandButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdTextBox.Text);
            ProductSqlServer.Delete(productId);
        }

        private void DapperReadButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            dataGridView1.DataSource = ProductSqlServer.GetDapper();
            sw.Stop();
            this.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void DapperInsertButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, price);
            ProductSqlServer.DapperInsert(entity);
        }

        private void EFReadButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            var source = new List<Product>();
            using (var db = new HoimiDbContext())
            {
                source.AddRange(db.Products);
            }

            dataGridView1.DataSource = source;

            sw.Stop();
            this.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void EFInsertButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductId = Convert.ToInt32(ProductIdTextBox.Text);
            p.ProductName = ProductNameTextBox.Text;
            p.Price = Convert.ToInt32(PriceTextBox.Text);
            
            using (var db = new HoimiDbContext())
            {
                db.Products.Add(p);
                db.SaveChanges();
            }
        }

        private void EFUpdateButton_Click(object sender, EventArgs e)
        {
            using (var db = new HoimiDbContext())
            {
                var p = db.Products.Find(
                    Convert.ToInt32(ProductIdTextBox.Text));
                p.ProductName = ProductNameTextBox.Text;
                p.Price = Convert.ToInt32(PriceTextBox.Text);
                db.SaveChanges();
            }
        }

        private void EFDeleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new HoimiDbContext())
            {
                var p = db.Products.Find(
                   Convert.ToInt32(ProductIdTextBox.Text));
                db.Products.Remove(p);
                db.SaveChanges();
            }
        }

        private void Create50000Button_Click(object sender, EventArgs e)
        {
            for (int i = 10; i <= 50000; i++)
            {
                ProductSqlServer.Insert(new ProductEntity(
                    i,
                    "product:" + i,
                    i*10
                    ));
            }

            MessageBox.Show("完了！！");
        }
    }
}
