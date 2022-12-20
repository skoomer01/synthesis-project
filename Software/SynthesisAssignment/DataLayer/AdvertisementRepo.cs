using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class AdvertisementRepo
    {
        public Dictionary<int, int> GetMostPopular()
        {
            Dictionary< int, int> topPicks = new Dictionary<int, int>();
            int productID = 0;
            int voteNumber = 0;

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            {
                string sql = @" SELECT TOP 3 ProductID, COUNT(ProductID) as num
                                FROM s_Favorite  GROUP BY ProductID 
                                HAVING COUNT (ProductID)=( 
                                SELECT MAX(mycount) 
                                FROM ( 
                                SELECT ProductID, COUNT(ProductID) mycount 
                                FROM s_Favorite 
                                GROUP BY ProductID)r);";

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    productID = reader.GetInt32("ProductID");
                    voteNumber = reader.GetInt32("num");

                    topPicks.Add( productID, voteNumber);
                }
            }
            return topPicks;
        }
    }
}
