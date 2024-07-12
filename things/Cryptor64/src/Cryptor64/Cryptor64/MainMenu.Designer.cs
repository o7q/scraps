using System.Windows.Forms;

namespace Cryptor64
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
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.MainRichPassword = new RichPassword();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(8, 118);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(65, 33);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(76, 118);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(65, 33);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // MainRichPassword
            // 
            this.MainRichPassword.Location = new System.Drawing.Point(8, 8);
            this.MainRichPassword.Name = "MainRichPassword";
            this.MainRichPassword.Size = new System.Drawing.Size(213, 108);
            this.MainRichPassword.TabIndex = 3;
            this.MainRichPassword.Text = "";
            // 
            // CopyButton
            // 
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(144, 118);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(65, 33);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 161);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.MainRichPassword);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "Cryptor64";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private RichPassword MainRichPassword;
        private System.Windows.Forms.Button CopyButton;
    }
}

class RichPassword : RichTextBox
{
    protected override CreateParams CreateParams
    {
        get
        {
            // Turn on ES_PASSWORD
            var cp = base.CreateParams;
            cp.Style |= 0x20;
            return cp;
        }
    }
}