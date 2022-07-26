using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Request.Type;
using Alexa.NET.Response.Converters;
using Alexa.NET.ShoppingActions;
using Newtonsoft.Json.Linq;

namespace Alexa.NET
{
    public static class ShoppingKit
    {
        public static void Add()
        {
            ShoppingActionsConverter.AddToConnectionTaskConverters();
        }

        public static ShoppingResult ResultFromSessionResumed(SessionResumedRequest request)
        {
            if (request.Cause.Result is not JObject jo) return null;
            var task = new ShoppingResult();
            ShoppingActionsConverter.Serializer.Populate(jo.CreateReader(), task);
            return task;
        }
    }
}
