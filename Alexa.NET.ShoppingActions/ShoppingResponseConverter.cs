using System.Linq;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.ShoppingActions
{
    public class ShoppingResponseConverter:IConnectionResponseHandler
    {
        private static readonly JsonSerializer Serializer = JsonSerializer.Create();

        public static void AddToRequestConverter()
        {
            if (ConnectionResponseTypeConverter.Handlers.All(c => c.GetType() != typeof(ShoppingResponseConverter)))
            {
                ConnectionResponseTypeConverter.Handlers.Add(new ShoppingResponseConverter());
            }
        }

        public bool CanCreate(JObject data)
        {
            return data.ContainsKey("result");
        }

        public ConnectionResponseRequest Create(JObject data)
        {
            var response = new ConnectionShoppingResponse();
            Serializer.Populate(data.CreateReader(), response);
            return response;
        }
    }
}
