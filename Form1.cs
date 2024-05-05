using System;
using System.Windows.Forms;

namespace CssScraper
{    
    public partial class Form1 : Form
    {
        private HTMLClassExtractor scrapper;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            scrapper = new HTMLClassExtractor();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            userFilePath.Text = fd.FileName.ToString();
        }

        private void ScrapeBtn_Click(object sender, EventArgs e)
        {
            if (userFilePath.Text.ToString() != "")
            {
                scrapper.setInputFile(userFilePath.Text);

                resultsTextBox.ResetText();

                wordsCount.Text += scrapper.ExtractClasses().Count.ToString();

                foreach (string words in scrapper.ExtractClasses())
                {
                    resultsTextBox.Text += (words + "\n");
                }
            }
            else
            {
                MessageBox.Show("Error : Please select the html file first.", "Error");
            }
        }

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.ToString() != "")
            {
                FileDialog fd = new SaveFileDialog();
                fd.ShowDialog();
                string saveFilePath = fd.FileName.ToString();

                try
                {
                    System.IO.File.WriteAllText(saveFilePath, resultsTextBox.Text);
                    MessageBox.Show("Succes : Succesfuly created the file.", "Succes");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error : " + exc.Message, "Error");
                }                
            }
            else
            {
                MessageBox.Show("Error : Please scrap the classes first.", "Error");
            }
        }
    }
}
