using Xunit;

namespace ExtMethods
{
    public class HexExt_Tests
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