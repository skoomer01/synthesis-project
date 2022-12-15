using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public  class FavoriteManager
    {
        private FavoriteRepository _favoriteRepository = new FavoriteRepository();
        public void AddFavorite(int productID, int userID)
        {
            _favoriteRepository.AddFavorite(productID, userID);
        }

        public void RemoveFavorite(int productID, int userID)
        {
            _favoriteRepository.RemoveFavorite(productID, userID);
        }

        public List<Product> GetAllFavorites(int userID)
        {
            List<Product> favorites = new List<Product>();
            List<ProductDTO> list = _favoriteRepository.GetAllFavorites(userID);
            foreach(ProductDTO item in list)
            {
                Product product = new Product(item);
                favorites.Add(product);
            }
            return favorites;
        }
        public bool IsAlreadyFavorite(int productID, int userID)
        {
            return _favoriteRepository.IsAlreadyFavorite(productID, userID);
        }
    }
}
