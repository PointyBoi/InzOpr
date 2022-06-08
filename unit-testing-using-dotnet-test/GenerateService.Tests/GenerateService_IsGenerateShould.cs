using Xunit;
using SimpleBank;

namespace Generate.UnitTests.Services
{
    public class GenerateService_IsGenerateShould
    {
        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 1, 2, 3, 4, 5, 6 });

            Assert.Equal(result, 7);
        }
    }
}