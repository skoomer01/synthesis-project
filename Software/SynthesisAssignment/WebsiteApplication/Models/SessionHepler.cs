using LogicLayer;
using System.Text.Json;

namespace WebsiteApplication.Models
{
    public static class SessionHepler
    {
        public static void SetObjectAsJson(this ISession session, string key, List<OrderProduct> value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static List<OrderProduct>? GetObjectFromJson(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<List<OrderProduct>>(value);
        }
    }
}
