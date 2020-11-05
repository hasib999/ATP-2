using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Inventory_Management_System_with_ADO.Net.Models
{
    public class ProductDataAccess
    {
        DataAccess dataAccess;

        public ProductDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Product>GetAllProducts()
        {
            string sql = "SELECT *FROM Products";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Product> proList = new List<Product>();
            while (reader.Read())
            {
                Product pro = new Product();
                pro.ProductId = (int)reader["ProductId"];
                pro.ProductName =(string)reader["ProductName"];
                pro.Price = (double)(reader["Price"]);
                pro.CategoryId = (int)reader["CategoryId"];
                proList.Add(pro);
            }
            return proList;
        }
        public Product GetProductById(int id)
        {
            string sql = "SELECT *FROM Products WHERE ProductId=" + id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Product pro = new Product();
            pro.ProductId = (int)reader["ProductId"];
            pro.ProductName = (string)reader["ProductName"];
            pro.Price = (double)reader["Price"];
            pro.CategoryId = (int)reader["CategoryId"];
            return pro;
        }

        public int InsertProduct(Product pro)
        {
            string sql = "INSERT INTO Products(ProductName, Price, CategoryId) VALUES('"+ pro.ProductName + ","+pro.Price+","+pro.CategoryId+"')";
            return dataAccess.ExecuteQuery(sql);
        }
    }
}