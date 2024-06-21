namespace HoloFishBot
{
    partial class Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.BoundsPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectBoundsButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.ConfigLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoundsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BoundsPictureBox
            // 
            this.BoundsPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BoundsPictureBox.Location = new System.Drawing.Point(3, 3);
            this.BoundsPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoundsPictureBox.Name = "BoundsPictureBox";
            this.BoundsPictureBox.Size = new System.Drawing.Size(130, 130);
            this.BoundsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoundsPictureBox.TabIndex = 0;
            this.BoundsPictureBox.TabStop = false;
            // 
            // SelectBoundsButton
            // 
            this.SelectBoundsButton.Location = new System.Drawing.Point(2, 165);
            this.SelectBoundsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectBoundsButton.Name = "SelectBoundsButton";
            this.SelectBoundsButton.Size = new System.Drawing.Size(132, 22);
            this.SelectBoundsButton.TabIndex = 2;
            this.SelectBoundsButton.Text = "Select Bounds";
            this.SelectBoundsButton.UseVisualStyleBackColor = true;
            this.SelectBoundsButton.Click += new System.EventHandler(this.SelectBoundsButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(2, 135);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(65, 28);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StopButton.Location = new System.Drawing.Point(69, 135);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(65, 28);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.BackColor = System.Drawing.Color.Black;
            this.DebugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugLabel.ForeColor = System.Drawing.Color.Lime;
            this.DebugLabel.Location = new System.Drawing.Point(3, 109);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(10, 24);
            this.DebugLabel.TabIndex = 0;
            this.DebugLabel.Text = "_\r\n_";
            // 
            // ConfigLabel
            // 
            this.ConfigLabel.AutoSize = true;
            this.ConfigLabel.BackColor = System.Drawing.Color.Black;
            this.ConfigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigLabel.ForeColor = System.Drawing.Color.Lime;
            this.ConfigLabel.Location = new System.Drawing.Point(3, 3);
            this.ConfigLabel.Name = "ConfigLabel";
            this.ConfigLabel.Size = new System.Drawing.Size(10, 12);
            this.ConfigLabel.TabIndex = 3;
            this.ConfigLabel.Text = "_";
            // 
            // Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 189);
            this.Controls.Add(this.ConfigLabel);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SelectBoundsButton);
            this.Controls.Add(this.BoundsPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Program";
            this.Text = "HoloFishBot by o7q";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Program_FormClosing);
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoundsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoundsPictureBox;
        private System.Windows.Forms.Button SelectBoundsButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Label ConfigLabel;
    }
}

