using System;
using Xunit;

namespace ExtMethods
{
    public class NumExt_Tests
    {
        [Fact]
        public void Num_PercentOf()
        {
            // arrange

            // act
            var percent = 25.0.PercentOf(50.0);
            
            // assert
            Assert.Equal(50.0, percent);
        }
    }
}