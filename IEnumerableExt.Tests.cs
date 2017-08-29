using Xunit;

namespace ExtMethods.Tests
{
    public class IEnumerableExt_Tests
    {
        [Fact]
        public void Enumerable_ForEach()
        {
            // arrange
            var list = new[] { 1, 2, 3, 4, 5 };

            // act
            var s = 0;
            list.ForEach((i) => s += i); 

            // assert
            Assert.Equal(15, s);
        }
    }
}