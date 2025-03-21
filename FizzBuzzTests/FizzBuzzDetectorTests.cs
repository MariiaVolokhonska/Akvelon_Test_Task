using Xunit;
using FizzBuzz;
using System;

namespace FizzBuzzTests
{
    public class FizzBuzzDetectorTests
    {
        private FizzBuzzDetector detector;

        public FizzBuzzDetectorTests()
        {
            detector = new FizzBuzzDetector();
        }

        [Fact]
        public void TestExampleFizzBuzz()
        {
            string input = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";
            var result = detector.GetOverlappings(input);
            Assert.Equal(9, result.Count);
            Assert.Equal("Mary had Fizz little Buzz Fizz lamb, little Fizz Buzz had Fizz little lamb FizzBuzz fleece was Fizz as Buzz", result.OutputString);
        }

        [Fact]
        public void TestBasicFizzBuzz()
        {
            string input = "I love cats and dogs and they love me back";
            var result = detector.GetOverlappings(input);
            Assert.Equal(5, result.Count);
            Assert.Equal("I love Fizz and Buzz Fizz they love Fizz Buzz", result.OutputString);
        }

        [Fact]
        public void TestCommasFizzBuzz()
        {
            string input = "I love cats, and dogs, and they love me back";
            var result = detector.GetOverlappings(input);
            Assert.Equal(5, result.Count);
            Assert.Equal("I love Fizz, and Buzz, Fizz they love Fizz Buzz", result.OutputString);
        }

        [Fact]
        public void TestLessThan7Characters()
        {
            string input = "I love";
            var exception = Assert.Throws<ArgumentException>(() => detector.GetOverlappings(input));
            Assert.Equal("An error occured: Input string doesn't meet length constraints.", exception.Message);
        }

        [Fact]
        public void TestMoreThan100Characters()
        {
            string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            var exception = Assert.Throws<ArgumentException>(() => detector.GetOverlappings(input));
            Assert.Equal("An error occured: Input string doesn't meet length constraints.", exception.Message);
        }

        [Fact]
        public void TestLineBreak()
        {
            string input = @"I love cats and dogs
and they love me back";
            var result = detector.GetOverlappings(input);
            Assert.Equal(5, result.Count);
            Assert.Equal(@"I love Fizz and Buzz
Fizz they love Fizz Buzz", result.OutputString);
        }
    }
}