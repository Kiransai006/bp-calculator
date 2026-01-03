using System.ComponentModel.DataAnnotations;

namespace BPCalculator
{
    // Blood Pressure categories
    public enum BPCategory
    {
        Low,
        Ideal,
        PreHigh,
        High
    }

    public class BloodPressure
    {
        [Range(70, 190)]
        public int Systolic { get; set; }

        [Range(40, 100)]
        public int Diastolic { get; set; }

        // Calculated category
        public BPCategory Category
        {
            get
            {
                if (Systolic >= 140 || Diastolic >= 90)
                    return BPCategory.High;

                if (Systolic >= 120 || Diastolic >= 80)
                    return BPCategory.PreHigh;

                if (Systolic >= 90 && Diastolic >= 60)
                    return BPCategory.Ideal;

                return BPCategory.Low;
            }
        }
    }
}
