﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        public OrderProduct(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = Quantity*Product.Price;
        }

        public OrderProduct() { }

        public OrderProduct(OrderProductDTO orderProductDTO)
        {
            Id = orderProductDTO.Id;
            Product = new Product(orderProductDTO.Product);
            Quantity = orderProductDTO.Quantity;
            Price = orderProductDTO.Price;
        }
    }
}
