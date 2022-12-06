using SharedLibrary.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SharedLibrary.BusinessLayer
{
    public  class CategoryRepository
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"select * 
                               from s_Category
                               where Parent_Id is null";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                Category category = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    category = new Category();
                    category.Id = dr.GetInt32("Id");
                    category.Name = dr.GetString("Name");

                    categories.Add(category);
                }
                conn.Close();
                return categories;
            }
        }

        public List<Category> GetSubCategories(int id)
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @" Select sc.Id, sc1.[Name]
                                from s_Category sc
                                join s_Category sc1
                                on sc.Id = sc1.Parent_Id
                                where sc.Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                conn.Open();

                Category category = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    category = new Category();
                    category.Id = dr.GetInt32("Id");
                    category.Name = dr.GetString("Name");

                    categories.Add(category);
                }
                conn.Close();
                return categories;
            }
        }

        public void UpdateCategory(Category category)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_Category SET [Name]=@Name WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Id", category.Id);
                cmd.Parameters.AddWithValue("Name", category.Name);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateSubCategory(Category category)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_Category SET [Name]=@Name, Parent_Id = @ParentID WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Id", category.Id);
                cmd.Parameters.AddWithValue("Name", category.Name);
                cmd.Parameters.AddWithValue("ParentID", category.ParentId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public Category GetCategoryByName(string name)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"  select * 
                                 from s_Category
                                 where [Name] = @name";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("name", name);

                Category category = null;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    category = new Category();
                    category.Id = dr.GetInt32("Id");
                    category.Name = name;
                    category.ParentId = dr.GetInt32("Parent_Id");
                    
                }
                return category;
            }
        }

        public void CreateCategory(string name, int? parent)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                if(parent != null)
                {
                    string sql = @"INSERT INTO s_Category([Name], Parent_Id)
                                            VALUES(@Name,@id);";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("id", parent);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteCategory(Category category)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"DELETE from s_Category
                                WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Id", category.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
