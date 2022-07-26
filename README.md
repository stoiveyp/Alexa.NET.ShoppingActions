# Alexa.NET.ShoppingActions
A small library to help you use the Alexa Shopping Kit in your skill

## Add Request/Response Support

```csharp
	ShoppingKit.Add();
```

## Add directive to add a product to users basket

```csharp
using Alexa.NET.ShoppingActions
...
var directive = new StartConnectionDirective(new AddToShoppingCart("ASIN"), "token");
skillResponse.Response.Directives.Add(directive);
```

## Add directive to buy a product

```csharp
using Alexa.NET.ShoppingActions
...
var directive = new StartConnectionDirective(new BuyShoppingProducts("ASIN"), "token");
skillResponse.Response.Directives.Add(directive);
```

## Handle Response

## Add Request Handler support
```csharp
using Alexa.NET.ShoppingActions
switch(skillRequest.Request)
{
    case SessionResumedRequest resumed:
        var shoppingResult = ShoppingKit.ResultFromSessionResumed(resumed);
        if(shoppingResult != null)
        {
            //TODO: error logic here
        }
    ...
};
```


## For more information on how to use these actions within a skill - please visit the Amazon Alexa documentation
https://developer.amazon.com/en-US/docs/alexa/alexa-shopping/implement-shopping-actions.html
