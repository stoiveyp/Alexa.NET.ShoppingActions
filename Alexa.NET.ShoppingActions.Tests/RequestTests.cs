using Alexa.NET.ConnectionTasks;

namespace Alexa.NET.ShoppingActions.Tests
{
    public class RequestTests
    {
        [Fact]
        public void ProductEntity()
        {
            var product = new ProductEntity("B01962MDHA");
            Assert.True(Utility.CompareJson(product, "ProductEntity.json"));
        }

        [Fact]
        public void AddToShoppingCart()
        {
            var task = new AddToShoppingCart("B01962MDHA");
            Assert.True(Utility.CompareJson(task.ToConnectionDirective("AddToShoppingCartToken"), "AddToShoppingCart.json"));
        }

        [Fact]
        public void BuyShoppingProducts()
        {
            var task = new BuyShoppingProducts("B01962MDHA");
            Assert.True(Utility.CompareJson(task.ToConnectionDirective("PurchaseProductToken"), "BuyShoppingProducts.json"));
        }
    }
}