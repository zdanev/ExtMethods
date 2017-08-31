using Xunit;

namespace ExtMethods.Tests
{
    public class ReflectionExtTests
    {
        class TestClass
        {
            public string StrProp { get; set; }

            public int IntProp { get; set; }

            public void SetStrProp(string strProp)
            {
                StrProp = strProp;
            }

            public void SetIntProp(int intProp)
            {
                IntProp = intProp;
            }
        }

        [Fact]
        public void ReflectionExt_Set()
        {
            // arrange
            var o = new TestClass();

            // act
            o.Set("StrProp", "test");
            o.Set("IntProp", 7);

            // assert
            Assert.Equal("test", o.StrProp);
            Assert.Equal(7, o.IntProp);
        }

        [Fact]
        public void ReflectionExt_Call()
        {
            // arrange
            var o = new TestClass();

            // act
            o.Call("SetStrProp", "test");
            o.Call("SetIntProp", 7);

            // assert
            Assert.Equal("test", o.StrProp);
            Assert.Equal(7, o.IntProp);        
        }
    }
}