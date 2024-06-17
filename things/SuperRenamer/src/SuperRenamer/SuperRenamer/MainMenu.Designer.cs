namespace SuperRenamer
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
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SuperRenamerLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.RenameLabel = new System.Windows.Forms.Label();
            this.OldStringTextBox = new System.Windows.Forms.TextBox();
            this.WithLabel = new System.Windows.Forms.Label();
            this.NewStringTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(13, 47);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(100, 20);
            this.PathTextBox.TabIndex = 2;
            // 
            // SuperRenamerLabel
            // 
            this.SuperRenamerLabel.AutoSize = true;
            this.SuperRenamerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperRenamerLabel.Location = new System.Drawing.Point(8, 9);
            this.SuperRenamerLabel.Name = "SuperRenamerLabel";
            this.SuperRenamerLabel.Size = new System.Drawing.Size(118, 20);
            this.SuperRenamerLabel.TabIndex = 3;
            this.SuperRenamerLabel.Text = "SuperRenamer";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(11, 34);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(29, 13);
            this.PathLabel.TabIndex = 4;
            this.PathLabel.Text = "Path";
            // 
            // RenameLabel
            // 
            this.RenameLabel.AutoSize = true;
            this.RenameLabel.Location = new System.Drawing.Point(10, 70);
            this.RenameLabel.Name = "RenameLabel";
            this.RenameLabel.Size = new System.Drawing.Size(47, 13);
            this.RenameLabel.TabIndex = 6;
            this.RenameLabel.Text = "Rename";
            // 
            // OldStringTextBox
            // 
            this.OldStringTextBox.Location = new System.Drawing.Point(13, 83);
            this.OldStringTextBox.Name = "OldStringTextBox";
            this.OldStringTextBox.Size = new System.Drawing.Size(100, 20);
            this.OldStringTextBox.TabIndex = 5;
            // 
            // WithLabel
            // 
            this.WithLabel.AutoSize = true;
            this.WithLabel.Location = new System.Drawing.Point(113, 85);
            this.WithLabel.Name = "WithLabel";
            this.WithLabel.Size = new System.Drawing.Size(26, 13);
            this.WithLabel.TabIndex = 8;
            this.WithLabel.Text = "with";
            // 
            // NewStringTextBox
            // 
            this.NewStringTextBox.Location = new System.Drawing.Point(141, 83);
            this.NewStringTextBox.Name = "NewStringTextBox";
            this.NewStringTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewStringTextBox.TabIndex = 7;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(113, 46);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(51, 22);
            this.BrowseButton.TabIndex = 9;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameButton.Location = new System.Drawing.Point(12, 107);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(102, 36);
            this.RenameButton.TabIndex = 10;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 149);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.WithLabel);
            this.Controls.Add(this.NewStringTextBox);
            this.Controls.Add(this.RenameLabel);
            this.Controls.Add(this.OldStringTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.SuperRenamerLabel);
            this.Controls.Add(this.PathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "SuperRenamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label SuperRenamerLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label RenameLabel;
        private System.Windows.Forms.TextBox OldStringTextBox;
        private System.Windows.Forms.Label WithLabel;
        private System.Windows.Forms.TextBox NewStringTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button RenameButton;
    }
}

