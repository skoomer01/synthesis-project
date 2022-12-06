using SharedLibrary.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.BusinessLayer
{
    public class ProductRepository
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"SELECT ProductID, ProductName, Category ,SubCategory, Price, Unit, ProductImage
                                FROM s_Product
                                ORDER BY ProductID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                Product product = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    product = new Product();
                    product.Id = dr.GetInt32("UserId");
                    product.Name = dr.GetString("UserName");
                    product.Category = null ;
                    product.SubCategory = null;
                    product.Price = dr.GetDecimal("Price");
                    product.Unit = dr.GetString("Unit");
                    product.ProductImage = dr.GetString("ProductImage");
                    products.Add(product);
                }
                return products;
            }
        }


        public void UpdateProduct(Product product)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_Product SET ProductName=@ProductName, Category=@Category, SubCategory = @SubCategory, Price=@Price, Unit=@Unit WHERE ProductID=@ProductID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("ProductID", product.Id);
                cmd.Parameters.AddWithValue("ProductName", product.Name);
                cmd.Parameters.AddWithValue("Category", product.Category.Name);
                cmd.Parameters.AddWithValue("SubCategory", product.SubCategory.Name);
                cmd.Parameters.AddWithValue("Price", product.Price);
                cmd.Parameters.AddWithValue("Unit", product.Unit);
                cmd.Parameters.AddWithValue("ProductImage", product.ProductImage);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Product GetProductByID(int ID)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM s_Product WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("ProductID", ID);

                Product product = null;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    product = new Product();
                    product.Id = ID;
                    product.Name = dr.GetString("ProductName");
                    product.Category = null;
                    product.SubCategory = null;
                    product.Price = dr.GetDecimal("Price");
                    product.Unit = dr.GetString("Unit");
                    product.ProductImage = dr.GetString("ProductImage");
                }
                return product;
            }
        }

        public void CreateProduct(string name, string category, string subcategory, decimal price, string unit, string productImage)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"INSERT INTO s_Product(ProductName,
                                                    Category,
                                                    SubCategory,
                                                    Price,
                                                    Unit,
                                                    ProductImage)
                                            VALUES(@ProductName,
                                                    @Category,
                                                    @SubCategory,
                                                    @Price,
                                                    @Unit,
                                                    @ProductImage);";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ProductName", name);
                cmd.Parameters.AddWithValue("Category", category);
                cmd.Parameters.AddWithValue("SubCategory", subcategory);
                cmd.Parameters.AddWithValue("Price", price);
                cmd.Parameters.AddWithValue("Unit", unit);
                cmd.Parameters.AddWithValue("ProductImage", productImage);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"DELETE from s_Product
                                WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("ProductID", product.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
