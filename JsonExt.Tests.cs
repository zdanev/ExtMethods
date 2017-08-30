using Xunit;

namespace ExtMethods.Tests
{
    public class JsonExtTests
    {
        [Fact]
        public void JsonExt_ToJson()
        {
            // arrange
            var data = new { i = 3, f = 3.14, s = "abc" };

            // act
            var json = data.ToJson();

            // assert
            Assert.Equal("{\"i\":3,\"f\":3.14,\"s\":\"abc\"}", json);
        }
    }
}