using System;
using TempUnitConverter;
using Xunit;

namespace TempUnitConverterTest
{
    public class UnitTest1
    {
        Converter con = new Converter();
        [Fact]
        public void CToKTestShouldReturnDouble()
        {
            Assert.Equal(273.15, con.CToK(0));
        }
        [Fact]
        public void CToFTestShouldReturnDouble()
        {
            Assert.Equal(32, con.CToF(0));
        }

        [Fact]
        public void KToCTestShouldReturnDouble()
        {
            Assert.Equal(-273.15, con.KToC(0));
        }

        [Fact]
        public void KToFTestShouldReturnDouble()
        {
            Assert.Equal(-459.67, con.KToF(0));
        }

        [Fact]
        public void FToCTestShouldReturnDouble()
        {
            Assert.Equal(0, con.FToC(32));
        }

        [Fact]
        public void FToKTestShouldReturnDouble()
        {
            Assert.Equal(273.15, con.FToK(32));
        }

        [Theory]
        [InlineData(273.15, 0)]
        [InlineData(283.15, 10)]
        [InlineData(373.15, 100)]
        public void CToKTestShouldReturnDoubles(double value1, double value2)
        {
            Assert.Equal(value1, con.CToK(value2));
        }

    }
}
