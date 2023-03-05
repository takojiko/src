using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public sealed class Product
    {
        public Product(int productId, string productName, int price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        public int ProductId { get; }
        public string ProductName { get; }
        public int Price { get; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var product = obj as Product;
            if (product == null)
            {
                return false;
            }

            if (product.ProductId != ProductId)
            {
                return false;
            }

            if (product.ProductName != ProductName)
            {
                return false;
            }

            if (product.Price != Price)
            {
                return false;
            }

            return true;
        }
    }

    public sealed class ProductDto
    {
        public ProductDto(string productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }

        public ProductDto(Product product)
        {
            ProductId = product.ProductId.ToString();
            ProductName = product.ProductName;
        }

        public string ProductId { get; }
        public string ProductName { get; }

        public override string ToString()
        {
            return $"dto productId={ProductId} productName={ProductName}";
        }
    }

    public sealed class ProductEntity
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return $"entity productId={ProductId} productName={ProductName}";
        }
    }

    public sealed class Sale
    {
        public Sale(int saleId, int no, int customerId, DateTime saleDateTime)
        {
            SaleId = saleId;
            No = no;
            CustomerId = customerId;
            SaleDateTime = saleDateTime;
        }

        public int SaleId { get; }
        public int No { get; }
        public int CustomerId { get; }
        public DateTime SaleDateTime { get; }
    }

    public sealed class SaleItem
    {
        public SaleItem(int saleId, int no,int productId, int saleCount)
        {
            SaleId = saleId;
            No = no;
            ProductId = productId;
            SaleCount = saleCount;
        }

        public int SaleId { get; }
        public int No { get; }
        public int ProductId { get; }

        public int SaleCount { get; }
    }



}
