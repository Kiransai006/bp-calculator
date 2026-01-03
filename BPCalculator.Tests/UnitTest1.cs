using Xunit;
using BPCalculator;

namespace BPCalculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void High_BP_When_Systolic_140()
        {
            var bp = new BloodPressure { Systolic = 140, Diastolic = 90 };
            Assert.Equal(BPCategory.High, bp.Category);
        }

        [Fact]
        public void PreHigh_BP_When_Systolic_120()
        {
            var bp = new BloodPressure { Systolic = 120, Diastolic = 80 };
            Assert.Equal(BPCategory.PreHigh, bp.Category);
        }

        [Fact]
        public void Ideal_BP_When_Normal()
        {
            var bp = new BloodPressure { Systolic = 110, Diastolic = 70 };
            Assert.Equal(BPCategory.Ideal, bp.Category);
        }

        [Fact]
        public void Low_BP_When_Low()
        {
            var bp = new BloodPressure { Systolic = 80, Diastolic = 50 };
            Assert.Equal(BPCategory.Low, bp.Category);
        }
    }
}
