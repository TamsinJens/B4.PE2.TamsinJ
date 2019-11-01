using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace B4.PE2.TamsinJ.Domain.Tests
{
    class ConversionServiceTests
    {
        int[] Integerinputs;
        ConversionService cs = new ConversionService();

        public ConversionServiceTests()
        {
            Integerinputs = TestData.Integerinputs;
        }

        [Fact]
        public void DaysToHours_Returns_IntOfHours()
        {
            var integer = Integerinputs[0];
            int hours = cs.DaysToHours(integer);
            Assert.Equal(hours, 120);
        }
    }
}
