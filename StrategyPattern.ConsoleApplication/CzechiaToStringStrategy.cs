namespace StrategyPattern.ConsoleApplication
{
    public class CzechiaToStringStrategy : IToStringStrategy
    {
        public string ToString(long value)
        {
            return $"{Prefixes.Czech} {value:### ### ###}";
        }
    }
}