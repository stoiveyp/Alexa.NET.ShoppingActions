using System;
using Newtonsoft.Json;

namespace Alexa.NET.ShoppingActions
{
    public class ProductEntity
    {
        public ProductEntity(){}

        public ProductEntity(string asin)
        {
            ASIN = asin;
        }

        [JsonProperty("asin")]
        public string ASIN { get; set; }
    }
}
