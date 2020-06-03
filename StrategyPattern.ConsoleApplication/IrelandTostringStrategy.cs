namespace StrategyPattern.ConsoleApplication
{
    public class IrelandTostringStrategy : IToStringStrategy
    {
        public string ToString(long value)
        {
            return $"{Prefixes.Ireland} {value:# #### ####}";
        }
    }
}