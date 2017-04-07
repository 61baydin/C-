namespace IMDB_Project
{
    partial class DetailsMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsMovieForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addWatchListPictureBox = new System.Windows.Forms.PictureBox();
            this.commentsGroupBox = new System.Windows.Forms.GroupBox();
            this.commentsPanel = new System.Windows.Forms.Panel();
            this.newCommentGroupBox = new System.Windows.Forms.GroupBox();
            this.removeReplyButton = new System.Windows.Forms.Button();
            this.replyToLabel = new System.Windows.Forms.Label();
            this.pointComboBox = new System.Windows.Forms.ComboBox();
            this.sendCommentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.trailerPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.knownForGroupBox = new System.Windows.Forms.GroupBox();
            this.bestStarLabel4 = new System.Windows.Forms.Label();
            this.bestStarLabel3 = new System.Windows.Forms.Label();
            this.bestStarLabel2 = new System.Windows.Forms.Label();
            this.bestStarLabel1 = new System.Windows.Forms.Label();
            this.bestStarPictureBox4 = new System.Windows.Forms.PictureBox();
            this.bestStarPictureBox3 = new System.Windows.Forms.PictureBox();
            this.bestStarPictureBox2 = new System.Windows.Forms.PictureBox();
            this.bestStarPictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moviePointLabel = new System.Windows.Forms.Label();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.movieAboutLabel = new System.Windows.Forms.Label();
            this.movieLeadingRoleLabel = new System.Windows.Forms.Label();
            this.movieAuthorLabel = new System.Windows.Forms.Label();
            this.movieDirectorLabel = new System.Windows.Forms.Label();
            this.movieReleaseDateLabel = new System.Windows.Forms.Label();
            this.movieTypeLabel = new System.Windows.Forms.Label();
            this.movieTimeLabel = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.moviePictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addWatchListPictureBox)).BeginInit();
            this.commentsGroupBox.SuspendLayout();
            this.newCommentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trailerPlayer)).BeginInit();
            this.knownForGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestStarPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestStarPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestStarPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestStarPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.addWatchListPictureBox);
            this.mainPanel.Controls.Add(this.commentsGroupBox);
            this.mainPanel.Controls.Add(this.newCommentGroupBox);
            this.mainPanel.Controls.Add(this.trailerPlayer);
            this.mainPanel.Controls.Add(this.knownForGroupBox);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.moviePointLabel);
            this.mainPanel.Controls.Add(this.AboutPanel);
            this.mainPanel.Controls.Add(this.movieLeadingRoleLabel);
            this.mainPanel.Controls.Add(this.movieAuthorLabel);
            this.mainPanel.Controls.Add(this.movieDirectorLabel);
            this.mainPanel.Controls.Add(this.movieReleaseDateLabel);
            this.mainPanel.Controls.Add(this.movieTypeLabel);
            this.mainPanel.Controls.Add(this.movieTimeLabel);
            this.mainPanel.Controls.Add(this.movieNameLabel);
            this.mainPanel.Controls.Add(this.moviePictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(714, 692);
            this.mainPanel.TabIndex = 2;
            // 
            // addWatchListPictureBox
            // 
            this.addWatchListPictureBox.AccessibleDescription = "";
            this.addWatchListPictureBox.Image = global::IMDB_Project.Properties.Resources.addWatchlist;
            this.addWatchListPictureBox.Location = new System.Drawing.Point(10, 10);
            this.addWatchListPictureBox.Name = "addWatchListPictureBox";
            this.addWatchListPictureBox.Size = new System.Drawing.Size(40, 50);
            this.addWatchListPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addWatchListPictureBox.TabIndex = 29;
            this.addWatchListPictureBox.TabStop = false;
            this.addWatchListPictureBox.Click += new System.EventHandler(this.addWatchListPictureBox_Click);
            // 
            // commentsGroupBox
            // 
            this.commentsGroupBox.Controls.Add(this.commentsPanel);
            this.commentsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commentsGroupBox.Location = new System.Drawing.Point(0, 780);
            this.commentsGroupBox.Name = "commentsGroupBox";
            this.commentsGroupBox.Size = new System.Drawing.Size(697, 100);
            this.commentsGroupBox.TabIndex = 27;
            this.commentsGroupBox.TabStop = false;
            this.commentsGroupBox.Text = "Comments";
            // 
            // commentsPanel
            // 
            this.commentsPanel.AutoScroll = true;
            this.commentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentsPanel.Location = new System.Drawing.Point(3, 16);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Size = new System.Drawing.Size(691, 81);
            this.commentsPanel.TabIndex = 0;
            // 
            // newCommentGroupBox
            // 
            this.newCommentGroupBox.Controls.Add(this.removeReplyButton);
            this.newCommentGroupBox.Controls.Add(this.replyToLabel);
            this.newCommentGroupBox.Controls.Add(this.pointComboBox);
            this.newCommentGroupBox.Controls.Add(this.sendCommentButton);
            this.newCommentGroupBox.Controls.Add(this.label1);
            this.newCommentGroupBox.Controls.Add(this.commentTextBox);
            this.newCommentGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newCommentGroupBox.Location = new System.Drawing.Point(0, 880);
            this.newCommentGroupBox.Name = "newCommentGroupBox";
            this.newCommentGroupBox.Size = new System.Drawing.Size(697, 212);
            this.newCommentGroupBox.TabIndex = 26;
            this.newCommentGroupBox.TabStop = false;
            this.newCommentGroupBox.Text = "New Comment";
            // 
            // removeReplyButton
            // 
            this.removeReplyButton.BackgroundImage = global::IMDB_Project.Properties.Resources.symbol_remove;
            this.removeReplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeReplyButton.FlatAppearance.BorderSize = 0;
            this.removeReplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeReplyButton.Location = new System.Drawing.Point(224, 21);
            this.removeReplyButton.Name = "removeReplyButton";
            this.removeReplyButton.Size = new System.Drawing.Size(27, 13);
            this.removeReplyButton.TabIndex = 6;
            this.removeReplyButton.UseVisualStyleBackColor = true;
            this.removeReplyButton.Visible = false;
            this.removeReplyButton.Click += new System.EventHandler(this.removeReplyButton_Click);
            // 
            // replyToLabel
            // 
            this.replyToLabel.AutoSize = true;
            this.replyToLabel.Location = new System.Drawing.Point(39, 21);
            this.replyToLabel.Name = "replyToLabel";
            this.replyToLabel.Size = new System.Drawing.Size(14, 13);
            this.replyToLabel.TabIndex = 5;
            this.replyToLabel.Text = "#";
            // 
            // pointComboBox
            // 
            this.pointComboBox.FormattingEnabled = true;
            this.pointComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.pointComboBox.Location = new System.Drawing.Point(569, 13);
            this.pointComboBox.Name = "pointComboBox";
            this.pointComboBox.Size = new System.Drawing.Size(121, 21);
            this.pointComboBox.TabIndex = 4;
            // 
            // sendCommentButton
            // 
            this.sendCommentButton.Location = new System.Drawing.Point(587, 186);
            this.sendCommentButton.Name = "sendCommentButton";
            this.sendCommentButton.Size = new System.Drawing.Size(105, 23);
            this.sendCommentButton.TabIndex = 3;
            this.sendCommentButton.Text = "Send Comment";
            this.sendCommentButton.UseVisualStyleBackColor = true;
            this.sendCommentButton.Click += new System.EventHandler(this.sendCommentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Re :";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(6, 40);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(685, 140);
            this.commentTextBox.TabIndex = 1;
            // 
            // trailerPlayer
            // 
            this.trailerPlayer.Enabled = true;
            this.trailerPlayer.Location = new System.Drawing.Point(160, 63);
            this.trailerPlayer.Name = "trailerPlayer";
            this.trailerPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("trailerPlayer.OcxState")));
            this.trailerPlayer.Size = new System.Drawing.Size(530, 250);
            this.trailerPlayer.TabIndex = 25;
            // 
            // knownForGroupBox
            // 
            this.knownForGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.knownForGroupBox.Controls.Add(this.bestStarLabel4);
            this.knownForGroupBox.Controls.Add(this.bestStarLabel3);
            this.knownForGroupBox.Controls.Add(this.bestStarLabel2);
            this.knownForGroupBox.Controls.Add(this.bestStarLabel1);
            this.knownForGroupBox.Controls.Add(this.bestStarPictureBox4);
            this.knownForGroupBox.Controls.Add(this.bestStarPictureBox3);
            this.knownForGroupBox.Controls.Add(this.bestStarPictureBox2);
            this.knownForGroupBox.Controls.Add(this.bestStarPictureBox1);
            this.knownForGroupBox.Location = new System.Drawing.Point(6, 470);
            this.knownForGroupBox.Name = "knownForGroupBox";
            this.knownForGroupBox.Size = new System.Drawing.Size(684, 310);
            this.knownForGroupBox.TabIndex = 24;
            this.knownForGroupBox.TabStop = false;
            this.knownForGroupBox.Text = "Best Stars";
            // 
            // bestStarLabel4
            // 
            this.bestStarLabel4.Location = new System.Drawing.Point(529, 270);
            this.bestStarLabel4.Name = "bestStarLabel4";
            this.bestStarLabel4.Size = new System.Drawing.Size(150, 35);
            this.bestStarLabel4.TabIndex = 32;
            this.bestStarLabel4.Text = "label1";
            // 
            // bestStarLabel3
            // 
            this.bestStarLabel3.Location = new System.Drawing.Point(356, 270);
            this.bestStarLabel3.Name = "bestStarLabel3";
            this.bestStarLabel3.Size = new System.Drawing.Size(150, 35);
            this.bestStarLabel3.TabIndex = 31;
            this.bestStarLabel3.Text = "label1";
            // 
            // bestStarLabel2
            // 
            this.bestStarLabel2.Location = new System.Drawing.Point(177, 270);
            this.bestStarLabel2.Name = "bestStarLabel2";
            this.bestStarLabel2.Size = new System.Drawing.Size(150, 35);
            this.bestStarLabel2.TabIndex = 30;
            this.bestStarLabel2.Text = "label1";
            // 
            // bestStarLabel1
            // 
            this.bestStarLabel1.Location = new System.Drawing.Point(6, 270);
            this.bestStarLabel1.Name = "bestStarLabel1";
            this.bestStarLabel1.Size = new System.Drawing.Size(150, 35);
            this.bestStarLabel1.TabIndex = 29;
            this.bestStarLabel1.Text = "label1";
            // 
            // bestStarPictureBox4
            // 
            this.bestStarPictureBox4.Location = new System.Drawing.Point(532, 17);
            this.bestStarPictureBox4.Name = "bestStarPictureBox4";
            this.bestStarPictureBox4.Size = new System.Drawing.Size(150, 250);
            this.bestStarPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bestStarPictureBox4.TabIndex = 3;
            this.bestStarPictureBox4.TabStop = false;
            this.bestStarPictureBox4.Click += new System.EventHandler(this.bestStarPictureBox4_Click);
            // 
            // bestStarPictureBox3
            // 
            this.bestStarPictureBox3.Location = new System.Drawing.Point(356, 17);
            this.bestStarPictureBox3.Name = "bestStarPictureBox3";
            this.bestStarPictureBox3.Size = new System.Drawing.Size(150, 250);
            this.bestStarPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bestStarPictureBox3.TabIndex = 2;
            this.bestStarPictureBox3.TabStop = false;
            this.bestStarPictureBox3.Click += new System.EventHandler(this.bestStarPictureBox3_Click);
            // 
            // bestStarPictureBox2
            // 
            this.bestStarPictureBox2.Location = new System.Drawing.Point(180, 17);
            this.bestStarPictureBox2.Name = "bestStarPictureBox2";
            this.bestStarPictureBox2.Size = new System.Drawing.Size(150, 250);
            this.bestStarPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bestStarPictureBox2.TabIndex = 1;
            this.bestStarPictureBox2.TabStop = false;
            this.bestStarPictureBox2.Click += new System.EventHandler(this.bestStarPictureBox2_Click);
            // 
            // bestStarPictureBox1
            // 
            this.bestStarPictureBox1.Location = new System.Drawing.Point(5, 17);
            this.bestStarPictureBox1.Name = "bestStarPictureBox1";
            this.bestStarPictureBox1.Size = new System.Drawing.Size(150, 250);
            this.bestStarPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bestStarPictureBox1.TabIndex = 0;
            this.bestStarPictureBox1.TabStop = false;
            this.bestStarPictureBox1.Click += new System.EventHandler(this.bestStarPictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMDB_Project.Properties.Resources.star_gold;
            this.pictureBox1.Location = new System.Drawing.Point(573, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // moviePointLabel
            // 
            this.moviePointLabel.AutoSize = true;
            this.moviePointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.moviePointLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.moviePointLabel.Location = new System.Drawing.Point(604, 14);
            this.moviePointLabel.Name = "moviePointLabel";
            this.moviePointLabel.Size = new System.Drawing.Size(69, 20);
            this.moviePointLabel.TabIndex = 22;
            this.moviePointLabel.Text = "9,5 / 10";
            // 
            // AboutPanel
            // 
            this.AboutPanel.AutoScroll = true;
            this.AboutPanel.Controls.Add(this.movieAboutLabel);
            this.AboutPanel.Location = new System.Drawing.Point(8, 387);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(680, 78);
            this.AboutPanel.TabIndex = 21;
            // 
            // movieAboutLabel
            // 
            this.movieAboutLabel.AutoSize = true;
            this.movieAboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieAboutLabel.Location = new System.Drawing.Point(2, 0);
            this.movieAboutLabel.MaximumSize = new System.Drawing.Size(670, 0);
            this.movieAboutLabel.Name = "movieAboutLabel";
            this.movieAboutLabel.Size = new System.Drawing.Size(46, 17);
            this.movieAboutLabel.TabIndex = 6;
            this.movieAboutLabel.Text = "label6";
            // 
            // movieLeadingRoleLabel
            // 
            this.movieLeadingRoleLabel.AutoSize = true;
            this.movieLeadingRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieLeadingRoleLabel.Location = new System.Drawing.Point(10, 368);
            this.movieLeadingRoleLabel.Name = "movieLeadingRoleLabel";
            this.movieLeadingRoleLabel.Size = new System.Drawing.Size(56, 17);
            this.movieLeadingRoleLabel.TabIndex = 20;
            this.movieLeadingRoleLabel.Text = "Actors :";
            // 
            // movieAuthorLabel
            // 
            this.movieAuthorLabel.AutoSize = true;
            this.movieAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieAuthorLabel.Location = new System.Drawing.Point(10, 351);
            this.movieAuthorLabel.Name = "movieAuthorLabel";
            this.movieAuthorLabel.Size = new System.Drawing.Size(65, 17);
            this.movieAuthorLabel.TabIndex = 19;
            this.movieAuthorLabel.Text = "Authors :";
            // 
            // movieDirectorLabel
            // 
            this.movieDirectorLabel.AutoSize = true;
            this.movieDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieDirectorLabel.Location = new System.Drawing.Point(10, 334);
            this.movieDirectorLabel.Name = "movieDirectorLabel";
            this.movieDirectorLabel.Size = new System.Drawing.Size(73, 17);
            this.movieDirectorLabel.TabIndex = 18;
            this.movieDirectorLabel.Text = "Directors :";
            // 
            // movieReleaseDateLabel
            // 
            this.movieReleaseDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movieReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieReleaseDateLabel.Location = new System.Drawing.Point(534, 41);
            this.movieReleaseDateLabel.Name = "movieReleaseDateLabel";
            this.movieReleaseDateLabel.Size = new System.Drawing.Size(133, 17);
            this.movieReleaseDateLabel.TabIndex = 17;
            this.movieReleaseDateLabel.Text = "label5";
            this.movieReleaseDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // movieTypeLabel
            // 
            this.movieTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieTypeLabel.Location = new System.Drawing.Point(162, 41);
            this.movieTypeLabel.Name = "movieTypeLabel";
            this.movieTypeLabel.Size = new System.Drawing.Size(496, 17);
            this.movieTypeLabel.TabIndex = 16;
            this.movieTypeLabel.Text = "AKSİYON MACERA BİLİM KURGU";
            // 
            // movieTimeLabel
            // 
            this.movieTimeLabel.AutoSize = true;
            this.movieTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieTimeLabel.Location = new System.Drawing.Point(56, 41);
            this.movieTimeLabel.Name = "movieTimeLabel";
            this.movieTimeLabel.Size = new System.Drawing.Size(71, 17);
            this.movieTimeLabel.TabIndex = 15;
            this.movieTimeLabel.Text = "24:00 dk";
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieNameLabel.Location = new System.Drawing.Point(55, 10);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(512, 31);
            this.movieNameLabel.TabIndex = 14;
            this.movieNameLabel.Text = "label1";
            this.movieNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // moviePictureBox
            // 
            this.moviePictureBox.ImageLocation = "";
            this.moviePictureBox.Location = new System.Drawing.Point(10, 63);
            this.moviePictureBox.Name = "moviePictureBox";
            this.moviePictureBox.Size = new System.Drawing.Size(150, 250);
            this.moviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePictureBox.TabIndex = 1;
            this.moviePictureBox.TabStop = false;
            // 
            // DetailsMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(714, 692);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetailsMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details -";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DetailsMovieForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addWatchListPictureBox)).EndInit();
            this.commentsGroupBox.ResumeLayout(false);
            this.newCommentGroupBox.ResumeLayout(false);
            this.newCommentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trailerPlayer)).EndInit();
            this.knownForGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bestStarPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestStarPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestStarPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestStarPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox moviePictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox knownForGroupBox;
        private System.Windows.Forms.Label bestStarLabel4;
        private System.Windows.Forms.Label bestStarLabel3;
        private System.Windows.Forms.Label bestStarLabel2;
        private System.Windows.Forms.Label bestStarLabel1;
        private System.Windows.Forms.PictureBox bestStarPictureBox4;
        private System.Windows.Forms.PictureBox bestStarPictureBox3;
        private System.Windows.Forms.PictureBox bestStarPictureBox2;
        private System.Windows.Forms.PictureBox bestStarPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label moviePointLabel;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Label movieAboutLabel;
        private System.Windows.Forms.Label movieLeadingRoleLabel;
        private System.Windows.Forms.Label movieAuthorLabel;
        private System.Windows.Forms.Label movieDirectorLabel;
        private System.Windows.Forms.Label movieReleaseDateLabel;
        private System.Windows.Forms.Label movieTypeLabel;
        private System.Windows.Forms.Label movieTimeLabel;
        private System.Windows.Forms.Label movieNameLabel;
        private AxShockwaveFlashObjects.AxShockwaveFlash trailerPlayer;
        private System.Windows.Forms.GroupBox commentsGroupBox;
        private System.Windows.Forms.Panel commentsPanel;
        private System.Windows.Forms.GroupBox newCommentGroupBox;
        private System.Windows.Forms.Button sendCommentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ComboBox pointComboBox;
        private System.Windows.Forms.Label replyToLabel;
        private System.Windows.Forms.Button removeReplyButton;
        private System.Windows.Forms.PictureBox addWatchListPictureBox;
    }
}