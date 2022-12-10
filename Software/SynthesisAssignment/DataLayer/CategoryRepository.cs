using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataLayer
{
    public  class CategoryRepository
    {
        public List<CategoryDTO> GetCategories()
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"select * 
                               from s_Category
                               where Parent_Id is null";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                CategoryDTO category = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    category = new CategoryDTO();
                    category.Id = dr.GetInt32("Id");
                    category.Name = dr.GetString("Name");

                    categories.Add(category);
                }
                conn.Close();
                return categories;
            }
        }

        public List<CategoryDTO> GetSubCategories()
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"select * 
                               from s_Category
                               where Parent_Id is not null";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                CategoryDTO category = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    category = new CategoryDTO();
                    category.Id = dr.GetInt32("Id");
                    category.Name = dr.GetString("Name");
                    category.ParentId = dr.GetInt32("Parent_Id");

                    categories.Add(category);
                }
                conn.Close();
                return categories;
            }
        }

        public List<CategoryDTO> GetSubCategories(int id)
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"   Select sc1.Id, sc1.[Name], sc1.Parent_Id
                                from s_Category sc
                                join s_Category sc1
                                on sc.Id = sc1.Parent_Id
                                where sc1.Parent_Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                conn.Open();

                CategoryDTO category = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    category = new CategoryDTO();
                    category.Id = dr.GetInt32("Id");
                    category.Name = dr.GetString("Name");
                    category.ParentId = dr.GetInt32("Parent_Id");

                    categories.Add(category);
                }
                conn.Close();
                return categories;
            }
        }

        public void UpdateCategory(int id, string name)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_Category SET [Name]=@Name WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Id", id);
                cmd.Parameters.AddWithValue("Name", name);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateProductSubCategory(string newname, string oldname)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_Product SET SubCategory=@NewSubCategory WHERE SubCategory=@OldSubCategory";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("NewSubCategory", newname);
                cmd.Parameters.AddWithValue("OldSubCategory", oldname);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateProductCategory(string newname, string oldname)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_Product SET Category=@NewCategory WHERE Category=@OldCategory";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("NewCategory", newname);
                cmd.Parameters.AddWithValue("OldCategory", oldname);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public CategoryDTO GetCategoryByName(string name)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"  select * 
                                 from s_Category
                                 where [Name] = @name";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("name", name);

                CategoryDTO category = null;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    category = new CategoryDTO();
                    category.Id = dr.GetInt32("Id");
                    category.Name = name;
                    category.ParentId = dr.IsDBNull("Parent_Id") ? null : dr.GetInt32("Parent_Id");
                }
                return category;
            }
        }

        public void CreateCategory(string name, int? parent)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"INSERT INTO s_Category([Name], Parent_Id)
                                        VALUES(@Name,@id);";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Name", name);
                if(parent != null) { cmd.Parameters.AddWithValue("id", parent); }
                else { cmd.Parameters.AddWithValue("id", DBNull.Value); }

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();              
            }
        }

        public void DeleteCategory(int id)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"DELETE from s_Category
                                WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
