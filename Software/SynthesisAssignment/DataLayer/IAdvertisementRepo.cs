using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IAdvertisementRepo
    {
        public List<ProductDTO> GetDicountedProducts();
        public Dictionary<int, int> GetMostPopular();
        public Dictionary<int, int> GetLeastPopular();
        public void UpdateProductDiscount(int id, decimal price, int discount);
    }
}
