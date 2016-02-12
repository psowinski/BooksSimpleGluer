using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BooksSimpleGluer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            var newLines = new List<string>();
            var sumLine = "";

            foreach (var line in this.bookText.Lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var trimedLine = line.Trim();
                if ((!char.IsLetterOrDigit(trimedLine[0]) || char.IsUpper(trimedLine[0])) && sumLine.Length > 10
                    && sumLine[sumLine.Length - 1] != '-' && !IsContextSpliter(trimedLine))
                {
                    newLines.Add(sumLine);
                    sumLine = trimedLine;
                }
                else if (IsContextSpliter(trimedLine))
                {
                    if (sumLine.Length > 0)
                    {
                        newLines.Add(sumLine);
                        sumLine = "";
                    }
                    newLines.Add("");
                    newLines.Add("* * *");
                    newLines.Add("");
                }
                else
                {
                    if (sumLine.Length > 0 && sumLine[sumLine.Length - 1] == '-')
                        sumLine += ' ';
                    sumLine += trimedLine;
                }
            }
            if(sumLine.Length > 0)
                newLines.Add(sumLine);

            this.bookText.Lines = newLines.ToArray();
            this.bookText.SelectionStart = 0;
            this.bookText.SelectionLength = this.bookText.TextLength;
            this.bookText.Focus();
        }

        private bool IsContextSpliter(string trimedLine)
        {
            return trimedLine == "* * *" || trimedLine == "***";
        }
    }
}
