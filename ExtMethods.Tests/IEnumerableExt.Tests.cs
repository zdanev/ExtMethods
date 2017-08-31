using Xunit;

namespace ExtMethods.Tests
{
    public class IEnumerableExtTests
    {
        [Fact]
        public void IEnumerable_ForEach()
        {
            // arrange
            var s = 0;
            var list = new[] { 1, 2, 3, 4, 5 };

            // act
            list.ForEach((i) => s += i); 

            // assert
            Assert.Equal(15, s);
        }

        [Fact]
        public void IEnumerable_ForEach_Chain()
        {
            // arrange
            var s1 = 0;
            var s2 = 0;
            var list = new[] { 1, 2, 3, 4, 5 };

            // act
            list
                .ForEach((i) => s1 += i)
                .ForEach((i) => s2 += i);

            // assert
            Assert.Equal(15, s2);
        }
    }
}