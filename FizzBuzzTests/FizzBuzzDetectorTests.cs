using Xunit;
using FizzBuzz;

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



    }
}