
namespace FiGUI
{
    partial class Podcasts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.urlTXT = new System.Windows.Forms.TextBox();
            this.EpisodeLBL = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.episodeBox = new System.Windows.Forms.ListBox();
            this.NameLBL = new System.Windows.Forms.Label();
            this.FreqLBL = new System.Windows.Forms.Label();
            this.CategoryLBL = new System.Windows.Forms.Label();
            this.saveBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ctgDeleteBTN = new System.Windows.Forms.Button();
            this.ctgSaveBTN = new System.Windows.Forms.Button();
            this.ctgNewBTN = new System.Windows.Forms.Button();
            this.FreqCombo = new System.Windows.Forms.ComboBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.updFreqLBL = new System.Windows.Forms.Label();
            this.CategoryLBL2 = new System.Windows.Forms.Label();
            this.urlLBL = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ListBox();
            this.epEpisodeLBL = new System.Windows.Forms.Label();
            this.FeedTable = new System.Windows.Forms.TableLayoutPanel();
            this.episodeInfoLBL = new System.Windows.Forms.Label();
            this.episodeInfoText = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlTXT
            // 
            this.urlTXT.Location = new System.Drawing.Point(54, 232);
            this.urlTXT.Name = "urlTXT";
            this.urlTXT.Size = new System.Drawing.Size(206, 23);
            this.urlTXT.TabIndex = 0;
            // 
            // EpisodeLBL
            // 
            this.EpisodeLBL.AutoSize = true;
            this.EpisodeLBL.Location = new System.Drawing.Point(54, 55);
            this.EpisodeLBL.Name = "EpisodeLBL";
            this.EpisodeLBL.Size = new System.Drawing.Size(44, 15);
            this.EpisodeLBL.TabIndex = 2;
            this.EpisodeLBL.Text = "Avsnitt";
            this.EpisodeLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 614);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // episodeBox
            // 
            this.episodeBox.FormattingEnabled = true;
            this.episodeBox.ItemHeight = 15;
            this.episodeBox.Location = new System.Drawing.Point(54, 344);
            this.episodeBox.Name = "episodeBox";
            this.episodeBox.Size = new System.Drawing.Size(496, 244);
            this.episodeBox.TabIndex = 4;
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Location = new System.Drawing.Point(116, 55);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(40, 15);
            this.NameLBL.TabIndex = 5;
            this.NameLBL.Text = "Namn";
            this.NameLBL.Click += new System.EventHandler(this.NameLBL_Click);
            // 
            // FreqLBL
            // 
            this.FreqLBL.AutoSize = true;
            this.FreqLBL.Location = new System.Drawing.Point(292, 55);
            this.FreqLBL.Name = "FreqLBL";
            this.FreqLBL.Size = new System.Drawing.Size(53, 15);
            this.FreqLBL.TabIndex = 6;
            this.FreqLBL.Text = "Frekvens";
            // 
            // CategoryLBL
            // 
            this.CategoryLBL.AutoSize = true;
            this.CategoryLBL.Location = new System.Drawing.Point(419, 55);
            this.CategoryLBL.Name = "CategoryLBL";
            this.CategoryLBL.Size = new System.Drawing.Size(51, 15);
            this.CategoryLBL.TabIndex = 7;
            this.CategoryLBL.Text = "Kategori";
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(363, 261);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(86, 23);
            this.saveBTN.TabIndex = 8;
            this.saveBTN.Text = "Skapa";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(455, 261);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(95, 23);
            this.deleteBTN.TabIndex = 9;
            this.deleteBTN.Text = "Ta bort";
            this.deleteBTN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategorier";
            // 
            // ctgDeleteBTN
            // 
            this.ctgDeleteBTN.Location = new System.Drawing.Point(827, 261);
            this.ctgDeleteBTN.Name = "ctgDeleteBTN";
            this.ctgDeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.ctgDeleteBTN.TabIndex = 13;
            this.ctgDeleteBTN.Text = "Ta bort";
            this.ctgDeleteBTN.UseVisualStyleBackColor = true;
            this.ctgDeleteBTN.Click += new System.EventHandler(this.ctgDeleteBTN_Click_1);
            // 
            // ctgSaveBTN
            // 
            this.ctgSaveBTN.Location = new System.Drawing.Point(746, 261);
            this.ctgSaveBTN.Name = "ctgSaveBTN";
            this.ctgSaveBTN.Size = new System.Drawing.Size(75, 23);
            this.ctgSaveBTN.TabIndex = 12;
            this.ctgSaveBTN.Text = "Spara";
            this.ctgSaveBTN.UseVisualStyleBackColor = true;
            // 
            // ctgNewBTN
            // 
            this.ctgNewBTN.Location = new System.Drawing.Point(665, 261);
            this.ctgNewBTN.Name = "ctgNewBTN";
            this.ctgNewBTN.Size = new System.Drawing.Size(75, 23);
            this.ctgNewBTN.TabIndex = 11;
            this.ctgNewBTN.Text = "Ny";
            this.ctgNewBTN.UseVisualStyleBackColor = true;
            this.ctgNewBTN.Click += new System.EventHandler(this.ctgNewBTN_Click);
            // 
            // FreqCombo
            // 
            this.FreqCombo.FormattingEnabled = true;
            this.FreqCombo.Items.AddRange(new object[] {
            "Varje minut",
            "Var 5:e minut",
            "Var 10:e minut"});
            this.FreqCombo.Location = new System.Drawing.Point(277, 232);
            this.FreqCombo.Name = "FreqCombo";
            this.FreqCombo.Size = new System.Drawing.Size(121, 23);
            this.FreqCombo.TabIndex = 14;
            this.FreqCombo.SelectedIndexChanged += new System.EventHandler(this.FreqCombo_SelectedIndexChanged);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(429, 232);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(121, 23);
            this.CategoryCombo.TabIndex = 15;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            // 
            // updFreqLBL
            // 
            this.updFreqLBL.AutoSize = true;
            this.updFreqLBL.Location = new System.Drawing.Point(273, 214);
            this.updFreqLBL.Name = "updFreqLBL";
            this.updFreqLBL.Size = new System.Drawing.Size(125, 15);
            this.updFreqLBL.TabIndex = 16;
            this.updFreqLBL.Text = "Uppdateringsfrekvens:";
            // 
            // CategoryLBL2
            // 
            this.CategoryLBL2.AutoSize = true;
            this.CategoryLBL2.Location = new System.Drawing.Point(429, 214);
            this.CategoryLBL2.Name = "CategoryLBL2";
            this.CategoryLBL2.Size = new System.Drawing.Size(54, 15);
            this.CategoryLBL2.TabIndex = 17;
            this.CategoryLBL2.Text = "Kategori:";
            // 
            // urlLBL
            // 
            this.urlLBL.AutoSize = true;
            this.urlLBL.Location = new System.Drawing.Point(54, 214);
            this.urlLBL.Name = "urlLBL";
            this.urlLBL.Size = new System.Drawing.Size(31, 15);
            this.urlLBL.TabIndex = 18;
            this.urlLBL.Text = "URL:";
            this.urlLBL.Click += new System.EventHandler(this.label8_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.ItemHeight = 15;
            this.categoryBox.Location = new System.Drawing.Point(665, 73);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(237, 169);
            this.categoryBox.TabIndex = 19;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // epEpisodeLBL
            // 
            this.epEpisodeLBL.AutoSize = true;
            this.epEpisodeLBL.Location = new System.Drawing.Point(54, 323);
            this.epEpisodeLBL.Name = "epEpisodeLBL";
            this.epEpisodeLBL.Size = new System.Drawing.Size(44, 15);
            this.epEpisodeLBL.TabIndex = 20;
            this.epEpisodeLBL.Text = "Avsnitt";
            // 
            // FeedTable
            // 
            this.FeedTable.ColumnCount = 4;
            this.FeedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.06009F));
            this.FeedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.93991F));
            this.FeedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.FeedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.FeedTable.Location = new System.Drawing.Point(54, 73);
            this.FeedTable.Name = "FeedTable";
            this.FeedTable.RowCount = 2;
            this.FeedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.FeedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.FeedTable.Size = new System.Drawing.Size(496, 120);
            this.FeedTable.TabIndex = 21;
            // 
            // episodeInfoLBL
            // 
            this.episodeInfoLBL.AutoSize = true;
            this.episodeInfoLBL.Location = new System.Drawing.Point(665, 332);
            this.episodeInfoLBL.Name = "episodeInfoLBL";
            this.episodeInfoLBL.Size = new System.Drawing.Size(44, 15);
            this.episodeInfoLBL.TabIndex = 22;
            this.episodeInfoLBL.Text = "Avsnitt";
            this.episodeInfoLBL.Click += new System.EventHandler(this.label10_Click);
            // 
            // episodeInfoText
            // 
            this.episodeInfoText.AutoSize = true;
            this.episodeInfoText.Location = new System.Drawing.Point(665, 353);
            this.episodeInfoText.Name = "episodeInfoText";
            this.episodeInfoText.Size = new System.Drawing.Size(44, 15);
            this.episodeInfoText.TabIndex = 23;
            this.episodeInfoText.Text = "Avsnitt";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 308);
            this.label12.MaximumSize = new System.Drawing.Size(0, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 2);
            this.label12.TabIndex = 24;
            this.label12.Text = "-";
            // 
            // Podcasts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 614);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.episodeInfoText);
            this.Controls.Add(this.episodeInfoLBL);
            this.Controls.Add(this.FeedTable);
            this.Controls.Add(this.epEpisodeLBL);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.urlLBL);
            this.Controls.Add(this.CategoryLBL2);
            this.Controls.Add(this.updFreqLBL);
            this.Controls.Add(this.CategoryCombo);
            this.Controls.Add(this.FreqCombo);
            this.Controls.Add(this.ctgDeleteBTN);
            this.Controls.Add(this.ctgSaveBTN);
            this.Controls.Add(this.ctgNewBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.CategoryLBL);
            this.Controls.Add(this.FreqLBL);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.episodeBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.EpisodeLBL);
            this.Controls.Add(this.urlTXT);
            this.Name = "Podcasts";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTXT;
        private System.Windows.Forms.Label EpisodeLBL;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox episodeBox;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label FreqLBL;
        private System.Windows.Forms.Label CategoryLBL;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ctgDeleteBTN;
        private System.Windows.Forms.Button ctgSaveBTN;
        private System.Windows.Forms.Button ctgNewBTN;
        private System.Windows.Forms.ComboBox FreqCombo;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label updFreqLBL;
        private System.Windows.Forms.Label CategoryLBL2;
        private System.Windows.Forms.Label urlLBL;
        private System.Windows.Forms.ListBox categoryBox;
        private System.Windows.Forms.Label epEpisodeLBL;
        private System.Windows.Forms.TableLayoutPanel FeedTable;
        private System.Windows.Forms.Label episodeInfoLBL;
        private System.Windows.Forms.Label episodeInfoText;
        private System.Windows.Forms.Label label12;
    }
}

