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
        public DateTime OrderDate { get; set; }
        public List<OrderProduct> Products { get; set; }
        public decimal Total { get; set; }
        public EnumOrderStatus EnumOrderStatus { get; set; }


        public Order(List<OrderProduct> products, decimal total)
        {
            Products = products;
            Total = total;
            OrderDate = DateTime.Now;
            EnumOrderStatus = EnumOrderStatus.Preparing;

        }
        public Order() { }
        public Order(OrderDTO orderDTO)
        {
            Id = orderDTO.Id;
            OrderDate = orderDTO.OrderDate;
            Products = new List<OrderProduct>();
            foreach(OrderProductDTO orderProductDTO in orderDTO.Products)
            {
                OrderProduct orderProduct = new OrderProduct(orderProductDTO);
                Products.Add(orderProduct);
            }
            Total = orderDTO.Total;
            EnumOrderStatus = SetType(orderDTO.EnumOrderStatus);
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
