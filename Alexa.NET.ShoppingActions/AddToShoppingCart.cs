using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.ConnectionTasks;
using Newtonsoft.Json;

namespace Alexa.NET.ShoppingActions
{
    public class AddToShoppingCart:IConnectionTask
    {
        public const string AssociatedUri = "connection://AMAZON.AddToShoppingCart/1";

        public AddToShoppingCart()
        {
            Products = new();
        }

        public AddToShoppingCart(params string[] products)
        {
            Products = products.Select(p => new ProductEntity(p)).ToList();
        }

        [JsonProperty("products")]
        public List<ProductEntity> Products { get; set; }

        [JsonIgnore] public string ConnectionUri => AssociatedUri;
    }
}
