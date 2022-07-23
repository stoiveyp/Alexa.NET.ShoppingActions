using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET.Request.Type;

namespace Alexa.NET.ShoppingActions.Tests
{
    public class ResponseTests
    {
        [Fact]
        public void ConnectionResponseRequestDeserializesProperly()
        {
            ShoppingKit.Add();
            var request = Utility.ExampleFileContent<ConnectionShoppingResponse>("ConnectionResponseRequest.json");

            Assert.Null(request.Name);
            Assert.Equal("PurchaseProductToken", request.Token);

            Assert.Equal(200, request.Status.Code);
            Assert.Equal("Success", request.Status.Message);

            Assert.Equal("AlexaShopping.RetryLaterError", request.Result.Code);
            Assert.Equal("Encountered an error when trying to process the request, please try again later.",
                request.Result.Message);
        }
    }
}
