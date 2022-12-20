using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IOrderRepo
    {
        public List<OrderDTO> GetOrders();
        public List<OrderDTO> GetUserOrders(int userID);
        public void UpdateStatus(int id, string status);
        public OrderDTO GetOrderByID(int ID);
        public void CreateOrder(int userID, DateTime orderDate, string orderStatus, decimal total, List<OrderProductDTO> products, string name, string email, string postalcode);
        public int GetLastOredrID();
        public List<OrderProductDTO> GetOrderProducts(int orderID);

    }
}
