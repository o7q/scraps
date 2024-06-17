namespace BulkFileRenamer
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
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.BrowseDirectoryButton = new System.Windows.Forms.Button();
            this.PrefixNumTextBox = new System.Windows.Forms.TextBox();
            this.PrefixNumLabel = new System.Windows.Forms.Label();
            this.SeparatorCharLabel = new System.Windows.Forms.Label();
            this.SeparatorTextBox = new System.Windows.Forms.TextBox();
            this.SuffixLabel = new System.Windows.Forms.Label();
            this.SuffixTextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryTextBox.Location = new System.Drawing.Point(12, 20);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(187, 21);
            this.DirectoryTextBox.TabIndex = 0;
            // 
            // BrowseDirectoryButton
            // 
            this.BrowseDirectoryButton.Location = new System.Drawing.Point(199, 19);
            this.BrowseDirectoryButton.Name = "BrowseDirectoryButton";
            this.BrowseDirectoryButton.Size = new System.Drawing.Size(56, 23);
            this.BrowseDirectoryButton.TabIndex = 1;
            this.BrowseDirectoryButton.Text = "Browse";
            this.BrowseDirectoryButton.UseVisualStyleBackColor = true;
            this.BrowseDirectoryButton.Click += new System.EventHandler(this.BrowseDirectoryButton_Click);
            // 
            // PrefixNumTextBox
            // 
            this.PrefixNumTextBox.Location = new System.Drawing.Point(80, 43);
            this.PrefixNumTextBox.Name = "PrefixNumTextBox";
            this.PrefixNumTextBox.Size = new System.Drawing.Size(17, 20);
            this.PrefixNumTextBox.TabIndex = 2;
            this.PrefixNumTextBox.Text = "1";
            // 
            // PrefixNumLabel
            // 
            this.PrefixNumLabel.AutoSize = true;
            this.PrefixNumLabel.Location = new System.Drawing.Point(9, 46);
            this.PrefixNumLabel.Name = "PrefixNumLabel";
            this.PrefixNumLabel.Size = new System.Drawing.Size(71, 13);
            this.PrefixNumLabel.TabIndex = 3;
            this.PrefixNumLabel.Text = "Prefix Start #:";
            // 
            // SeparatorCharLabel
            // 
            this.SeparatorCharLabel.AutoSize = true;
            this.SeparatorCharLabel.Location = new System.Drawing.Point(97, 47);
            this.SeparatorCharLabel.Name = "SeparatorCharLabel";
            this.SeparatorCharLabel.Size = new System.Drawing.Size(56, 13);
            this.SeparatorCharLabel.TabIndex = 4;
            this.SeparatorCharLabel.Text = "Separator:";
            // 
            // SeparatorTextBox
            // 
            this.SeparatorTextBox.Location = new System.Drawing.Point(150, 43);
            this.SeparatorTextBox.Name = "SeparatorTextBox";
            this.SeparatorTextBox.Size = new System.Drawing.Size(17, 20);
            this.SeparatorTextBox.TabIndex = 5;
            this.SeparatorTextBox.Text = "_";
            // 
            // SuffixLabel
            // 
            this.SuffixLabel.AutoSize = true;
            this.SuffixLabel.Location = new System.Drawing.Point(167, 47);
            this.SuffixLabel.Name = "SuffixLabel";
            this.SuffixLabel.Size = new System.Drawing.Size(36, 13);
            this.SuffixLabel.TabIndex = 6;
            this.SuffixLabel.Text = "Suffix:";
            // 
            // SuffixTextBox
            // 
            this.SuffixTextBox.Location = new System.Drawing.Point(200, 43);
            this.SuffixTextBox.Name = "SuffixTextBox";
            this.SuffixTextBox.Size = new System.Drawing.Size(54, 20);
            this.SuffixTextBox.TabIndex = 7;
            this.SuffixTextBox.Text = "filename";
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(12, 66);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(61, 30);
            this.RunButton.TabIndex = 8;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLabel.Location = new System.Drawing.Point(11, 98);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(52, 13);
            this.ProgressLabel.TabIndex = 9;
            this.ProgressLabel.Text = "Waiting...";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 116);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SuffixTextBox);
            this.Controls.Add(this.SuffixLabel);
            this.Controls.Add(this.SeparatorTextBox);
            this.Controls.Add(this.SeparatorCharLabel);
            this.Controls.Add(this.PrefixNumLabel);
            this.Controls.Add(this.PrefixNumTextBox);
            this.Controls.Add(this.BrowseDirectoryButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "BulkFileRenamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Button BrowseDirectoryButton;
        private System.Windows.Forms.TextBox PrefixNumTextBox;
        private System.Windows.Forms.Label PrefixNumLabel;
        private System.Windows.Forms.Label SeparatorCharLabel;
        private System.Windows.Forms.TextBox SeparatorTextBox;
        private System.Windows.Forms.Label SuffixLabel;
        private System.Windows.Forms.TextBox SuffixTextBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label ProgressLabel;
    }
}

