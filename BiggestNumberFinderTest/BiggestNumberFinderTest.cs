using NumberFinder;
namespace BiggestNumberFinderTest
{
    public class BiggestNumberFinderTest
    {
        [Theory]
        [InlineData(-10, -20, -30, -40, -50, -10)]
        [InlineData(5, 5, 5, 5, 5, 5)]
        [InlineData(0, -1, -2, -3, -4, 0)]
        public void FindMax_InputNumbers_ShouldReturnCorrectMaxNumber(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, int expected)
        {
            int result = BiggestNumberFinder.FindMax(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
            Assert.Equal(expected, result);
        }
    }
}