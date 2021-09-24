using System;
using Xunit;
using System.Collections.Generic;
using static System.Console;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void FlattenNumbers()
        {
            //arange
            var xs = new List<List<int>> {             
                new List<int> {1,2},
                new List<int> {3,4},
                new List<int> {5,6},
            };

            //act
            var actual = xs.Flatten();
            var expected = new List<int>{1,2,3,4,5,6};


            //assert
            Assert.Equal(expected, actual);




        }

        [Fact]
         public void FilterNumbersWithNonGearicFilter()
        {
            //arange
            var ys = new List<int> {42,43,44,45,46,47,48,49,50,70,3,4,5,6,7,8};          
            //act
            var actual = ys.Filter2();
            var expected = new List<int>{49,70};
            //assert
            Assert.Equal(expected, actual);
         
        }

        [Fact]
         public void FilterNumbersWithGearicFilter()
        {
            //arange
            var ys = new List<int> {42,43,44,45,46,47,48,49,50,70,3,4,5,6,7,8};          
            var expected = new List<int>{49,70};
            //act
            var actual = ys.Filter(n => n % 7 == 0 && n > 42);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterForLeapyears()
        {
            //arange
            var ys = new List<int> {42,43,44,45,46,47,48,49,50,70,3,4,5,6,7,8,404,2000,2020,2021};          
            var expected = new List<int>{44,48,4,8,404,2000,2020};
            //act
            var actual = ys.Filter(n => n % 4 == 0 && (n % 100 != 0 || n % 400 == 0));
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UriIsSecure()
        {
            //arange
            var input = new Uri ("https://github.com");
            var expected = true;
            //act
            var actual = input.IsSecure();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordCountInString()
        {
            ///arange
            var input = "Vi er en super fantastisk gruppe det her, funger godt, vi arbejder på mandag. Resten fra nu af er bare loren ipsum eller bedre kendt som fylde text.";
            var expected = 29;
            //act
            var actual = input.WordCount();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
