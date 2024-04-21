namespace DynamicFirewall
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
            this.BlockButton = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.RichTextBox();
            this.AutoCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(232, 18);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(82, 23);
            this.BlockButton.TabIndex = 1;
            this.BlockButton.Text = "Update";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(8, 19);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(222, 96);
            this.AddressTextBox.TabIndex = 2;
            this.AddressTextBox.Text = "";
            // 
            // AutoCheckBox
            // 
            this.AutoCheckBox.AutoSize = true;
            this.AutoCheckBox.Checked = true;
            this.AutoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoCheckBox.Location = new System.Drawing.Point(233, 42);
            this.AutoCheckBox.Name = "AutoCheckBox";
            this.AutoCheckBox.Size = new System.Drawing.Size(86, 17);
            this.AutoCheckBox.TabIndex = 3;
            this.AutoCheckBox.Text = "Auto Update";
            this.AutoCheckBox.UseVisualStyleBackColor = true;
            this.AutoCheckBox.CheckedChanged += new System.EventHandler(this.AutoCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Addresses";
            // 
            // HideButton
            // 
            this.HideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideButton.Location = new System.Drawing.Point(290, 104);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(32, 21);
            this.HideButton.TabIndex = 5;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 126);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoCheckBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.BlockButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "DynamicFirewall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.RichTextBox AddressTextBox;
        private System.Windows.Forms.CheckBox AutoCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HideButton;
    }
}

