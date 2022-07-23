using System.Collections.Generic;
using System.Linq;
using Alexa.NET.ConnectionTasks;
using Newtonsoft.Json;

namespace Alexa.NET.ShoppingActions;

public class BuyShoppingProducts : IConnectionTask
{
    public const string AssociatedUri = "connection://AMAZON.BuyShoppingProducts/1";

    public BuyShoppingProducts()
    {
        Products = new();
    }

    public BuyShoppingProducts(params string[] products)
    {
        Products = products.Select(p => new ProductEntity(p)).ToList();
    }

    [JsonProperty("products")]
    public List<ProductEntity> Products { get; set; }

    [JsonIgnore] public string ConnectionUri => AssociatedUri;
}