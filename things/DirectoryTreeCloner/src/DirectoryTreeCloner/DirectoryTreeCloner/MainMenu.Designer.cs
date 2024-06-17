namespace DirectoryTreeCloner
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
            this.CloneButton = new System.Windows.Forms.Button();
            this.FromBrowseButton = new System.Windows.Forms.Button();
            this.ToBrowseButton = new System.Windows.Forms.Button();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloneButton
            // 
            this.CloneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloneButton.Location = new System.Drawing.Point(38, 55);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(102, 30);
            this.CloneButton.TabIndex = 0;
            this.CloneButton.Text = "Clone";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // FromBrowseButton
            // 
            this.FromBrowseButton.Location = new System.Drawing.Point(141, 10);
            this.FromBrowseButton.Name = "FromBrowseButton";
            this.FromBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.FromBrowseButton.TabIndex = 1;
            this.FromBrowseButton.Text = "Browse";
            this.FromBrowseButton.UseVisualStyleBackColor = true;
            this.FromBrowseButton.Click += new System.EventHandler(this.FromBrowseButton_Click);
            // 
            // ToBrowseButton
            // 
            this.ToBrowseButton.Location = new System.Drawing.Point(141, 32);
            this.ToBrowseButton.Name = "ToBrowseButton";
            this.ToBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.ToBrowseButton.TabIndex = 2;
            this.ToBrowseButton.Text = "Browse";
            this.ToBrowseButton.UseVisualStyleBackColor = true;
            this.ToBrowseButton.Click += new System.EventHandler(this.ToBrowseButton_Click);
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(39, 11);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(100, 20);
            this.FromTextBox.TabIndex = 3;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(39, 33);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(100, 20);
            this.ToTextBox.TabIndex = 4;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(6, 13);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(33, 13);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(6, 35);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(23, 13);
            this.ToLabel.TabIndex = 6;
            this.ToLabel.Text = "To:";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(36, 86);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(52, 13);
            this.ProgressLabel.TabIndex = 7;
            this.ProgressLabel.Text = "Waiting...";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 104);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.ToBrowseButton);
            this.Controls.Add(this.FromBrowseButton);
            this.Controls.Add(this.CloneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "DirectoryTreeCloner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloneButton;
        private System.Windows.Forms.Button FromBrowseButton;
        private System.Windows.Forms.Button ToBrowseButton;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label ProgressLabel;
    }
}

