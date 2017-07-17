
namespace Code_Test_Sujish_TextComparer
{
    /// <summary>
    /// This is the Factory method for creating the comparer factory
    /// </summary>
    public static class ComparerFactory
    {
        public static ICompare Get( ComparerType comparerType)
        {
            switch (comparerType)
            {
                case ComparerType.Legacy:
                    return new LegacyComparer();
                case ComparerType.Yield:
                    return new YieldComparer();
                default:
                    return new YieldComparer();
            }
        }

public enum ComparerType
{
    Legacy,
    Yield
}
    }
}
