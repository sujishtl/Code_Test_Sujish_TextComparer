using System.Collections.Generic;

namespace Code_Test_Sujish_TextComparer
{
    public class YieldComparer : ICompare
    {
        ///<summary>
        ///Method which will find the occurances of the subtext in the text using the Yield keyword
        ///</summary>
        ///<param name="text">parent string which needs to be checked for matching subtext </param>  
        ///<param name="subText">string to match</param> 
        ///<returns>a list of integers which represent the character positions of the beginning of each match for the subtext within the text. </returns>  
        public IEnumerable<int> Compare(string text, string subText)
        {
            var textChars = text.ToLower().ToCharArray();
            var subTextChars = subText.ToLower().ToCharArray();
            var isPreviousCharMatching = false;
            var subTextCtr = 0;
            var tempStartPosition = 0;

            for (var textCtr = 0; textCtr < textChars.Length; textCtr++)
            {
                if (subTextChars[subTextCtr] == textChars[textCtr])
                {
                    if (!isPreviousCharMatching)
                        tempStartPosition = textCtr;
                    isPreviousCharMatching = true;
                    if (subTextCtr == subTextChars.Length - 1)
                    {
                        yield return tempStartPosition + 1;
                        isPreviousCharMatching = false;
                        tempStartPosition = 0;
                        subTextCtr = -1;
                    }
                    subTextCtr++;
                }
                else
                {
                    isPreviousCharMatching = false;
                    subTextCtr = 0;
                }
            }
        }
    }
}
