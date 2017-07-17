using System.Collections.Generic;

namespace Code_Test_Sujish_TextComparer
{
    public interface ICompare
    {
        IEnumerable<int> Compare(string text, string subText);
    }
}
