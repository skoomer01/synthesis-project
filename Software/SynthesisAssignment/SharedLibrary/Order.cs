using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderProduct> Products { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public EnumOrderStatus EnumOrderStatus { get; set; }


        
        public Order() { }
        public Order(OrderDTO orderDTO)
        {
            Id = orderDTO.Id;
            UserId = orderDTO.UserId;
            OrderDate = orderDTO.OrderDate;
            Name= orderDTO.Name;
            Email = orderDTO.Email;
            PostalCode = orderDTO.PostalCode;
            Products = new List<OrderProduct>();
            foreach(OrderProductDTO orderProductDTO in orderDTO.Products)
            {
                OrderProduct orderProduct = new OrderProduct(orderProductDTO);
                Products.Add(orderProduct);
            }
            Total = orderDTO.Total;
            EnumOrderStatus = SetType(orderDTO.EnumOrderStatus);
        }

        public Order(int userId, List<OrderProduct> products, string name, string postalCode, string email, decimal total)
        {
            UserId = userId;
            Products = products;
            Name = name;
            PostalCode = postalCode;
            Email = email;
            Total = total;
            OrderDate = DateTime.Now;
            EnumOrderStatus = EnumOrderStatus.Preparing;
        }

        public EnumOrderStatus SetType(string type)
        {
            EnumOrderStatus setType = EnumOrderStatus.Preparing;

            switch (type)
            {
                case "AwaitingShipment":
                    setType = EnumOrderStatus.AwaitingShipment;
                    break;

                case "Shipped":
                    setType = EnumOrderStatus.Shipped;
                    break;

                case "Delivered":
                    setType = EnumOrderStatus.Delivered;
                    break;

            }
            return setType;
        }

        public string GetType(EnumOrderStatus type)
        {
            string setType = "Preparing";

            switch (type)
            {
                case EnumOrderStatus.AwaitingShipment:
                    setType = "AwaitingShipment";
                    break;

                case EnumOrderStatus.Shipped:
                    setType = "Shipped";
                    break;

                case EnumOrderStatus.Delivered:
                    setType = "Delivered";
                    break;

            }
            return setType;
        }
    }
}
