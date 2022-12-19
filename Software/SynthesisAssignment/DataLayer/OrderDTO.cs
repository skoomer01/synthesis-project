using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderProductDTO> Products { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public string EnumOrderStatus { get; set; }

    }
}
