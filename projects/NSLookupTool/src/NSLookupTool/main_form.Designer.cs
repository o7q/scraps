
namespace NSLookupTool
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.lookup_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.lookup_box = new System.Windows.Forms.RichTextBox();
            this.lookup_write = new System.Windows.Forms.Button();
            this.info_box = new System.Windows.Forms.RichTextBox();
            this.info_write = new System.Windows.Forms.Button();
            this.lookup_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.lookup_read = new System.Windows.Forms.Button();
            this.info_read = new System.Windows.Forms.Button();
            this.lookup_reset = new System.Windows.Forms.Button();
            this.info_reset = new System.Windows.Forms.Button();
            this.skull_picture = new System.Windows.Forms.PictureBox();
            this.fire_picture = new System.Windows.Forms.PictureBox();
            this.netxposer_picture = new System.Windows.Forms.PictureBox();
            this.skulls_label = new System.Windows.Forms.Label();
            this.default_lookup = new System.Windows.Forms.Button();
            this.default_info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.skull_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netxposer_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lookup_button
            // 
            this.lookup_button.BackColor = System.Drawing.Color.Maroon;
            this.lookup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookup_button.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookup_button.ForeColor = System.Drawing.Color.Yellow;
            this.lookup_button.Location = new System.Drawing.Point(12, 211);
            this.lookup_button.Name = "lookup_button";
            this.lookup_button.Size = new System.Drawing.Size(93, 40);
            this.lookup_button.TabIndex = 0;
            this.lookup_button.Text = "Run Lookup Script";
            this.lookup_button.UseVisualStyleBackColor = false;
            this.lookup_button.Click += new System.EventHandler(this.lookup_button_Click);
            // 
            // info_button
            // 
            this.info_button.BackColor = System.Drawing.Color.Maroon;
            this.info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_button.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_button.ForeColor = System.Drawing.Color.Yellow;
            this.info_button.Location = new System.Drawing.Point(210, 211);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(93, 40);
            this.info_button.TabIndex = 1;
            this.info_button.Text = "Run Info Script";
            this.info_button.UseVisualStyleBackColor = false;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Maroon;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Red;
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(166, 25);
            this.name.TabIndex = 2;
            this.name.Text = "NSLookupTool";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.BackColor = System.Drawing.Color.Maroon;
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.credit.Location = new System.Drawing.Point(12, 34);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(49, 13);
            this.credit.TabIndex = 3;
            this.credit.Text = "by o7q.";
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // lookup_box
            // 
            this.lookup_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lookup_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lookup_box.Location = new System.Drawing.Point(12, 79);
            this.lookup_box.Name = "lookup_box";
            this.lookup_box.Size = new System.Drawing.Size(192, 101);
            this.lookup_box.TabIndex = 4;
            this.lookup_box.Text = "<lookupscript>";
            // 
            // lookup_write
            // 
            this.lookup_write.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lookup_write.Location = new System.Drawing.Point(75, 186);
            this.lookup_write.Name = "lookup_write";
            this.lookup_write.Size = new System.Drawing.Size(57, 19);
            this.lookup_write.TabIndex = 5;
            this.lookup_write.Text = "Write";
            this.lookup_write.UseVisualStyleBackColor = true;
            this.lookup_write.Click += new System.EventHandler(this.lookup_write_Click);
            // 
            // info_box
            // 
            this.info_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.info_box.Location = new System.Drawing.Point(210, 79);
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(192, 101);
            this.info_box.TabIndex = 6;
            this.info_box.Text = "<infoscript>";
            // 
            // info_write
            // 
            this.info_write.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.info_write.Location = new System.Drawing.Point(273, 186);
            this.info_write.Name = "info_write";
            this.info_write.Size = new System.Drawing.Size(57, 19);
            this.info_write.TabIndex = 7;
            this.info_write.Text = "Write";
            this.info_write.UseVisualStyleBackColor = true;
            this.info_write.Click += new System.EventHandler(this.info_write_Click);
            // 
            // lookup_label
            // 
            this.lookup_label.AutoSize = true;
            this.lookup_label.BackColor = System.Drawing.Color.Transparent;
            this.lookup_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lookup_label.Location = new System.Drawing.Point(16, 62);
            this.lookup_label.Name = "lookup_label";
            this.lookup_label.Size = new System.Drawing.Size(43, 13);
            this.lookup_label.TabIndex = 8;
            this.lookup_label.Text = "Lookup";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.BackColor = System.Drawing.Color.Transparent;
            this.info_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.info_label.Location = new System.Drawing.Point(207, 62);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(25, 13);
            this.info_label.TabIndex = 9;
            this.info_label.Text = "Info";
            // 
            // lookup_read
            // 
            this.lookup_read.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lookup_read.Location = new System.Drawing.Point(12, 186);
            this.lookup_read.Name = "lookup_read";
            this.lookup_read.Size = new System.Drawing.Size(57, 19);
            this.lookup_read.TabIndex = 10;
            this.lookup_read.Text = "Read";
            this.lookup_read.UseVisualStyleBackColor = true;
            this.lookup_read.Click += new System.EventHandler(this.lookup_read_Click);
            // 
            // info_read
            // 
            this.info_read.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info_read.Location = new System.Drawing.Point(210, 186);
            this.info_read.Name = "info_read";
            this.info_read.Size = new System.Drawing.Size(57, 19);
            this.info_read.TabIndex = 11;
            this.info_read.Text = "Read";
            this.info_read.UseVisualStyleBackColor = true;
            this.info_read.Click += new System.EventHandler(this.info_read_Click);
            // 
            // lookup_reset
            // 
            this.lookup_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lookup_reset.Location = new System.Drawing.Point(138, 186);
            this.lookup_reset.Name = "lookup_reset";
            this.lookup_reset.Size = new System.Drawing.Size(57, 19);
            this.lookup_reset.TabIndex = 12;
            this.lookup_reset.Text = "Reset";
            this.lookup_reset.UseVisualStyleBackColor = true;
            this.lookup_reset.Click += new System.EventHandler(this.lookup_reset_Click);
            // 
            // info_reset
            // 
            this.info_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.info_reset.Location = new System.Drawing.Point(336, 186);
            this.info_reset.Name = "info_reset";
            this.info_reset.Size = new System.Drawing.Size(57, 19);
            this.info_reset.TabIndex = 13;
            this.info_reset.Text = "Reset";
            this.info_reset.UseVisualStyleBackColor = true;
            this.info_reset.Click += new System.EventHandler(this.info_reset_Click);
            // 
            // skull_picture
            // 
            this.skull_picture.BackColor = System.Drawing.Color.Black;
            this.skull_picture.Image = ((System.Drawing.Image)(resources.GetObject("skull_picture.Image")));
            this.skull_picture.Location = new System.Drawing.Point(379, 9);
            this.skull_picture.Name = "skull_picture";
            this.skull_picture.Size = new System.Drawing.Size(34, 38);
            this.skull_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.skull_picture.TabIndex = 15;
            this.skull_picture.TabStop = false;
            this.skull_picture.Click += new System.EventHandler(this.skull_picture_Click);
            // 
            // fire_picture
            // 
            this.fire_picture.Image = ((System.Drawing.Image)(resources.GetObject("fire_picture.Image")));
            this.fire_picture.Location = new System.Drawing.Point(-6, -3);
            this.fire_picture.Name = "fire_picture";
            this.fire_picture.Size = new System.Drawing.Size(201, 76);
            this.fire_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire_picture.TabIndex = 16;
            this.fire_picture.TabStop = false;
            // 
            // netxposer_picture
            // 
            this.netxposer_picture.Image = global::NSLookupTool.Properties.Resources.netxposer;
            this.netxposer_picture.Location = new System.Drawing.Point(192, -3);
            this.netxposer_picture.Name = "netxposer_picture";
            this.netxposer_picture.Size = new System.Drawing.Size(201, 62);
            this.netxposer_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.netxposer_picture.TabIndex = 17;
            this.netxposer_picture.TabStop = false;
            // 
            // skulls_label
            // 
            this.skulls_label.AutoSize = true;
            this.skulls_label.ForeColor = System.Drawing.Color.Red;
            this.skulls_label.Location = new System.Drawing.Point(2, 254);
            this.skulls_label.Name = "skulls_label";
            this.skulls_label.Size = new System.Drawing.Size(448, 13);
            this.skulls_label.TabIndex = 18;
            this.skulls_label.Text = "☠️☠️☠️         ☠️☠️☠️         ☠️☠️☠️         ☠️☠️☠️         ☠️☠️☠️         ☠️☠️☠️" +
    "         ☠️☠️☠️         \r\n";
            // 
            // default_lookup
            // 
            this.default_lookup.BackColor = System.Drawing.Color.Yellow;
            this.default_lookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.default_lookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.default_lookup.ForeColor = System.Drawing.Color.Red;
            this.default_lookup.Location = new System.Drawing.Point(112, 212);
            this.default_lookup.Name = "default_lookup";
            this.default_lookup.Size = new System.Drawing.Size(83, 39);
            this.default_lookup.TabIndex = 19;
            this.default_lookup.Text = "Default Settings";
            this.default_lookup.UseVisualStyleBackColor = false;
            this.default_lookup.Click += new System.EventHandler(this.default_lookup_Click);
            // 
            // default_info
            // 
            this.default_info.BackColor = System.Drawing.Color.Yellow;
            this.default_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.default_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.default_info.ForeColor = System.Drawing.Color.Red;
            this.default_info.Location = new System.Drawing.Point(310, 212);
            this.default_info.Name = "default_info";
            this.default_info.Size = new System.Drawing.Size(83, 39);
            this.default_info.TabIndex = 20;
            this.default_info.Text = "Default Settings";
            this.default_info.UseVisualStyleBackColor = false;
            this.default_info.Click += new System.EventHandler(this.default_info_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(413, 266);
            this.Controls.Add(this.default_info);
            this.Controls.Add(this.default_lookup);
            this.Controls.Add(this.skulls_label);
            this.Controls.Add(this.skull_picture);
            this.Controls.Add(this.info_reset);
            this.Controls.Add(this.lookup_reset);
            this.Controls.Add(this.info_read);
            this.Controls.Add(this.lookup_read);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.lookup_label);
            this.Controls.Add(this.info_write);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.lookup_write);
            this.Controls.Add(this.lookup_box);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.name);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.lookup_button);
            this.Controls.Add(this.fire_picture);
            this.Controls.Add(this.netxposer_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = "NSLookupTool";
            ((System.ComponentModel.ISupportInitialize)(this.skull_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netxposer_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lookup_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.RichTextBox lookup_box;
        private System.Windows.Forms.Button lookup_write;
        private System.Windows.Forms.RichTextBox info_box;
        private System.Windows.Forms.Button info_write;
        private System.Windows.Forms.Label lookup_label;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Button lookup_read;
        private System.Windows.Forms.Button info_read;
        private System.Windows.Forms.Button lookup_reset;
        private System.Windows.Forms.Button info_reset;
        private System.Windows.Forms.PictureBox skull_picture;
        private System.Windows.Forms.PictureBox fire_picture;
        private System.Windows.Forms.PictureBox netxposer_picture;
        private System.Windows.Forms.Label skulls_label;
        private System.Windows.Forms.Button default_lookup;
        private System.Windows.Forms.Button default_info;
    }
}