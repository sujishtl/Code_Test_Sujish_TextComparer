using System;
using System.Collections.Generic;
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
            try
            {
                String text = rtText.Text;

                String subText = tbSubText.Text;
                ICompare comparer = null;

                comparer = ComparerFactory.Get(cbLegacyCompare.Checked ? ComparerFactory.ComparerType.Legacy : ComparerFactory.ComparerType.Yield);

                PrintResults(comparer.Compare(text, subText));
            }
            catch (Exception ex)
            {
                lbResults.Text = ex.Message;
            }
        }

        ///<summary>
        ///Method which print the results to a label in the UI
        ///</summary>
        ///<param name="letterMatchPositions">a list of integers which represent the character positions of the beginning of each match for the subtext within the text. </param>  
        private void PrintResults(IEnumerable<int> letterMatchPositions)
        {
            try
            {
                var matchingPositions = string.Empty;

                foreach (var i in letterMatchPositions)
                {
                    if (matchingPositions == string.Empty)
                        matchingPositions = i.ToString();
                    else
                        matchingPositions = matchingPositions + "," + i;

                }
                if (matchingPositions == string.Empty)
                    lbResults.Text = "No Matches";
                else
                    lbResults.Text = "Matching positions are " + matchingPositions;
            }
            catch (Exception ex)
            {

                lbResults.Text = ex.Message;
            }

        }

        private void cbLegacyCompare_CheckedChanged(object sender, EventArgs e)
        {
            cbYield.Checked = !cbLegacyCompare.Checked;
        }

        private void cbYield_CheckedChanged(object sender, EventArgs e)
        {
            cbLegacyCompare.Checked = !cbYield.Checked;
        }

        public enum ComparerType
        {
            Legacy = 1,
            Yield = 2
        };
    }

}
