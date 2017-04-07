namespace BilgiYarismasi
{
    partial class GamePlayForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gamePlayPanel = new System.Windows.Forms.Panel();
            this.timeOverLabel = new System.Windows.Forms.Label();
            this.getExtraTimeButton = new System.Windows.Forms.Button();
            this.askAudienceButton = new System.Windows.Forms.Button();
            this.fiftyFiftyButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.choiceDButton = new System.Windows.Forms.Button();
            this.choiceCButton = new System.Windows.Forms.Button();
            this.choiceBButton = new System.Windows.Forms.Button();
            this.choiceAButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.questionCounterLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.pointPanel = new System.Windows.Forms.Panel();
            this.trueAnswerLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.savePointButton = new System.Windows.Forms.Button();
            this.pointLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.audienceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gamePlayPanel.SuspendLayout();
            this.pointPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audienceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePlayPanel
            // 
            this.gamePlayPanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePlayPanel.Controls.Add(this.timeOverLabel);
            this.gamePlayPanel.Controls.Add(this.getExtraTimeButton);
            this.gamePlayPanel.Controls.Add(this.askAudienceButton);
            this.gamePlayPanel.Controls.Add(this.fiftyFiftyButton);
            this.gamePlayPanel.Controls.Add(this.questionLabel);
            this.gamePlayPanel.Controls.Add(this.choiceDButton);
            this.gamePlayPanel.Controls.Add(this.choiceCButton);
            this.gamePlayPanel.Controls.Add(this.choiceBButton);
            this.gamePlayPanel.Controls.Add(this.choiceAButton);
            this.gamePlayPanel.Location = new System.Drawing.Point(12, 134);
            this.gamePlayPanel.Name = "gamePlayPanel";
            this.gamePlayPanel.Size = new System.Drawing.Size(776, 527);
            this.gamePlayPanel.TabIndex = 0;
            this.gamePlayPanel.Visible = false;
            // 
            // timeOverLabel
            // 
            this.timeOverLabel.AutoSize = true;
            this.timeOverLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.timeOverLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeOverLabel.ForeColor = System.Drawing.Color.White;
            this.timeOverLabel.Location = new System.Drawing.Point(427, 176);
            this.timeOverLabel.Name = "timeOverLabel";
            this.timeOverLabel.Size = new System.Drawing.Size(270, 25);
            this.timeOverLabel.TabIndex = 23;
            this.timeOverLabel.Text = "Time is up. Next question >>";
            this.timeOverLabel.Visible = false;
            this.timeOverLabel.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // getExtraTimeButton
            // 
            this.getExtraTimeButton.BackColor = System.Drawing.Color.Transparent;
            this.getExtraTimeButton.BackgroundImage = global::BilgiYarismasi.Properties.Resources.ekstratime;
            this.getExtraTimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.getExtraTimeButton.FlatAppearance.BorderSize = 0;
            this.getExtraTimeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.getExtraTimeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.getExtraTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getExtraTimeButton.Location = new System.Drawing.Point(701, 373);
            this.getExtraTimeButton.Name = "getExtraTimeButton";
            this.getExtraTimeButton.Size = new System.Drawing.Size(70, 70);
            this.getExtraTimeButton.TabIndex = 14;
            this.getExtraTimeButton.UseVisualStyleBackColor = false;
            this.getExtraTimeButton.Click += new System.EventHandler(this.getExtraTimeButton_Click);
            // 
            // askAudienceButton
            // 
            this.askAudienceButton.BackColor = System.Drawing.Color.Transparent;
            this.askAudienceButton.BackgroundImage = global::BilgiYarismasi.Properties.Resources.askAudience;
            this.askAudienceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.askAudienceButton.FlatAppearance.BorderSize = 0;
            this.askAudienceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.askAudienceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.askAudienceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.askAudienceButton.Location = new System.Drawing.Point(703, 211);
            this.askAudienceButton.Name = "askAudienceButton";
            this.askAudienceButton.Size = new System.Drawing.Size(70, 70);
            this.askAudienceButton.TabIndex = 13;
            this.askAudienceButton.UseVisualStyleBackColor = false;
            this.askAudienceButton.Click += new System.EventHandler(this.askAudienceButton_Click);
            // 
            // fiftyFiftyButton
            // 
            this.fiftyFiftyButton.BackColor = System.Drawing.Color.Transparent;
            this.fiftyFiftyButton.BackgroundImage = global::BilgiYarismasi.Properties.Resources.Classic5050;
            this.fiftyFiftyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fiftyFiftyButton.FlatAppearance.BorderSize = 0;
            this.fiftyFiftyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fiftyFiftyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fiftyFiftyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiftyFiftyButton.Location = new System.Drawing.Point(702, 291);
            this.fiftyFiftyButton.Name = "fiftyFiftyButton";
            this.fiftyFiftyButton.Size = new System.Drawing.Size(70, 70);
            this.fiftyFiftyButton.TabIndex = 12;
            this.fiftyFiftyButton.UseVisualStyleBackColor = false;
            this.fiftyFiftyButton.Click += new System.EventHandler(this.fiftyFiftyButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.questionLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(12, 2);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(761, 202);
            this.questionLabel.TabIndex = 11;
            this.questionLabel.Text = "SORULAR";
            // 
            // choiceDButton
            // 
            this.choiceDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.choiceDButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choiceDButton.FlatAppearance.BorderSize = 0;
            this.choiceDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceDButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.choiceDButton.ForeColor = System.Drawing.Color.White;
            this.choiceDButton.Image = global::BilgiYarismasi.Properties.Resources.D;
            this.choiceDButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choiceDButton.Location = new System.Drawing.Point(12, 453);
            this.choiceDButton.Name = "choiceDButton";
            this.choiceDButton.Size = new System.Drawing.Size(685, 70);
            this.choiceDButton.TabIndex = 10;
            this.choiceDButton.Text = "4. ŞIK";
            this.choiceDButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.choiceDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.choiceDButton.UseVisualStyleBackColor = false;
            this.choiceDButton.Click += new System.EventHandler(this.choiceDButton_Click);
            // 
            // choiceCButton
            // 
            this.choiceCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.choiceCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choiceCButton.FlatAppearance.BorderSize = 0;
            this.choiceCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceCButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.choiceCButton.ForeColor = System.Drawing.Color.White;
            this.choiceCButton.Image = global::BilgiYarismasi.Properties.Resources.C;
            this.choiceCButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choiceCButton.Location = new System.Drawing.Point(12, 373);
            this.choiceCButton.Name = "choiceCButton";
            this.choiceCButton.Size = new System.Drawing.Size(685, 70);
            this.choiceCButton.TabIndex = 9;
            this.choiceCButton.Text = "3. ŞIK";
            this.choiceCButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.choiceCButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.choiceCButton.UseVisualStyleBackColor = false;
            this.choiceCButton.Click += new System.EventHandler(this.choiceCButton_Click);
            // 
            // choiceBButton
            // 
            this.choiceBButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.choiceBButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choiceBButton.FlatAppearance.BorderSize = 0;
            this.choiceBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceBButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.choiceBButton.ForeColor = System.Drawing.Color.White;
            this.choiceBButton.Image = global::BilgiYarismasi.Properties.Resources.B;
            this.choiceBButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choiceBButton.Location = new System.Drawing.Point(12, 293);
            this.choiceBButton.Name = "choiceBButton";
            this.choiceBButton.Size = new System.Drawing.Size(685, 70);
            this.choiceBButton.TabIndex = 8;
            this.choiceBButton.Text = "2. ŞIK";
            this.choiceBButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.choiceBButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.choiceBButton.UseVisualStyleBackColor = false;
            this.choiceBButton.Click += new System.EventHandler(this.choiceBButton_Click);
            // 
            // choiceAButton
            // 
            this.choiceAButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.choiceAButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.choiceAButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choiceAButton.FlatAppearance.BorderSize = 0;
            this.choiceAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceAButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.choiceAButton.ForeColor = System.Drawing.Color.White;
            this.choiceAButton.Image = global::BilgiYarismasi.Properties.Resources.A;
            this.choiceAButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choiceAButton.Location = new System.Drawing.Point(12, 213);
            this.choiceAButton.Name = "choiceAButton";
            this.choiceAButton.Size = new System.Drawing.Size(685, 70);
            this.choiceAButton.TabIndex = 7;
            this.choiceAButton.Text = "1. ŞIK";
            this.choiceAButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.choiceAButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.choiceAButton.UseVisualStyleBackColor = false;
            this.choiceAButton.Click += new System.EventHandler(this.choiceAButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(652, 105);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(86, 26);
            this.TimeLabel.TabIndex = 12;
            this.TimeLabel.Text = "Second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Question :";
            // 
            // questionCounterLabel
            // 
            this.questionCounterLabel.AutoSize = true;
            this.questionCounterLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionCounterLabel.ForeColor = System.Drawing.Color.White;
            this.questionCounterLabel.Location = new System.Drawing.Point(122, 106);
            this.questionCounterLabel.Name = "questionCounterLabel";
            this.questionCounterLabel.Size = new System.Drawing.Size(51, 25);
            this.questionCounterLabel.TabIndex = 15;
            this.questionCounterLabel.Text = "1/15";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Times New Roman", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(214, 243);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(373, 114);
            this.startLabel.TabIndex = 15;
            this.startLabel.Text = "BAŞLA";
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 1000;
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.BackColor = System.Drawing.Color.Transparent;
            this.nextQuestionButton.FlatAppearance.BorderSize = 0;
            this.nextQuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextQuestionButton.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextQuestionButton.ForeColor = System.Drawing.Color.White;
            this.nextQuestionButton.Location = new System.Drawing.Point(608, 64);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(180, 32);
            this.nextQuestionButton.TabIndex = 19;
            this.nextQuestionButton.Text = "Next Question >>";
            this.nextQuestionButton.UseVisualStyleBackColor = false;
            this.nextQuestionButton.Visible = false;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // pointPanel
            // 
            this.pointPanel.Controls.Add(this.trueAnswerLabel);
            this.pointPanel.Controls.Add(this.label4);
            this.pointPanel.Controls.Add(this.exitButton);
            this.pointPanel.Controls.Add(this.savePointButton);
            this.pointPanel.Controls.Add(this.pointLabel);
            this.pointPanel.Controls.Add(this.label1);
            this.pointPanel.Location = new System.Drawing.Point(112, 198);
            this.pointPanel.Name = "pointPanel";
            this.pointPanel.Size = new System.Drawing.Size(576, 205);
            this.pointPanel.TabIndex = 20;
            this.pointPanel.Visible = false;
            // 
            // trueAnswerLabel
            // 
            this.trueAnswerLabel.AutoSize = true;
            this.trueAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trueAnswerLabel.ForeColor = System.Drawing.Color.White;
            this.trueAnswerLabel.Location = new System.Drawing.Point(295, 71);
            this.trueAnswerLabel.Name = "trueAnswerLabel";
            this.trueAnswerLabel.Size = new System.Drawing.Size(0, 37);
            this.trueAnswerLabel.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "True Answer :";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(150)))), ((int)(((byte)(84)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(155, 125);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 32);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit Without Save";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // savePointButton
            // 
            this.savePointButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(150)))), ((int)(((byte)(84)))));
            this.savePointButton.FlatAppearance.BorderSize = 0;
            this.savePointButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.savePointButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.savePointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savePointButton.ForeColor = System.Drawing.Color.White;
            this.savePointButton.Location = new System.Drawing.Point(295, 125);
            this.savePointButton.Name = "savePointButton";
            this.savePointButton.Size = new System.Drawing.Size(134, 32);
            this.savePointButton.TabIndex = 15;
            this.savePointButton.Text = "Save Point";
            this.savePointButton.UseVisualStyleBackColor = false;
            this.savePointButton.Click += new System.EventHandler(this.savePointButton_Click);
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pointLabel.ForeColor = System.Drawing.Color.White;
            this.pointLabel.Location = new System.Drawing.Point(295, 8);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(0, 37);
            this.pointLabel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Point :";
            // 
            // audienceChart
            // 
            this.audienceChart.BackColor = System.Drawing.Color.Transparent;
            this.audienceChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.WallWidth = 4;
            chartArea1.Name = "ChartArea1";
            this.audienceChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend1.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Times New Roman", 10F);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.InterlacedRowsColor = System.Drawing.Color.Transparent;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.audienceChart.Legends.Add(legend1);
            this.audienceChart.Location = new System.Drawing.Point(215, 1);
            this.audienceChart.Name = "audienceChart";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Transparent;
            series1.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series1.Font = new System.Drawing.Font("Times New Roman", 10F);
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series1.MarkerSize = 1;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10;
            series1.Name = "Audience";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.YValuesPerPoint = 4;
            this.audienceChart.Series.Add(series1);
            this.audienceChart.Size = new System.Drawing.Size(373, 128);
            this.audienceChart.TabIndex = 22;
            this.audienceChart.Visible = false;
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
            this.closeButton.TabIndex = 21;
            this.closeButton.Tag = "EXİT";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgiYarismasi.Properties.Resources.Feedbin_Icon_clock_svg;
            this.pictureBox1.Location = new System.Drawing.Point(619, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 55);
            this.label2.TabIndex = 23;
            this.label2.Text = "Make Your Choice";
            // 
            // GamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.audienceChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questionCounterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gamePlayPanel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.pointPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamePlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePlayForm";
            this.gamePlayPanel.ResumeLayout(false);
            this.gamePlayPanel.PerformLayout();
            this.pointPanel.ResumeLayout(false);
            this.pointPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audienceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePlayPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button choiceDButton;
        private System.Windows.Forms.Button choiceCButton;
        private System.Windows.Forms.Button choiceBButton;
        private System.Windows.Forms.Button choiceAButton;
        private System.Windows.Forms.Button getExtraTimeButton;
        private System.Windows.Forms.Button askAudienceButton;
        private System.Windows.Forms.Button fiftyFiftyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label questionCounterLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Panel pointPanel;
        private System.Windows.Forms.Button savePointButton;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart audienceChart;
        private System.Windows.Forms.Label trueAnswerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeOverLabel;
        private System.Windows.Forms.Label label2;
    }
}