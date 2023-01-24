namespace ServerHelper1152_def
{
    partial class toolbox1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toolbox1));
            this.server1 = new System.Windows.Forms.Button();
            this.ngrok1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server1
            // 
            this.server1.BackColor = System.Drawing.Color.Silver;
            this.server1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.server1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server1.Location = new System.Drawing.Point(12, 46);
            this.server1.Name = "server1";
            this.server1.Size = new System.Drawing.Size(135, 116);
            this.server1.TabIndex = 0;
            this.server1.Text = "Start\r\nServer\r\n";
            this.server1.UseVisualStyleBackColor = false;
            this.server1.Click += new System.EventHandler(this.server1_Click);
            // 
            // ngrok1
            // 
            this.ngrok1.BackColor = System.Drawing.Color.Silver;
            this.ngrok1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ngrok1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngrok1.Location = new System.Drawing.Point(167, 46);
            this.ngrok1.Name = "ngrok1";
            this.ngrok1.Size = new System.Drawing.Size(135, 116);
            this.ngrok1.TabIndex = 1;
            this.ngrok1.Text = "Start\r\nPort Foward\r\n";
            this.ngrok1.UseVisualStyleBackColor = false;
            this.ngrok1.Click += new System.EventHandler(this.ngrok1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ServerHelper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "by o7q";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse versions";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolbox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(314, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngrok1);
            this.Controls.Add(this.server1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "toolbox1";
            this.Text = "ServerHelper by o7q";
            this.Load += new System.EventHandler(this.toolbox1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button server1;
        private System.Windows.Forms.Button ngrok1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

