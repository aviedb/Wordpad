using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordpad_1061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontButton_1061_1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(richTextBox_1061_1.Text))
            {
                richTextBox_1061_1.SelectionFont = fontDialog1.Font;
            }
        }

        private void regularButton_1061_1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox_1061_1.Text))
            {
                richTextBox_1061_1.SelectionFont = new Font(fontDialog1.Font, FontStyle.Regular);
            }
        }

        private void boldButton_1061_1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox_1061_1.Text))
            {
                Font currentFont = richTextBox_1061_1.SelectionFont;

                richTextBox_1061_1.SelectionFont = new Font(fontDialog1.Font, currentFont.Style | FontStyle.Bold);
            }
        }

        private void italicButton_1061_1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox_1061_1.Text))
            {
                Font currentFont = richTextBox_1061_1.SelectionFont;

                richTextBox_1061_1.SelectionFont = new Font(fontDialog1.Font, currentFont.Style | FontStyle.Italic);
            }
        }

        private void underlineButton_1061_1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox_1061_1.Text))
            {
                Font currentFont = richTextBox_1061_1.SelectionFont;

                richTextBox_1061_1.SelectionFont = new Font(fontDialog1.Font, currentFont.Style | FontStyle.Underline);
            }
        }

        private void strikeoutButton_1061_1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox_1061_1.Text))
            {
                Font currentFont = richTextBox_1061_1.SelectionFont;

                richTextBox_1061_1.SelectionFont = new Font(fontDialog1.Font, currentFont.Style | FontStyle.Strikeout);
            }
        }

        private void colorButton_1061_1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(richTextBox_1061_1.Text))
            {
                richTextBox_1061_1.SelectionColor = colorDialog1.Color;
            }
        }

        private void alignLeftButton_1061_1_Click(object sender, EventArgs e)
        {
            richTextBox_1061_1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCenterButton_1061_1_Click(object sender, EventArgs e)
        {
            richTextBox_1061_1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignRightButton_1061_1_Click(object sender, EventArgs e)
        {
            richTextBox_1061_1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void newToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            richTextBox_1061_1.Clear();
        }

        private void openToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Open File";
            of.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (of.ShowDialog() == DialogResult.OK)
            {
                richTextBox_1061_1.LoadFile(of.FileName, RichTextBoxStreamType.RichText);
            }

            this.Text = of.FileName;
        }

        private void saveToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save File";
            sf.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                richTextBox_1061_1.SaveFile(sf.FileName, RichTextBoxStreamType.RichText);
            }

            this.Text = sf.FileName;
        }

        private void closeToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectAllToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            richTextBox_1061_1.SelectAll();
        }

        private void cutToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            richTextBox_1061_1.Cut();
        }

        private void copyToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            richTextBox_1061_1.Copy();
        }

        private void pasteToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            richTextBox_1061_1.Paste();
        }

        private void imageToolStripMenuItem_1061_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Insert Image";
            of.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp";

            var res = of.ShowDialog();

            if (res == DialogResult.OK)
            {
                var temp = Clipboard.GetDataObject();
                Clipboard.SetImage(Image.FromFile(of.FileName));
                richTextBox_1061_1.Paste();
                Clipboard.SetDataObject(temp);
            }
        }
    }
}
