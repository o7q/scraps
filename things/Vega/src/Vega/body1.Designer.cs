namespace vega_launcher
{
    partial class body1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(body1));
            this.titlebar1 = new System.Windows.Forms.Panel();
            this.vega_credit1 = new System.Windows.Forms.Label();
            this.close1 = new System.Windows.Forms.Button();
            this.vega_text1 = new System.Windows.Forms.Label();
            this.vega_icon1 = new System.Windows.Forms.PictureBox();
            this.launch1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list1 = new System.Windows.Forms.ComboBox();
            this.status1 = new System.Windows.Forms.Label();
            this.uninstall1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.titlebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vega_icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar1
            // 
            this.titlebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.titlebar1.Controls.Add(this.vega_credit1);
            this.titlebar1.Controls.Add(this.close1);
            this.titlebar1.Controls.Add(this.vega_text1);
            this.titlebar1.Controls.Add(this.vega_icon1);
            this.titlebar1.Location = new System.Drawing.Point(-4, -3);
            this.titlebar1.Name = "titlebar1";
            this.titlebar1.Size = new System.Drawing.Size(720, 72);
            this.titlebar1.TabIndex = 0;
            this.titlebar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlebar1_MouseMove);
            // 
            // vega_credit1
            // 
            this.vega_credit1.AutoSize = true;
            this.vega_credit1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vega_credit1.ForeColor = System.Drawing.Color.White;
            this.vega_credit1.Location = new System.Drawing.Point(125, 49);
            this.vega_credit1.Name = "vega_credit1";
            this.vega_credit1.Size = new System.Drawing.Size(51, 16);
            this.vega_credit1.TabIndex = 3;
            this.vega_credit1.Text = "by o7q.";
            this.vega_credit1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vega_credit1_MouseMove);
            // 
            // close1
            // 
            this.close1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close1.ForeColor = System.Drawing.SystemColors.Control;
            this.close1.Location = new System.Drawing.Point(658, 11);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(50, 50);
            this.close1.TabIndex = 2;
            this.close1.Text = "✖";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // vega_text1
            // 
            this.vega_text1.AutoSize = true;
            this.vega_text1.Font = new System.Drawing.Font("Futura Bk BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vega_text1.ForeColor = System.Drawing.Color.White;
            this.vega_text1.Location = new System.Drawing.Point(62, 18);
            this.vega_text1.Name = "vega_text1";
            this.vega_text1.Size = new System.Drawing.Size(88, 39);
            this.vega_text1.TabIndex = 1;
            this.vega_text1.Text = "Vega";
            this.vega_text1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vega_text1_MouseMove);
            // 
            // vega_icon1
            // 
            this.vega_icon1.Image = global::VegaClient.Properties.Resources.icon_white;
            this.vega_icon1.Location = new System.Drawing.Point(3, 3);
            this.vega_icon1.Name = "vega_icon1";
            this.vega_icon1.Size = new System.Drawing.Size(73, 69);
            this.vega_icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vega_icon1.TabIndex = 0;
            this.vega_icon1.TabStop = false;
            this.vega_icon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vega_icon1_MouseMove);
            // 
            // launch1
            // 
            this.launch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.launch1.Image = global::VegaClient.Properties.Resources.background;
            this.launch1.Location = new System.Drawing.Point(382, 172);
            this.launch1.Name = "launch1";
            this.launch1.Size = new System.Drawing.Size(89, 29);
            this.launch1.TabIndex = 2;
            this.launch1.Text = "INSTALL";
            this.launch1.UseVisualStyleBackColor = true;
            this.launch1.Click += new System.EventHandler(this.launch1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VegaClient.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(247, 177);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(129, 21);
            this.list1.TabIndex = 3;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.list1_SelectedIndexChanged);
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.BackColor = System.Drawing.Color.Black;
            this.status1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1.ForeColor = System.Drawing.Color.Lime;
            this.status1.Location = new System.Drawing.Point(243, 295);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(256, 20);
            this.status1.TabIndex = 4;
            this.status1.Text = "No operations are currently running";
            this.status1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uninstall1
            // 
            this.uninstall1.BackColor = System.Drawing.Color.Red;
            this.uninstall1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstall1.ForeColor = System.Drawing.Color.Red;
            this.uninstall1.Image = global::VegaClient.Properties.Resources.background;
            this.uninstall1.Location = new System.Drawing.Point(317, 396);
            this.uninstall1.Name = "uninstall1";
            this.uninstall1.Size = new System.Drawing.Size(88, 29);
            this.uninstall1.TabIndex = 5;
            this.uninstall1.Text = "UNINSTALL";
            this.uninstall1.UseVisualStyleBackColor = false;
            this.uninstall1.Click += new System.EventHandler(this.uninstall1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Image = global::VegaClient.Properties.Resources.background;
            this.button1.Location = new System.Drawing.Point(247, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 88);
            this.button1.TabIndex = 6;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // body1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(712, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uninstall1);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.launch1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlebar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "body1";
            this.Text = "Vega";
            this.Load += new System.EventHandler(this.body1_Load);
            this.titlebar1.ResumeLayout(false);
            this.titlebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vega_icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlebar1;
        private System.Windows.Forms.PictureBox vega_icon1;
        private System.Windows.Forms.Label vega_text1;
        private System.Windows.Forms.Button close1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label vega_credit1;
        private System.Windows.Forms.Button launch1;
        private System.Windows.Forms.ComboBox list1;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Button uninstall1;
        private System.Windows.Forms.Button button1;
    }
}

