using System;
using System.Collections.Generic;
using System.Text;
using PotentiaLibrary;
using Xunit;

namespace PotentiaTests
{
    public class ConversionsTests
    {
        [Fact]
        public void KilogramsToPounds()
        {
            decimal kilogramsToPounds = Conversions.KilogramsToPounds(123);
            Assert.True(kilogramsToPounds != 0);

        }
        [Fact]
        public void PoundsToKilograms()
        {
            decimal poundsToKilograms = Conversions.PoundsToKilograms(123);
            Assert.True(poundsToKilograms != 0);

        }
    }
}
