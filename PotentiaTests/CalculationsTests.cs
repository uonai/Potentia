using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PotentiaLibrary;

namespace PotentiaTests
{
    public class CalculationsTests
    {
        [Fact]
        public void BrzyckiFormula()
        {
            decimal brzyckiFormula = Calculations.BrzyckiFormula(3, (decimal)100.2);
            Assert.True(brzyckiFormula != 0);
        }

        [Fact]
        public void EpleyFormula()
        {
            decimal epleyFormula = Calculations.EpleyFormula(3, (decimal)100.2);
            Assert.True(epleyFormula != 0);
        }
        
        [Fact]
        public void LanderFormula()
        {
            decimal landerFormula = Calculations.LanderFormula(3, (decimal)100.2);
            Assert.True(landerFormula != 0);
        }

        [Fact]
        public void LombardiFormula()
        {
            decimal lombardiFormula = Calculations.LombardiFormula(3, (decimal)100.2);
            Assert.True(lombardiFormula != 0);
        }

        [Fact]
        public void OConnerFormula()
        {
            decimal oConnerFormula = Calculations.OConnerFormula(3, (decimal)100.2);
            Assert.True(oConnerFormula != 0);
        }
    }
}
