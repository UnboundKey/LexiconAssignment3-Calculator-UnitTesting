using UnboundKey.Core;
using Xunit;

namespace LexiconAssignment3_Calculator_UnitTesting.Tests
{
    public class HelperUnitTests
    {
        [Fact]
        public void ToStringArray_Test()
        {
            string input = "test,test2";
            string[] output = input.ToStringArray();
            Assert.Equal("test", output[0]);
            Assert.Equal("test2", output[1]);
        }
        
        [Fact]
        public void ToStringArray_Empty_String()
        {
            //setup
            string input = "";
            
            //Test
            string[] output = input.ToStringArray();
            
            //result
            Assert.NotEmpty(output);
            Assert.Equal("", output[0]);
        }
    }
}