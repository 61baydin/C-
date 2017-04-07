namespace BilgiYarismasi
{
    partial class QuestionAdviceForm
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
            this.questionDetailsPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.timeTrackBar = new System.Windows.Forms.TrackBar();
            this.sendAdviceButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.levelRadioButton3 = new System.Windows.Forms.RadioButton();
            this.levelRadioButton1 = new System.Windows.Forms.RadioButton();
            this.levelRadioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTrueRadioButton = new System.Windows.Forms.RadioButton();
            this.aTrueRadioButton = new System.Windows.Forms.RadioButton();
            this.bTrueRadioButton = new System.Windows.Forms.RadioButton();
            this.cTrueRadioButton = new System.Windows.Forms.RadioButton();
            this.topicListBox = new System.Windows.Forms.ListBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionAdviceLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.makeYourChoiceLabel = new System.Windows.Forms.Label();
            this.questionDetailsPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionDetailsPanel
            // 
            this.questionDetailsPanel.BackColor = System.Drawing.Color.Transparent;
            this.questionDetailsPanel.Controls.Add(this.groupBox3);
            this.questionDetailsPanel.Controls.Add(this.sendAdviceButton);
            this.questionDetailsPanel.Controls.Add(this.groupBox2);
            this.questionDetailsPanel.Controls.Add(this.groupBox1);
            this.questionDetailsPanel.Controls.Add(this.topicListBox);
            this.questionDetailsPanel.Controls.Add(this.aTextBox);
            this.questionDetailsPanel.Controls.Add(this.dTextBox);
            this.questionDetailsPanel.Controls.Add(this.bTextBox);
            this.questionDetailsPanel.Controls.Add(this.cTextBox);
            this.questionDetailsPanel.Controls.Add(this.questionTextBox);
            this.questionDetailsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.questionDetailsPanel.Location = new System.Drawing.Point(0, 144);
            this.questionDetailsPanel.Name = "questionDetailsPanel";
            this.questionDetailsPanel.Size = new System.Drawing.Size(800, 556);
            this.questionDetailsPanel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox3.Controls.Add(this.secondLabel);
            this.groupBox3.Controls.Add(this.timeTrackBar);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(405, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 150);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question Time";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secondLabel.Location = new System.Drawing.Point(144, 28);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(104, 25);
            this.secondLabel.TabIndex = 21;
            this.secondLabel.Text = "15 Second";
            // 
            // timeTrackBar
            // 
            this.timeTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.timeTrackBar.Location = new System.Drawing.Point(46, 81);
            this.timeTrackBar.Maximum = 150;
            this.timeTrackBar.Minimum = 15;
            this.timeTrackBar.Name = "timeTrackBar";
            this.timeTrackBar.Size = new System.Drawing.Size(305, 45);
            this.timeTrackBar.SmallChange = 5;
            this.timeTrackBar.TabIndex = 20;
            this.timeTrackBar.TickFrequency = 15;
            this.timeTrackBar.Value = 15;
            this.timeTrackBar.Scroll += new System.EventHandler(this.timeTrackBar_Scroll);
            // 
            // sendAdviceButton
            // 
            this.sendAdviceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(150)))), ((int)(((byte)(84)))));
            this.sendAdviceButton.FlatAppearance.BorderSize = 0;
            this.sendAdviceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.sendAdviceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.sendAdviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendAdviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendAdviceButton.ForeColor = System.Drawing.Color.White;
            this.sendAdviceButton.Location = new System.Drawing.Point(213, 477);
            this.sendAdviceButton.Name = "sendAdviceButton";
            this.sendAdviceButton.Size = new System.Drawing.Size(375, 38);
            this.sendAdviceButton.TabIndex = 23;
            this.sendAdviceButton.Text = "Send Advice";
            this.sendAdviceButton.UseVisualStyleBackColor = false;
            this.sendAdviceButton.Click += new System.EventHandler(this.sendAdviceButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox2.Controls.Add(this.levelRadioButton3);
            this.groupBox2.Controls.Add(this.levelRadioButton1);
            this.groupBox2.Controls.Add(this.levelRadioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(188, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 52);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question Level";
            // 
            // levelRadioButton3
            // 
            this.levelRadioButton3.AutoSize = true;
            this.levelRadioButton3.Location = new System.Drawing.Point(122, 18);
            this.levelRadioButton3.Name = "levelRadioButton3";
            this.levelRadioButton3.Size = new System.Drawing.Size(35, 23);
            this.levelRadioButton3.TabIndex = 19;
            this.levelRadioButton3.Text = "3";
            this.levelRadioButton3.UseVisualStyleBackColor = true;
            this.levelRadioButton3.CheckedChanged += new System.EventHandler(this.levelRadioButton3_CheckedChanged);
            // 
            // levelRadioButton1
            // 
            this.levelRadioButton1.AutoSize = true;
            this.levelRadioButton1.Checked = true;
            this.levelRadioButton1.Location = new System.Drawing.Point(46, 18);
            this.levelRadioButton1.Name = "levelRadioButton1";
            this.levelRadioButton1.Size = new System.Drawing.Size(35, 23);
            this.levelRadioButton1.TabIndex = 17;
            this.levelRadioButton1.TabStop = true;
            this.levelRadioButton1.Text = "1";
            this.levelRadioButton1.UseVisualStyleBackColor = true;
            this.levelRadioButton1.CheckedChanged += new System.EventHandler(this.levelRadioButton1_CheckedChanged);
            // 
            // levelRadioButton2
            // 
            this.levelRadioButton2.AutoSize = true;
            this.levelRadioButton2.Location = new System.Drawing.Point(84, 18);
            this.levelRadioButton2.Name = "levelRadioButton2";
            this.levelRadioButton2.Size = new System.Drawing.Size(35, 23);
            this.levelRadioButton2.TabIndex = 18;
            this.levelRadioButton2.Text = "2";
            this.levelRadioButton2.UseVisualStyleBackColor = true;
            this.levelRadioButton2.CheckedChanged += new System.EventHandler(this.levelRadioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox1.Controls.Add(this.dTrueRadioButton);
            this.groupBox1.Controls.Add(this.aTrueRadioButton);
            this.groupBox1.Controls.Add(this.bTrueRadioButton);
            this.groupBox1.Controls.Add(this.cTrueRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 52);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "True Choice";
            // 
            // dTrueRadioButton
            // 
            this.dTrueRadioButton.AutoSize = true;
            this.dTrueRadioButton.Location = new System.Drawing.Point(126, 18);
            this.dTrueRadioButton.Name = "dTrueRadioButton";
            this.dTrueRadioButton.Size = new System.Drawing.Size(38, 23);
            this.dTrueRadioButton.TabIndex = 16;
            this.dTrueRadioButton.Text = "D";
            this.dTrueRadioButton.UseVisualStyleBackColor = true;
            this.dTrueRadioButton.CheckedChanged += new System.EventHandler(this.dTrueRadioButton_CheckedChanged);
            // 
            // aTrueRadioButton
            // 
            this.aTrueRadioButton.AutoSize = true;
            this.aTrueRadioButton.Checked = true;
            this.aTrueRadioButton.Location = new System.Drawing.Point(12, 18);
            this.aTrueRadioButton.Name = "aTrueRadioButton";
            this.aTrueRadioButton.Size = new System.Drawing.Size(38, 23);
            this.aTrueRadioButton.TabIndex = 13;
            this.aTrueRadioButton.TabStop = true;
            this.aTrueRadioButton.Text = "A";
            this.aTrueRadioButton.UseVisualStyleBackColor = true;
            this.aTrueRadioButton.CheckedChanged += new System.EventHandler(this.aTrueRadioButton_CheckedChanged);
            // 
            // bTrueRadioButton
            // 
            this.bTrueRadioButton.AutoSize = true;
            this.bTrueRadioButton.Location = new System.Drawing.Point(50, 18);
            this.bTrueRadioButton.Name = "bTrueRadioButton";
            this.bTrueRadioButton.Size = new System.Drawing.Size(37, 23);
            this.bTrueRadioButton.TabIndex = 14;
            this.bTrueRadioButton.Text = "B";
            this.bTrueRadioButton.UseVisualStyleBackColor = true;
            this.bTrueRadioButton.CheckedChanged += new System.EventHandler(this.bTrueRadioButton_CheckedChanged);
            // 
            // cTrueRadioButton
            // 
            this.cTrueRadioButton.AutoSize = true;
            this.cTrueRadioButton.Location = new System.Drawing.Point(88, 18);
            this.cTrueRadioButton.Name = "cTrueRadioButton";
            this.cTrueRadioButton.Size = new System.Drawing.Size(38, 23);
            this.cTrueRadioButton.TabIndex = 15;
            this.cTrueRadioButton.Text = "C";
            this.cTrueRadioButton.UseVisualStyleBackColor = true;
            this.cTrueRadioButton.CheckedChanged += new System.EventHandler(this.cTrueRadioButton_CheckedChanged);
            // 
            // topicListBox
            // 
            this.topicListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topicListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topicListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topicListBox.ForeColor = System.Drawing.Color.White;
            this.topicListBox.FormattingEnabled = true;
            this.topicListBox.ItemHeight = 19;
            this.topicListBox.Location = new System.Drawing.Point(12, 363);
            this.topicListBox.Name = "topicListBox";
            this.topicListBox.Size = new System.Drawing.Size(375, 78);
            this.topicListBox.TabIndex = 11;
            // 
            // aTextBox
            // 
            this.aTextBox.AccessibleDescription = "";
            this.aTextBox.AccessibleName = "";
            this.aTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.aTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aTextBox.ForeColor = System.Drawing.Color.White;
            this.aTextBox.Location = new System.Drawing.Point(12, 105);
            this.aTextBox.Multiline = true;
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(375, 75);
            this.aTextBox.TabIndex = 6;
            this.aTextBox.Tag = "";
            this.aTextBox.Text = "A";
            this.aTextBox.Enter += new System.EventHandler(this.aTextBox_Enter);
            // 
            // dTextBox
            // 
            this.dTextBox.AccessibleDescription = "";
            this.dTextBox.AccessibleName = "";
            this.dTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTextBox.ForeColor = System.Drawing.Color.White;
            this.dTextBox.Location = new System.Drawing.Point(403, 201);
            this.dTextBox.Multiline = true;
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(375, 75);
            this.dTextBox.TabIndex = 9;
            this.dTextBox.Tag = "";
            this.dTextBox.Text = "D";
            this.dTextBox.Enter += new System.EventHandler(this.dTextBox_Enter);
            // 
            // bTextBox
            // 
            this.bTextBox.AccessibleDescription = "";
            this.bTextBox.AccessibleName = "";
            this.bTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTextBox.ForeColor = System.Drawing.Color.White;
            this.bTextBox.Location = new System.Drawing.Point(403, 105);
            this.bTextBox.Multiline = true;
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(375, 75);
            this.bTextBox.TabIndex = 7;
            this.bTextBox.Tag = "";
            this.bTextBox.Text = "B";
            this.bTextBox.Enter += new System.EventHandler(this.bTextBox_Enter);
            // 
            // cTextBox
            // 
            this.cTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cTextBox.ForeColor = System.Drawing.Color.White;
            this.cTextBox.Location = new System.Drawing.Point(12, 201);
            this.cTextBox.Multiline = true;
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(375, 75);
            this.cTextBox.TabIndex = 8;
            this.cTextBox.Tag = "";
            this.cTextBox.Text = "C";
            this.cTextBox.Enter += new System.EventHandler(this.cTextBox_Enter);
            // 
            // questionTextBox
            // 
            this.questionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.questionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionTextBox.ForeColor = System.Drawing.Color.White;
            this.questionTextBox.Location = new System.Drawing.Point(12, 15);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(768, 75);
            this.questionTextBox.TabIndex = 5;
            this.questionTextBox.Tag = "";
            this.questionTextBox.Text = "Question";
            this.questionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.questionTextBox.Enter += new System.EventHandler(this.questionTextBox_Enter);
            // 
            // questionAdviceLabel
            // 
            this.questionAdviceLabel.AutoSize = true;
            this.questionAdviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionAdviceLabel.ForeColor = System.Drawing.Color.White;
            this.questionAdviceLabel.Location = new System.Drawing.Point(315, 91);
            this.questionAdviceLabel.Name = "questionAdviceLabel";
            this.questionAdviceLabel.Size = new System.Drawing.Size(171, 26);
            this.questionAdviceLabel.TabIndex = 1;
            this.questionAdviceLabel.Text = "Question Advice";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::BilgiYarismasi.Properties.Resources.close;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(757, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(43, 18);
            this.closeButton.TabIndex = 24;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // makeYourChoiceLabel
            // 
            this.makeYourChoiceLabel.AutoSize = true;
            this.makeYourChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.makeYourChoiceLabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.makeYourChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.makeYourChoiceLabel.Location = new System.Drawing.Point(211, 9);
            this.makeYourChoiceLabel.Name = "makeYourChoiceLabel";
            this.makeYourChoiceLabel.Size = new System.Drawing.Size(379, 55);
            this.makeYourChoiceLabel.TabIndex = 25;
            this.makeYourChoiceLabel.Text = "Make Your Choice";
            // 
            // QuestionAdviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.makeYourChoiceLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.questionAdviceLabel);
            this.Controls.Add(this.questionDetailsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionAdviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionAdviceForm";
            this.Load += new System.EventHandler(this.QuestionAdviceForm_Load);
            this.questionDetailsPanel.ResumeLayout(false);
            this.questionDetailsPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel questionDetailsPanel;
        private System.Windows.Forms.Label questionAdviceLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.RadioButton dTrueRadioButton;
        private System.Windows.Forms.RadioButton cTrueRadioButton;
        private System.Windows.Forms.RadioButton bTrueRadioButton;
        private System.Windows.Forms.RadioButton aTrueRadioButton;
        private System.Windows.Forms.ListBox topicListBox;
        private System.Windows.Forms.RadioButton levelRadioButton3;
        private System.Windows.Forms.RadioButton levelRadioButton2;
        private System.Windows.Forms.RadioButton levelRadioButton1;
        private System.Windows.Forms.TrackBar timeTrackBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendAdviceButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label makeYourChoiceLabel;
    }
}