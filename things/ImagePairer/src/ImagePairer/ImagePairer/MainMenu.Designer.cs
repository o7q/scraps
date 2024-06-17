namespace ImagePairer
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
            this.ViewerPictureBox = new System.Windows.Forms.PictureBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.GenerateRandomImages = new System.Windows.Forms.Button();
            this.ScrollTrackbar = new System.Windows.Forms.TrackBar();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Refresh2Button = new System.Windows.Forms.Button();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewerPictureBox
            // 
            this.ViewerPictureBox.BackColor = System.Drawing.Color.Black;
            this.ViewerPictureBox.Location = new System.Drawing.Point(11, 11);
            this.ViewerPictureBox.Name = "ViewerPictureBox";
            this.ViewerPictureBox.Size = new System.Drawing.Size(256, 256);
            this.ViewerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ViewerPictureBox.TabIndex = 0;
            this.ViewerPictureBox.TabStop = false;
            this.ViewerPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewerPictureBox_Paint);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(23, 358);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(84, 32);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.ForeColor = System.Drawing.Color.White;
            this.ProgressLabel.Location = new System.Drawing.Point(31, 409);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(52, 13);
            this.ProgressLabel.TabIndex = 2;
            this.ProgressLabel.Text = "Waiting...";
            // 
            // GenerateRandomImages
            // 
            this.GenerateRandomImages.Location = new System.Drawing.Point(111, 358);
            this.GenerateRandomImages.Name = "GenerateRandomImages";
            this.GenerateRandomImages.Size = new System.Drawing.Size(130, 32);
            this.GenerateRandomImages.TabIndex = 3;
            this.GenerateRandomImages.Text = "Gen Random Images";
            this.GenerateRandomImages.UseVisualStyleBackColor = true;
            this.GenerateRandomImages.Click += new System.EventHandler(this.GenerateRandomImages_Click);
            // 
            // ScrollTrackbar
            // 
            this.ScrollTrackbar.Location = new System.Drawing.Point(10, 268);
            this.ScrollTrackbar.Maximum = 1;
            this.ScrollTrackbar.Name = "ScrollTrackbar";
            this.ScrollTrackbar.Size = new System.Drawing.Size(263, 45);
            this.ScrollTrackbar.TabIndex = 4;
            this.ScrollTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ScrollTrackbar.Value = 1;
            this.ScrollTrackbar.Scroll += new System.EventHandler(this.ScrollTrackbar_Scroll);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(20, 295);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(113, 32);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh From Output";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Refresh2Button
            // 
            this.Refresh2Button.Location = new System.Drawing.Point(136, 295);
            this.Refresh2Button.Name = "Refresh2Button";
            this.Refresh2Button.Size = new System.Drawing.Size(113, 32);
            this.Refresh2Button.TabIndex = 6;
            this.Refresh2Button.Text = "Refresh From Input";
            this.Refresh2Button.UseVisualStyleBackColor = true;
            // 
            // TerminateButton
            // 
            this.TerminateButton.Location = new System.Drawing.Point(135, 391);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(84, 32);
            this.TerminateButton.TabIndex = 7;
            this.TerminateButton.Text = "Terminate";
            this.TerminateButton.UseVisualStyleBackColor = true;
            this.TerminateButton.Click += new System.EventHandler(this.TerminateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Waiting...";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(277, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TerminateButton);
            this.Controls.Add(this.Refresh2Button);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ScrollTrackbar);
            this.Controls.Add(this.GenerateRandomImages);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ViewerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "ImagePairer";
            ((System.ComponentModel.ISupportInitialize)(this.ViewerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ViewerPictureBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Button GenerateRandomImages;
        private System.Windows.Forms.TrackBar ScrollTrackbar;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button Refresh2Button;
        private System.Windows.Forms.Button TerminateButton;
        private System.Windows.Forms.Label label1;
    }
}

