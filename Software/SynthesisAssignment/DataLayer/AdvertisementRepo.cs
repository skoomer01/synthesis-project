using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class AdvertisementRepo : IAdvertisementRepo
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public List<ProductDTO> GetDicountedProducts()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"SELECT *
                                FROM s_Product
                                WHERE Discount <> '0'
                                ORDER BY ProductID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                ProductDTO product = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    product = new ProductDTO();
                    product.Id = dr.GetInt32("ProductID");
                    product.Name = dr.GetString("ProductName");
                    product.Category = categoryRepository.GetCategoryByName(dr.GetString("Category"));
                    product.SubCategory = categoryRepository.GetCategoryByName(dr.GetString("SubCategory"));
                    product.Price = dr.GetDecimal("Price");
                    product.Unit = dr.GetString("Unit");
                    product.ProductImage = dr.GetString("ProductImage");
                    product.Discount = dr.GetInt32("Discount");
                    product.Availability = dr.GetString("AvailabilityStatus");
                    products.Add(product);
                }
                return products;
            }
        }

        public Dictionary<int, int> GetMostPopular()
        {
            Dictionary< int, int> topPicks = new Dictionary<int, int>();
            int productID = 0;
            int voteNumber = 0;

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            {
                string sql = @" SELECT TOP 3 ProductID, COUNT(ProductID) as num
                                FROM s_Favorite  GROUP BY ProductID 
                                HAVING COUNT (ProductID)=( 
                                SELECT MAX(mycount) 
                                FROM ( 
                                SELECT ProductID, COUNT(ProductID) mycount 
                                FROM s_Favorite 
                                GROUP BY ProductID)r);";

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productID = reader.GetInt32("ProductID");
                    voteNumber = reader.GetInt32("num");

                    topPicks.Add( productID, voteNumber);
                }
            }
            return topPicks;
        }

        public Dictionary<int, int> GetLeastPopular()
        {
            Dictionary<int, int> leastPicks = new Dictionary<int, int>();
            int productID = 0;
            int voteNumber = 0;

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            {
                string sql = @" SELECT TOP 3 ProductID, COUNT(ProductID) as num
                                FROM s_Favorite  GROUP BY ProductID 
                                HAVING COUNT (ProductID)=( 
                                SELECT MIN(mycount) 
                                FROM ( 
                                SELECT ProductID, COUNT(ProductID) mycount 
                                FROM s_Favorite 
                                GROUP BY ProductID)r);";

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productID = reader.GetInt32("ProductID");
                    voteNumber = reader.GetInt32("num");

                    leastPicks.Add(productID, voteNumber);
                }
            }
            return leastPicks;
        }
        public void UpdateProductDiscount(int id, decimal price, int discount)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_Product SET Price=@Price, Discount = @Discount WHERE ProductID=@ProductID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("ProductID", id);
                cmd.Parameters.AddWithValue("Price", price);
                cmd.Parameters.AddWithValue("Discount", discount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
