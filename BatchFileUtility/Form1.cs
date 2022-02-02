using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFileUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            var multilineText = FileInputTextBox.Text;
            var lines = TextParser.Parse(multilineText, Environment.NewLine);
            
            SelectorService.CopyToClipboard(lines);
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            var multilineText = FileInputTextBox.Text;
            var lines = TextParser.Parse(multilineText, Environment.NewLine);

            SelectorService.CutToClipboard(lines);
            SetDefaultTextBox();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var multilineText = FileInputTextBox.Text;
            var lines = TextParser.Parse(multilineText, Environment.NewLine);

            SelectorService.Delete(lines);
            SetDefaultTextBox();
        }

        private void SetDefaultTextBox()
        {
            FileInputTextBox.Text = "Place each filepath on a new line.";
        }
    }
}