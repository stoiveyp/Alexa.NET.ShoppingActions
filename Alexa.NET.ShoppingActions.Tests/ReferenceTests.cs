namespace Alexa.NET.ShoppingActions.Tests
{
    public class ReferenceTests
    {
        [Fact]
        public void ProductEntity()
        {
            var product = new ProductEntity("B01962MDHA");
            Assert.True(Utility.CompareJson(product, "ProductEntity.json"));
        }
    }
}