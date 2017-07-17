namespace Code_Test_Sujish_TextComparer
{
    partial class FmTextComparer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtText = new System.Windows.Forms.RichTextBox();
            this.tbSubText = new System.Windows.Forms.TextBox();
            this.lbResults = new System.Windows.Forms.Label();
            this.cbLegacyCompare = new System.Windows.Forms.CheckBox();
            this.cbYield = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(405, 187);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(100, 34);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SubText";
            // 
            // rtText
            // 
            this.rtText.Location = new System.Drawing.Point(101, 15);
            this.rtText.Margin = new System.Windows.Forms.Padding(4);
            this.rtText.Name = "rtText";
            this.rtText.Size = new System.Drawing.Size(404, 117);
            this.rtText.TabIndex = 3;
            this.rtText.Text = "";
            // 
            // tbSubText
            // 
            this.tbSubText.Location = new System.Drawing.Point(101, 141);
            this.tbSubText.Margin = new System.Windows.Forms.Padding(4);
            this.tbSubText.Name = "tbSubText";
            this.tbSubText.Size = new System.Drawing.Size(404, 22);
            this.tbSubText.TabIndex = 4;
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Location = new System.Drawing.Point(8, 245);
            this.lbResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(0, 17);
            this.lbResults.TabIndex = 5;
            // 
            // cbLegacyCompare
            // 
            this.cbLegacyCompare.AutoSize = true;
            this.cbLegacyCompare.Location = new System.Drawing.Point(101, 200);
            this.cbLegacyCompare.Margin = new System.Windows.Forms.Padding(4);
            this.cbLegacyCompare.Name = "cbLegacyCompare";
            this.cbLegacyCompare.Size = new System.Drawing.Size(133, 21);
            this.cbLegacyCompare.TabIndex = 6;
            this.cbLegacyCompare.Text = "LegacyCompare";
            this.cbLegacyCompare.UseVisualStyleBackColor = true;
            this.cbLegacyCompare.CheckedChanged += new System.EventHandler(this.cbLegacyCompare_CheckedChanged);
            // 
            // cbYield
            // 
            this.cbYield.AutoSize = true;
            this.cbYield.Location = new System.Drawing.Point(101, 171);
            this.cbYield.Margin = new System.Windows.Forms.Padding(4);
            this.cbYield.Name = "cbYield";
            this.cbYield.Size = new System.Drawing.Size(97, 21);
            this.cbYield.TabIndex = 7;
            this.cbYield.Text = "UsingYield";
            this.cbYield.UseVisualStyleBackColor = true;
            this.cbYield.CheckedChanged += new System.EventHandler(this.cbYield_CheckedChanged);
            // 
            // FmTextComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 279);
            this.Controls.Add(this.cbYield);
            this.Controls.Add(this.cbLegacyCompare);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.tbSubText);
            this.Controls.Add(this.rtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmTextComparer";
            this.Text = "Text Compare Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtText;
        private System.Windows.Forms.TextBox tbSubText;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.CheckBox cbLegacyCompare;
        private System.Windows.Forms.CheckBox cbYield;
    }
}

