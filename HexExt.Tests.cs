using Xunit;

namespace ExtMethods.Tests
{
    public class HexExtTests
    {
        [Fact]
        public void Str_ToHex()
        {
            // arrange
            
            // act
            var result = "ABC".ToHex();
            
            // assert
            Assert.Equal("414243", result);
        }
    }
}