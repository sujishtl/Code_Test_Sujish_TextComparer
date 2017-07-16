using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Test_Sujish_TextComparer
{
    public partial class FmTextComparer : Form
    {
        public FmTextComparer()
        {
            InitializeComponent();
            rtText.Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            tbSubText.Text = "polly";
            cbYield.Checked = true;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            String text = rtText.Text;

            String subText = tbSubText.Text;

            if (cbLegacyCompare.Checked)
            {
                List<int> letterMatchPositions = LegacyComparison(text, subText);
                PrintResults(letterMatchPositions);
            }
            else if (cbYield.Checked)
            {
                PrintResults(CompareWithYield(text, subText));

            }
        }

        public List<int> LegacyComparison(string text, string subText)
        {
            var textChars = text.ToLower().ToCharArray();
            var subTextChars = subText.ToLower().ToCharArray();
            bool isPreviousCharMatching = false;
            List<int> letterMatchPositions = new List<int>();
            int lMPCtr = 0;
            int sCtr = 0;
            int tempStartPosition = 0;
            for (int tCtr = 0; tCtr < textChars.Length; tCtr++)
            {
                if (subTextChars[sCtr] == textChars[tCtr])
                {
                    if (!isPreviousCharMatching)
                        tempStartPosition = tCtr;
                    isPreviousCharMatching = true;
                    if (sCtr == subTextChars.Length - 1)
                    {
                        letterMatchPositions.Add(tempStartPosition + 1);
                        isPreviousCharMatching = false;
                        tempStartPosition = 0;
                        lMPCtr++;
                        sCtr = -1;
                    }
                    sCtr++;
                }
                else
                {
                    isPreviousCharMatching = false;
                    sCtr = 0;
                }
            }

            return letterMatchPositions;
        }

        public IEnumerable<int> CompareWithYield(string text, string subText)
        {
            var textChars = text.ToLower().ToCharArray();
            var subTextChars = subText.ToLower().ToCharArray();
            bool isPreviousCharMatching = false;
            int lMPCtr = 0;
            int sCtr = 0;
            int tempStartPosition = 0;

            for (int tCtr = 0; tCtr < textChars.Length; tCtr++)
            {
                if (subTextChars[sCtr] == textChars[tCtr])
                {
                    if (!isPreviousCharMatching)
                        tempStartPosition = tCtr;
                    isPreviousCharMatching = true;
                    if (sCtr == subTextChars.Length - 1)
                    {
                        yield return tempStartPosition + 1;
                        isPreviousCharMatching = false;
                        tempStartPosition = 0;
                        lMPCtr++;
                        sCtr = -1;
                    }
                    sCtr++;
                }
                else
                {
                    isPreviousCharMatching = false;
                    sCtr = 0;
                }
            }
        }

        private void PrintResults(IEnumerable<int> letterMatchPositions)
        {
            string matchingPositions = string.Empty;

            foreach (int i in letterMatchPositions)
            {
                if (matchingPositions == string.Empty)
                    matchingPositions = i.ToString();
                else
                    matchingPositions = matchingPositions + "," + i.ToString();

            }

            if (matchingPositions == string.Empty)
                lbResults.Text = "No Matches";
            else
                lbResults.Text = "Matching positions are " + matchingPositions;

        }

        private void cbLegacyCompare_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLegacyCompare.Checked)
                cbYield.Checked = false;
            else
                cbYield.Checked = true;
        }

        private void cbYield_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYield.Checked)
                cbLegacyCompare.Checked = false;
            else
                cbLegacyCompare.Checked = true;
        }
    }

}
