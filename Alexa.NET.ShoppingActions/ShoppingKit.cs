using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.Converters;
using Alexa.NET.ShoppingActions;

namespace Alexa.NET
{
    public static class ShoppingKit
    {
        public static void Add()
        {
            ShoppingActionsConverter.AddToConnectionTaskConverters();
            ShoppingResponseConverter.AddToRequestConverter();
        }
    }
}
