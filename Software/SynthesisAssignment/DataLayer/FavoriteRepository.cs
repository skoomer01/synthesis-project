using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class FavoriteRepository
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public List<ProductDTO> GetAllFavorites(int userID)
        {
            List<ProductDTO> favorites = new List<ProductDTO>();
            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            {
                string sql = @"select p.ProductID, p.ProductName, p.Category, p.SubCategory, p.Price, p.Unit, p.ProductImage
                               from s_Favorite as f 
                               inner join s_Product as p on
                               f.ProductID = p.ProductID
                               where f.UserID = @userID;";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("userID", userID);
                connection.Open();

                ProductDTO product = null;
                SqlDataReader dr = command.ExecuteReader();

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
                    favorites.Add(product);
                }
            }
            return favorites;
        }

        public void AddFavorite(int productID, int userID)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"insert into [s_Favorite] (ProductID,
                                                 UserID)
                                            values(@ProductID,
                                                    @UserID);";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ProductID", productID);
                cmd.Parameters.AddWithValue("UserID", userID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveFavorite(int productID, int userID)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"DELETE from s_Favorite
                            WHERE ProductID = @productID
                            and UserID = @userID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("productID", productID);
                cmd.Parameters.AddWithValue("userID", userID);

                conn.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public bool IsAlreadyFavorite(int productID, int userID)
        {
            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            {
                string sql = @"select ProductID, UserID
                               from s_Favorite 
							   where UserID = @userID and ProductID = @productID";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("userID", userID);
                command.Parameters.AddWithValue("productID", productID);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int ArticleID = 0;
                int UserID = 0;
                while (reader.Read())
                {
                    ArticleID = reader.GetInt32("productID");
                    UserID = reader.GetInt32("userID");
                }
                if (ArticleID == 0 && UserID == 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
