using System.Linq;
using Alexa.NET.ConnectionTasks;
using Alexa.NET.Request.Type;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.ShoppingActions
{
    public class ShoppingActionsConverter : IConnectionTaskConverter
    {
        private static readonly JsonSerializer Serializer = JsonSerializer.Create();

        public bool CanConvert(JObject jObject)
        {
            return jObject.ContainsKey("uri") && (IsAddToShoppingCart(jObject) || IsBuyShoppingProducts(jObject));
        }

        public static bool IsAddToShoppingCart(JObject jObject) =>
            jObject.GetValue("uri").Value<string>() == AddToShoppingCart.AssociatedUri;

        public static bool IsBuyShoppingProducts(JObject jObject) =>
            jObject.GetValue("uri").Value<string>() == BuyShoppingProducts.AssociatedUri;

        public IConnectionTask Convert(JObject jObject)
        {
            if (IsAddToShoppingCart(jObject))
            {
                var task = new AddToShoppingCart();
                Serializer.Populate(jObject.CreateReader(), task);
                return task;
            }

            if (IsBuyShoppingProducts(jObject))
            {
                var task = new BuyShoppingProducts();
                Serializer.Populate(jObject.CreateReader(), task);
                return task;
            }

            return default;
        }

        public static void AddToConnectionTaskConverters()
        {
            if (ConnectionTaskConverter.ConnectionTaskConverters.Where(rc => rc != null)
                .All(rc => rc.GetType() != typeof(ShoppingActionsConverter)))
            {
                ConnectionTaskConverter.ConnectionTaskConverters.Add(new ShoppingActionsConverter());
            }
        }
    }
}
