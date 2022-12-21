using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class AdvertisementManager
    {
        IAdvertisementRepo advertisementRepo;
        IProductRepo productRepo;
        public AdvertisementManager(IAdvertisementRepo repo, IProductRepo productRepo)
        {
            this.advertisementRepo = repo;
            this.productRepo = productRepo;

        } 
        public List<Product> GetDiscountedItems()
        {
            List<Product> products = new List<Product>();
            foreach (ProductDTO productDTO in advertisementRepo.GetDicountedProducts())
            {
                Product product = new Product(productDTO);
                products.Add(product);
            }
            return products;
        }
        

        public List<Product> GetMostPopularItems()
        {
            Dictionary<int, int> productsKeys = advertisementRepo.GetMostPopular();
            List<Product> products = new List<Product>();
            foreach(KeyValuePair<int, int> kvp in productsKeys)
            {
                Product product = new Product(productRepo.GetProductByID(kvp.Key));
                products.Add(product);
            }
            return products;
        }

        public List<Product> GetLeastPopularItems()
        {
            Dictionary<int, int> productsKeys = advertisementRepo.GetLeastPopular();
            List<Product> products = new List<Product>();
            foreach (KeyValuePair<int, int> kvp in productsKeys)
            {
                Product product = new Product(productRepo.GetProductByID(kvp.Key));
                products.Add(product);
            }
            return products;
        }

        public void UpdateProductDiscount(int id, decimal discount)
        {
            Product product = new Product(productRepo.GetProductByID(id));
            decimal price = product.Price;

            decimal newprice = price - ( price * (discount / 100));
            advertisementRepo.UpdateProductDiscount(id, newprice, (int)discount);
        }

        public void RevertProductDiscount(int id)
        {
            Product product = new Product(productRepo.GetProductByID(id));
            decimal discount = product.Discount;
            decimal currentPrice = product.Price;
            decimal pricediscount = discount / 100;
            decimal originalprice = currentPrice / (1 - pricediscount);
            advertisementRepo.UpdateProductDiscount(id, originalprice, 0);
            
        }
    }
}
