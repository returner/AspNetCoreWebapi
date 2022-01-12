using Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiTest
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            bool result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory,InlineData(2), InlineData(3), InlineData(5), InlineData(7)]
        public void IsPrime_NonPrimeLessThan10_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_NonPrimeLessThan10_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(1,2)]
        [InlineData(5,6)]
        public void Compare_False(int number1, int number2)
        {
            var result = _primeService.Compare(number1, number2);

            Assert.False(result, $"{number1} is smaller than {number2}");
        }

        [Theory]
        [InlineData(2,1)]
        [InlineData(9999, 8)]
        public void Compare_True(int number1, int number2)
        {
            var result = _primeService.Compare(number1, number2);

            Assert.True(result, $"{number1} is bigger than {number2}");
        }
    }
}
