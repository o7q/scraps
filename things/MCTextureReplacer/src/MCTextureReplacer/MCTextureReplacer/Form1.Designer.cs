namespace MCTextureReplacer
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
            this.PackLocationTextBox = new System.Windows.Forms.TextBox();
            this.ImageLocationTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.PackLocationButton = new System.Windows.Forms.Button();
            this.ImageLocationButton = new System.Windows.Forms.Button();
            this.ProgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PackLocationTextBox
            // 
            this.PackLocationTextBox.Location = new System.Drawing.Point(7, 15);
            this.PackLocationTextBox.Name = "PackLocationTextBox";
            this.PackLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.PackLocationTextBox.TabIndex = 0;
            // 
            // ImageLocationTextBox
            // 
            this.ImageLocationTextBox.Location = new System.Drawing.Point(8, 44);
            this.ImageLocationTextBox.Name = "ImageLocationTextBox";
            this.ImageLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImageLocationTextBox.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(16, 88);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "GO";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PackLocationButton
            // 
            this.PackLocationButton.Location = new System.Drawing.Point(111, 15);
            this.PackLocationButton.Name = "PackLocationButton";
            this.PackLocationButton.Size = new System.Drawing.Size(137, 23);
            this.PackLocationButton.TabIndex = 3;
            this.PackLocationButton.Text = "Select Pack Path";
            this.PackLocationButton.UseVisualStyleBackColor = true;
            this.PackLocationButton.Click += new System.EventHandler(this.PackLocationButton_Click);
            // 
            // ImageLocationButton
            // 
            this.ImageLocationButton.Location = new System.Drawing.Point(110, 44);
            this.ImageLocationButton.Name = "ImageLocationButton";
            this.ImageLocationButton.Size = new System.Drawing.Size(147, 23);
            this.ImageLocationButton.TabIndex = 4;
            this.ImageLocationButton.Text = "Select Image Path";
            this.ImageLocationButton.UseVisualStyleBackColor = true;
            this.ImageLocationButton.Click += new System.EventHandler(this.ImageLocationButton_Click);
            // 
            // ProgLabel
            // 
            this.ProgLabel.AutoSize = true;
            this.ProgLabel.Location = new System.Drawing.Point(47, 137);
            this.ProgLabel.Name = "ProgLabel";
            this.ProgLabel.Size = new System.Drawing.Size(49, 13);
            this.ProgLabel.TabIndex = 5;
            this.ProgLabel.Text = "waiting...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 373);
            this.Controls.Add(this.ProgLabel);
            this.Controls.Add(this.ImageLocationButton);
            this.Controls.Add(this.PackLocationButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ImageLocationTextBox);
            this.Controls.Add(this.PackLocationTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PackLocationTextBox;
        private System.Windows.Forms.TextBox ImageLocationTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PackLocationButton;
        private System.Windows.Forms.Button ImageLocationButton;
        private System.Windows.Forms.Label ProgLabel;
    }
}

