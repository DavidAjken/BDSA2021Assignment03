using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace BDSA2020.Assignment02.Tests
{
    public class DelegatesTests
    {
        [Theory]
        [InlineData("Vi er gruppe 49", "94 eppurg re iV")]
        [InlineData("Lorem Ipsum er fylde text", "txet edlyf re muspI meroL")]
       public void ReverseString(string input, string expected)
        {
            Func<string,string> Reverse = s => s.ToCharArray().Reverse().ToString();
        
            //WriteLine(Reverse(input));
            var actual = Reverse(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void twoDecimalProduct()
        {
        //Given
        Func<double,double,double> product = (a, b) => a*b;
        var input1 = 4.5;
        var input2 = 5.6;
        var expected = 25.2;
        //When
        var actual = product(input1,input2);
        //Then
            Assert.Equal(expected,actual);
        }
    }
}
