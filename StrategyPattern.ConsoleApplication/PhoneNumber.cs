using System;
using System.Globalization;

namespace StrategyPattern.ConsoleApplication
{
    public class PhoneNumber
    {
        public long Value { get; set; }

        public PhoneNumber(long value)
        {
            Value = value;
        }

        public override string ToString()
        {
            IToStringStrategy toStringStrategy = ResolveStrategyByCulture();


            return toStringStrategy.ToString(Value);
        }

        private IToStringStrategy ResolveStrategyByCulture()
        {
            if (CultureInfo.CurrentCulture.Name == "cs-CZ")
            {
                return new CzechiaToStringStrategy();
            }

            if (CultureInfo.CurrentCulture.Name == "ga-IE")
            {
                return new IrelandTostringStrategy();
            }

            throw new Exception("Non existing strategy for culture");
        }
    }
}
