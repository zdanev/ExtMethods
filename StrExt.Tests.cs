using System;
using Xunit;

namespace ExtMethods.Tests
{
    public class StrExtTests
    {
        [Fact]
        public void String_FormatWith()
        {
            // arrange

            // act
            var result = "abc {0} def {1}".FormatWith("xxx", 7);

            // assert
            Assert.Equal("abc xxx def 7", result);
        }

        [Fact]
        public void String_Left()
        {
            // arrange 

            // act
            var result = "xxxabc".Left(3);

            // assert
            Assert.Equal("xxx", result);
        }

        [Fact]
        public void String_Right()
        {
            // arrange 

            // act
            var result = "xxxabc".Right(3);

            // assert
            Assert.Equal("abc", result);
        }
    }
}