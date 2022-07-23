using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;

namespace Alexa.NET.ShoppingActions
{
    public class ConnectionShoppingResponse:ConnectionResponseRequest
    {
        [JsonProperty("result",NullValueHandling = NullValueHandling.Ignore)]
        public ShoppingResult Result { get; set; }
    }
}
