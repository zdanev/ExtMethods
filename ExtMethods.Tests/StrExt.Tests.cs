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

        [Fact]
        public void String_ToTitleCase()
        {
            // arrange 
            var s = "title case test";

            // act
            var result = s.ToTitleCase();

            // assert
            Assert.Equal("Title Case Test", result);
        }

        [Fact]
        public void String_ToPascalCase()
        {
            // arrange 
            var s = "pascal case test";

            // act
            var result = s.ToPascalCase();

            // assert
            Assert.Equal("PascalCaseTest", result);
        }

        [Fact]
        public void String_ToCamelCase()
        {
            // arrange 
            var s = "camel case test";

            // act
            var result = s.ToCamelCase();

            // assert
            Assert.Equal("camelCaseTest", result);
        }

        [Fact]
        public void String_ToKabobCase()
        {
            // arrange 
            var s = "kabob case test";

            // act
            var result = s.ToKabobCase();

            // assert
            Assert.Equal("kabob-case-test", result);
        }

        [Fact]
        public void String_FormatFrom()
        {
            // arrange
            var model = new { FirstName = "John", LastName = "Smith", Age = 25 };

            // act
            var result = "{FirstName} {LastName} is {Age} years old.".FormatFrom(model);

            // assert
            Assert.Equal("John Smith is 25 years old.", result);
        }
    }
}