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
            
        }

        public int GetLastOredrID()
        {
            return 0;
        }

        public OrderDTO GetOrderByID(int ID)
        {
            OrderDTO dto = new OrderDTO();
            return dto;
        }

        public List<OrderProductDTO> GetOrderProducts(int orderID)
        {
            return null;
        }

        public List<OrderDTO> GetOrders()
        {
            return _orders;
        }

        public List<OrderDTO> GetUserOrders(int userID)
        {
            return null;
        }

        public void UpdateStatus(int id, string status)
        {

        }
    }
}
