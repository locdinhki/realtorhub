using System;
namespace RealtorHub.Models
{
    public enum CodeTier
    {
        COPPER,
        SILVER,
        GOLD,
        PLATINUM,
        DIAMOND
    }
    public class CodeModel
    {
        public class Code
        {
            public int ID { get; set; }
            public string Value { get; set; }
            public int DiscountTier { get; set; }
            public double[] DiscountRate = { .08, .1, .12, .15, .2 };
        }

    }
}
