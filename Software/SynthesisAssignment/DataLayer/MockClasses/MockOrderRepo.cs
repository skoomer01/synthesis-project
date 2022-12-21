using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.MockClasses
{
    public class MockOrderRepo : IOrderRepo
    {
        List<OrderDTO> _orders = new List<OrderDTO>();
        public void CreateOrder(int userID, DateTime orderDate, string orderStatus, decimal total, List<OrderProductDTO> products, string name, string email, string postalcode)
        {
            OrderDTO order = new OrderDTO();
            order.UserId = userID;
            order.OrderDate = orderDate;
            order.Products = products;
            order.EnumOrderStatus = orderStatus;
            order.Name = name;
            order.Email = email;
            order.PostalCode = postalcode;
        }

        public int GetLastOredrID()
        {
            throw new NotImplementedException();
        }

        public OrderDTO GetOrderByID(int ID)
        {
            foreach (OrderDTO order in _orders)
            {
                if(order.Id == ID)
                {
                    return order;
                }
            }
            return null;
        }

        public List<OrderProductDTO> GetOrderProducts(int orderID)
        {
            foreach (OrderDTO order in _orders)
            {
                if (order.Id == orderID)
                {
                    return order.Products;
                }
            }
            return null;
        }

        public List<OrderDTO> GetOrders()
        {
            return _orders;
        }

        public List<OrderDTO> GetUserOrders(int userID)
        {
            List<OrderDTO> userOrders = new List<OrderDTO>();
            foreach (OrderDTO order in _orders)
            {
                if (order.UserId == userID)
                {
                    userOrders.Add(order);
                }
            }
            return userOrders;
        }

        public void UpdateStatus(int id, string status)
        {
            foreach (OrderDTO order in _orders)
            {
                if (order.Id == id)
                {
                    order.EnumOrderStatus = status;
                }
            }
        }
    }
}
