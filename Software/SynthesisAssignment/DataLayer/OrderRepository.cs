using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderRepository
    {
        public List<OrderDTO> GetOrders()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"SELECT OrderID, OrderDate, OrderStatus ,Total
                                FROM s_Order
                                ORDER BY OrderID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                OrderDTO orderDTO = null;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    orderDTO = new OrderDTO();
                    orderDTO.Id = dr.GetInt32("OrderID");
                    orderDTO.OrderDate = dr.GetDateTime("OrderDate");
                    orderDTO.Products = GetOrderProducts(orderDTO.Id);
                    orderDTO.EnumOrderStatus = dr.GetString("OrderStatus");
                    orderDTO.Total = dr.GetDecimal("Total");
                    orders.Add(orderDTO);
                }
                conn.Close();
                return orders;
            }
        }

        public void UpdateStatus(int id, string status)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_Order SET OrderStatus=@OrderStatus WHERE OrderID=@OrderID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("OrderID", id);
                cmd.Parameters.AddWithValue("OrderStatus", status);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public OrderDTO GetOrderByID(int ID)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM s_Order WHERE OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("OrderID", ID);

                OrderDTO orderDTO = null;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    orderDTO = new OrderDTO();
                    orderDTO.Id = dr.GetInt32("OrderID");
                    orderDTO.OrderDate = dr.GetDateTime("OrderDate");
                    orderDTO.EnumOrderStatus = dr.GetString("OrderStatus");
                    orderDTO.Total = dr.GetInt32("Total");

                }
                conn.Close();
                return orderDTO;
            }
        }

        public void CreateOrder(DateTime orderDate, string orderStatus, decimal total, List<OrderProductDTO> products)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"INSERT INTO s_Order(OrderDate,
                                                    OrderStatus,
                                                    Total)
                                            VALUES(@OrderDate,
                                                    @OrderStatus,
                                                    @Total);";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("OrderDate",orderDate);
                cmd.Parameters.AddWithValue("OrderStatus", orderStatus);
                cmd.Parameters.AddWithValue("Total", total);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                foreach(OrderProductDTO productDTO in products)
                {
                    string sql = @"INSERT INTO s_OrderProduct(OrderID,
                                                    ProductID,
                                                    Price)
                                            VALUES(@OrderID,
                                                    @ProductID,
                                                    @Price);";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("OrderID", GetLastOredrID());
                    cmd.Parameters.AddWithValue("ProductID", productDTO.Product.Id);
                    cmd.Parameters.AddWithValue("Price", productDTO.Price);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public int GetLastOredrID()
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT TOP 1 OrderID FROM s_Order ORDER BY OrderID DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                int id = 0;
                while (dr.Read())
                {
                    id = dr.GetInt32("OrderID");
                }
                conn.Close();
                return id;
            }
        }
        public List<OrderProductDTO> GetOrderProducts(int orderID)
        {
            CategoryRepository categoryRepository = new CategoryRepository();

            List<OrderProductDTO> products = new List<OrderProductDTO>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"  SELECT s.ProductID, ProductName, Category ,SubCategory, s.Price, Unit, ProductImage,op.Price
                                FROM s_Product as s
                                INNER JOIN s_OrderProduct as op
                                on s.ProductID = op.ProductID
                                WHERE op.OrderID = @orderID
                                ORDER BY s.ProductID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("orderID", orderID);
                conn.Open();

                OrderProductDTO orderProduct = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    orderProduct = new OrderProductDTO();
                    ProductDTO product = new ProductDTO();
                    product.Id = dr.GetInt32("ProductID");
                    product.Name = dr.GetString("ProductName");
                    product.Category = categoryRepository.GetCategoryByName(dr.GetString("Category"));
                    product.SubCategory = categoryRepository.GetCategoryByName(dr.GetString("SubCategory"));
                    product.Price = dr.GetDecimal("s.Price");
                    product.Unit = dr.GetString("Unit");
                    product.ProductImage = dr.GetString("ProductImage");
                    orderProduct.Product = product;
                    orderProduct.Price = dr.GetDecimal("op.Price");
                    products.Add(orderProduct);
                }
                return products;
            }
        } 
    }
}
