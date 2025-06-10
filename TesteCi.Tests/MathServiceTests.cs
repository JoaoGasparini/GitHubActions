using TesteCi.Services;
using TesteCi.Services.Domain.Interfaces;

namespace TesteCi.Tests
{
    public class MathServiceTests
    {
        private readonly IMathService _mathService;

        public MathServiceTests()
        {
            _mathService = new MathService();
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(5, 10)]
        [InlineData(0, 0)]
        [InlineData(-3, -6)]
        public void GetDouble_ReturnsCorrectResult(int input, int expected)
        {
            // Act
            var result = _mathService.GetDouble(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
