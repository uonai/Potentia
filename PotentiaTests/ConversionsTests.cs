using System;
using System.Collections.Generic;
using System.Text;
using Potentia;
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

        [Fact]
        public void AssignMetrics()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Formula = "BRZYCKI";
            userInfo.Metric = "KILOGRAMS";
            userInfo.Repetitions = 3;
            userInfo.Weight = 100;

            
            Lift metrics = Conversions.AssignMetrics(userInfo);
            Assert.True(metrics.Kilograms == 100);
            Assert.True(metrics.Kilograms < 500);
            Assert.True(metrics.Pounds > metrics.Kilograms);
            Assert.True(metrics.Pounds < metrics.Kilograms * 3);
        }
    }
}
