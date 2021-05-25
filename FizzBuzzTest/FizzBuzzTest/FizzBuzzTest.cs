using System;
using Xunit;
using FizzBuzzImplementation;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ReturnsOneWhenNumberIsOne()
        {
            var input = 1;
            var output = FizzBuzzImplement.GetValue(input);
            Assert.Equal("1", output);
        }


        [Fact]
        public void ReturnsTwoWhenNumberIsTwo()
        {
            var input = 2;
            var output = FizzBuzzImplement.GetValue(input);
            Assert.Equal("2", output);
        }


        [Fact]
        public void ReturnsFizzIfNumberIs3()
        {
            var input = 3;
            var output = FizzBuzzImplement.GetValue(input);
            Assert.Equal("FIZZ", output);
        }

        [Fact]
        public void ReturnsBuzzIfNumberIs5()
        {
            var input = 5;
            var output = FizzBuzzImplement.GetValue(input);
            Assert.Equal("BUZZ", output);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]       
        [InlineData(21)]
        [InlineData(27)]
        public void ReturnsFizzWhenNumbersAreDivBy3(int input)
        {
            var output = FizzBuzzImplement.GetValue(input);
            Assert.Equal("FIZZ", output);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        public void ReturnsBuzzWhenNumbersAreDivBy5(int input)
        {
            var output = FizzBuzzImplement.GetValue(input);
            Assert.Equal("BUZZ", output);
        }



        [Theory]
        [InlineData(30)]
        [InlineData(60)]
        public void ReturnsFizzBuzzWhenNumbersAreDivBy5And3(int input)
        {
            var output = FizzBuzzImplement.GetValue(input);
            Assert.Equal("FIZZBUZZ", output);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        public void ReturnsNumberWhenNumbersAreNotDivBy5And3(int input, string result)
        {
            var output = FizzBuzzImplement.GetValue(input);
            Assert.Equal(result, output);
        }
    }
}
