using Newtonsoft.Json;

namespace Alexa.NET.ShoppingActions;

public class ShoppingResult
{
    [JsonProperty("code",NullValueHandling = NullValueHandling.Ignore)]
    public string Code { get; set; }

    [JsonProperty("message",NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; set; }
}