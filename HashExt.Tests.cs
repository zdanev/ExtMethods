using Xunit;

namespace ExtMethods
{
    public class HashExt_Tests
    {
        [Fact]
        public void Hash_CalcMD5()
        {
            // arrange 

            // act
            var hash = "123".CalcMD5Hash();

            // assert
            Assert.Equal("202CB962AC59075B964B07152D234B70", hash);
        }
    }
}