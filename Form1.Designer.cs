namespace CssScraper
{
    partial class Form1
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
            this.browseBtn = new System.Windows.Forms.Button();
            this.scrapeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.userFilePath = new System.Windows.Forms.TextBox();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.discardBtn = new System.Windows.Forms.Button();
            this.wordsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBtn.Location = new System.Drawing.Point(522, 12);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(90, 23);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // scrapeBtn
            // 
            this.scrapeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrapeBtn.Location = new System.Drawing.Point(12, 41);
            this.scrapeBtn.Name = "scrapeBtn";
            this.scrapeBtn.Size = new System.Drawing.Size(600, 23);
            this.scrapeBtn.TabIndex = 1;
            this.scrapeBtn.Text = "Scrape";
            this.scrapeBtn.UseVisualStyleBackColor = true;
            this.scrapeBtn.Click += new System.EventHandler(this.ScrapeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(456, 406);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // userFilePath
            // 
            this.userFilePath.Location = new System.Drawing.Point(12, 12);
            this.userFilePath.Name = "userFilePath";
            this.userFilePath.Size = new System.Drawing.Size(501, 20);
            this.userFilePath.TabIndex = 3;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(12, 70);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(600, 330);
            this.resultsTextBox.TabIndex = 4;
            this.resultsTextBox.Text = "";
            // 
            // discardBtn
            // 
            this.discardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discardBtn.Location = new System.Drawing.Point(537, 406);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(75, 23);
            this.discardBtn.TabIndex = 5;
            this.discardBtn.Text = "Quit";
            this.discardBtn.UseVisualStyleBackColor = true;
            this.discardBtn.Click += new System.EventHandler(this.DiscardBtn_Click);
            // 
            // wordsCount
            // 
            this.wordsCount.AutoSize = true;
            this.wordsCount.Location = new System.Drawing.Point(12, 411);
            this.wordsCount.Name = "wordsCount";
            this.wordsCount.Size = new System.Drawing.Size(46, 13);
            this.wordsCount.TabIndex = 6;
            this.wordsCount.Text = "Classes ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.wordsCount);
            this.Controls.Add(this.discardBtn);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.userFilePath);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.scrapeBtn);
            this.Controls.Add(this.browseBtn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Css Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button scrapeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox userFilePath;
        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.Label wordsCount;
    }
}

