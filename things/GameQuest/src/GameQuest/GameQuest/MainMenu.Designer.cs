namespace GameQuest
{
    partial class MainMenu
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
            this.GameListView = new System.Windows.Forms.ListView();
            this.GameTItleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeToBeatColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalHoursColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameTitleTextBox = new System.Windows.Forms.TextBox();
            this.TimeToBeatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddGameButton = new System.Windows.Forms.Button();
            this.RemoveGameButton = new System.Windows.Forms.Button();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.HoursPerDayTextBox = new System.Windows.Forms.TextBox();
            this.CompleteText1Label = new System.Windows.Forms.Label();
            this.CompleteText2Label = new System.Windows.Forms.Label();
            this.CompleteText3Label = new System.Windows.Forms.Label();
            this.CompleteText4Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameListView
            // 
            this.GameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameTItleColumnHeader,
            this.TimeToBeatColumnHeader,
            this.TotalHoursColumnHeader});
            this.GameListView.HideSelection = false;
            this.GameListView.Location = new System.Drawing.Point(13, 41);
            this.GameListView.Name = "GameListView";
            this.GameListView.Size = new System.Drawing.Size(365, 188);
            this.GameListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.GameListView.TabIndex = 0;
            this.GameListView.UseCompatibleStateImageBehavior = false;
            this.GameListView.View = System.Windows.Forms.View.Details;
            this.GameListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.GameListView_ColumnClick);
            this.GameListView.SelectedIndexChanged += new System.EventHandler(this.GameListView_SelectedIndexChanged);
            // 
            // GameTItleColumnHeader
            // 
            this.GameTItleColumnHeader.Text = "Game Title";
            this.GameTItleColumnHeader.Width = 120;
            // 
            // TimeToBeatColumnHeader
            // 
            this.TimeToBeatColumnHeader.Text = "Time to Beat";
            this.TimeToBeatColumnHeader.Width = 100;
            // 
            // TotalHoursColumnHeader
            // 
            this.TotalHoursColumnHeader.Text = "Total Hours";
            this.TotalHoursColumnHeader.Width = 100;
            // 
            // GameTitleTextBox
            // 
            this.GameTitleTextBox.Location = new System.Drawing.Point(13, 18);
            this.GameTitleTextBox.Name = "GameTitleTextBox";
            this.GameTitleTextBox.Size = new System.Drawing.Size(134, 20);
            this.GameTitleTextBox.TabIndex = 1;
            // 
            // TimeToBeatTextBox
            // 
            this.TimeToBeatTextBox.Location = new System.Drawing.Point(150, 18);
            this.TimeToBeatTextBox.Name = "TimeToBeatTextBox";
            this.TimeToBeatTextBox.Size = new System.Drawing.Size(134, 20);
            this.TimeToBeatTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time to Beat (in hours)";
            // 
            // AddGameButton
            // 
            this.AddGameButton.Location = new System.Drawing.Point(286, 17);
            this.AddGameButton.Name = "AddGameButton";
            this.AddGameButton.Size = new System.Drawing.Size(93, 22);
            this.AddGameButton.TabIndex = 5;
            this.AddGameButton.Text = "Add Game";
            this.AddGameButton.UseVisualStyleBackColor = true;
            this.AddGameButton.Click += new System.EventHandler(this.AddGameButton_Click);
            // 
            // RemoveGameButton
            // 
            this.RemoveGameButton.Location = new System.Drawing.Point(12, 231);
            this.RemoveGameButton.Name = "RemoveGameButton";
            this.RemoveGameButton.Size = new System.Drawing.Size(106, 28);
            this.RemoveGameButton.TabIndex = 6;
            this.RemoveGameButton.Text = "Complete Selected";
            this.RemoveGameButton.UseVisualStyleBackColor = true;
            this.RemoveGameButton.Click += new System.EventHandler(this.RemoveGameButton_Click);
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTimeLabel.Location = new System.Drawing.Point(208, 249);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(59, 13);
            this.TotalTimeLabel.TabIndex = 8;
            this.TotalTimeLabel.Text = "0d 0h 0m";
            // 
            // HoursPerDayTextBox
            // 
            this.HoursPerDayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HoursPerDayTextBox.Location = new System.Drawing.Point(224, 232);
            this.HoursPerDayTextBox.Name = "HoursPerDayTextBox";
            this.HoursPerDayTextBox.Size = new System.Drawing.Size(21, 13);
            this.HoursPerDayTextBox.TabIndex = 9;
            this.HoursPerDayTextBox.Text = "24";
            this.HoursPerDayTextBox.TextChanged += new System.EventHandler(this.HoursPerDayTextBox_TextChanged);
            // 
            // CompleteText1Label
            // 
            this.CompleteText1Label.AutoSize = true;
            this.CompleteText1Label.Location = new System.Drawing.Point(120, 231);
            this.CompleteText1Label.Name = "CompleteText1Label";
            this.CompleteText1Label.Size = new System.Drawing.Size(103, 13);
            this.CompleteText1Label.TabIndex = 10;
            this.CompleteText1Label.Text = "If you were to spend";
            // 
            // CompleteText2Label
            // 
            this.CompleteText2Label.AutoSize = true;
            this.CompleteText2Label.Location = new System.Drawing.Point(245, 231);
            this.CompleteText2Label.Name = "CompleteText2Label";
            this.CompleteText2Label.Size = new System.Drawing.Size(125, 13);
            this.CompleteText2Label.TabIndex = 11;
            this.CompleteText2Label.Text = "hour(s) each day playing,";
            // 
            // CompleteText3Label
            // 
            this.CompleteText3Label.AutoSize = true;
            this.CompleteText3Label.Location = new System.Drawing.Point(120, 249);
            this.CompleteText3Label.Name = "CompleteText3Label";
            this.CompleteText3Label.Size = new System.Drawing.Size(87, 13);
            this.CompleteText3Label.TabIndex = 12;
            this.CompleteText3Label.Text = "it would take you";
            // 
            // CompleteText4Label
            // 
            this.CompleteText4Label.AutoSize = true;
            this.CompleteText4Label.Location = new System.Drawing.Point(266, 249);
            this.CompleteText4Label.Name = "CompleteText4Label";
            this.CompleteText4Label.Size = new System.Drawing.Size(92, 13);
            this.CompleteText4Label.TabIndex = 13;
            this.CompleteText4Label.Text = "to beat 0 game(s).";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 267);
            this.Controls.Add(this.CompleteText4Label);
            this.Controls.Add(this.CompleteText3Label);
            this.Controls.Add(this.CompleteText2Label);
            this.Controls.Add(this.CompleteText1Label);
            this.Controls.Add(this.HoursPerDayTextBox);
            this.Controls.Add(this.TotalTimeLabel);
            this.Controls.Add(this.RemoveGameButton);
            this.Controls.Add(this.AddGameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeToBeatTextBox);
            this.Controls.Add(this.GameTitleTextBox);
            this.Controls.Add(this.GameListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "GameQuest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView GameListView;
        private System.Windows.Forms.ColumnHeader GameTItleColumnHeader;
        private System.Windows.Forms.ColumnHeader TimeToBeatColumnHeader;
        private System.Windows.Forms.TextBox GameTitleTextBox;
        private System.Windows.Forms.TextBox TimeToBeatTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddGameButton;
        private System.Windows.Forms.Button RemoveGameButton;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.ColumnHeader TotalHoursColumnHeader;
        private System.Windows.Forms.TextBox HoursPerDayTextBox;
        private System.Windows.Forms.Label CompleteText1Label;
        private System.Windows.Forms.Label CompleteText2Label;
        private System.Windows.Forms.Label CompleteText3Label;
        private System.Windows.Forms.Label CompleteText4Label;
    }
}

