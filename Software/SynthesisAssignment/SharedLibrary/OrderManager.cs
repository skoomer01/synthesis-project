﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class OrderManager
    {
        private List<Order> orders;
        private IOrderRepo orderRepository;

        public OrderManager(IOrderRepo orderRepo)
        {
            orderRepository = orderRepo;
            orders = GetAllOrders();
        }
        public List<Order> Orders { get { return orders; } set { orders = value; } }
        public List<Order> GetAllOrders()
        {
            List<Order> products = new List<Order>();
            foreach (OrderDTO orderDTO in orderRepository.GetOrders())
            {
                Order order = new Order(orderDTO);
                products.Add(order);
            }
            return products;
        }


        public List<Order> GetUserOrders(int userID)
        {
            List<Order> orders = new List<Order>();
            foreach (OrderDTO orderDTO in orderRepository.GetUserOrders(userID))
            {
                Order order = new Order(orderDTO);
                orders.Add(order);             
            }
            return orders;
        }

        public bool AddOrder(int userID,DateTime orderDate, EnumOrderStatus orderStatus, decimal total, List<OrderProduct> products, string name, string email, string postalcode)
        {
            try
            {
                if (products != null && products.Count > 0)
                {
                    List<OrderProductDTO> orderProductDTOs = new List<OrderProductDTO>();
                    foreach (OrderProduct orderProduct in products)
                    {
                        CategoryDTO categoryDTO = new CategoryDTO(orderProduct.Product.Category.Id, orderProduct.Product.Category.Name,
                            orderProduct.Product.Category.ParentId);
                        CategoryDTO subcategoryDTO = new CategoryDTO(orderProduct.Product.SubCategory.Id, orderProduct.Product.SubCategory.Name,
                            orderProduct.Product.SubCategory.ParentId);
                        ProductDTO productDTO = new ProductDTO(orderProduct.Product.Id, orderProduct.Product.Name, categoryDTO, subcategoryDTO,
                            orderProduct.Product.Price, orderProduct.Product.Unit, orderProduct.Product.ProductImage);
                        OrderProductDTO orderProductDTO = new OrderProductDTO(orderProduct.Id, productDTO, orderProduct.Quantity, orderProduct.Price);
                        orderProductDTOs.Add(orderProductDTO);
                    }
                    orderRepository.CreateOrder(userID,orderDate, orderStatus.ToString(), total, orderProductDTOs, name, email, postalcode);
                    return true;
                }
                else { return false; }
            }
            catch(Exception ex) { throw new Exception(ex.Message); }    
        }
        public Order GetOrder(int id)
        {
            Order product = new Order(orderRepository.GetOrderByID(id));
            return product;
        }

        public bool UpdateOrderStatus(int id, string status)
        {
            if(status != String.Empty)
            {
                orderRepository.UpdateStatus(id, status);
                return true;
            }
            return false;
        }

        public List<OrderProduct> GetOrderProducts(int orderID)
        {
            List<OrderProduct> productList = new List<OrderProduct>();
            foreach(OrderProductDTO orderProductDTO in orderRepository.GetOrderProducts(orderID))
            {
                OrderProduct orderProduct = new OrderProduct(orderProductDTO);
                productList.Add(orderProduct);
            }
            return productList;
        }
    }
}
