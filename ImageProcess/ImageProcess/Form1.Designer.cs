namespace ImageProcess
{
    partial class bieudo
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
            this.Anhxam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NhiPhan = new System.Windows.Forms.Button();
            this.Amban = new System.Windows.Forms.Button();
            this.Locnhieu = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.Button();
            this.Dobien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Luu = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Htg = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Anhxam
            // 
            this.Anhxam.Location = new System.Drawing.Point(12, 28);
            this.Anhxam.Name = "Anhxam";
            this.Anhxam.Size = new System.Drawing.Size(75, 23);
            this.Anhxam.TabIndex = 0;
            this.Anhxam.Text = "Ảnh Xám";
            this.Anhxam.UseVisualStyleBackColor = true;
            this.Anhxam.Click += new System.EventHandler(this.Anhxam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(71, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 250);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(491, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 250);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // NhiPhan
            // 
            this.NhiPhan.Location = new System.Drawing.Point(117, 28);
            this.NhiPhan.Name = "NhiPhan";
            this.NhiPhan.Size = new System.Drawing.Size(75, 23);
            this.NhiPhan.TabIndex = 5;
            this.NhiPhan.Text = "Nhị Phân";
            this.NhiPhan.UseVisualStyleBackColor = true;
            this.NhiPhan.Click += new System.EventHandler(this.NhiPhan_Click);
            // 
            // Amban
            // 
            this.Amban.Location = new System.Drawing.Point(238, 28);
            this.Amban.Name = "Amban";
            this.Amban.Size = new System.Drawing.Size(75, 23);
            this.Amban.TabIndex = 6;
            this.Amban.Text = "Âm Bản";
            this.Amban.UseVisualStyleBackColor = true;
            this.Amban.Click += new System.EventHandler(this.Amban_Click);
            // 
            // Locnhieu
            // 
            this.Locnhieu.Location = new System.Drawing.Point(345, 28);
            this.Locnhieu.Name = "Locnhieu";
            this.Locnhieu.Size = new System.Drawing.Size(75, 23);
            this.Locnhieu.TabIndex = 7;
            this.Locnhieu.Text = "Lọc Nhiễu";
            this.Locnhieu.UseVisualStyleBackColor = true;
            this.Locnhieu.Click += new System.EventHandler(this.Locnhieu_Click);
            // 
            // histogram
            // 
            this.histogram.Location = new System.Drawing.Point(449, 28);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(112, 23);
            this.histogram.TabIndex = 8;
            this.histogram.Text = "Cân bằng Histogram";
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // Dobien
            // 
            this.Dobien.Location = new System.Drawing.Point(585, 28);
            this.Dobien.Name = "Dobien";
            this.Dobien.Size = new System.Drawing.Size(75, 23);
            this.Dobien.TabIndex = 9;
            this.Dobien.Text = "Dò Biên";
            this.Dobien.UseVisualStyleBackColor = true;
            this.Dobien.Click += new System.EventHandler(this.Dobien_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output";
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(788, 28);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(75, 23);
            this.Luu.TabIndex = 12;
            this.Luu.Text = "Lưu Ảnh";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(238, 342);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(422, 82);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Htg
            // 
            this.Htg.Location = new System.Drawing.Point(146, 392);
            this.Htg.Name = "Htg";
            this.Htg.Size = new System.Drawing.Size(75, 23);
            this.Htg.TabIndex = 14;
            this.Htg.Text = "Histogram";
            this.Htg.UseVisualStyleBackColor = true;
            this.Htg.Click += new System.EventHandler(this.Htg_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(687, 28);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 15;
            this.log.Text = "Logarit";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // bieudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Htg);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dobien);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.Locnhieu);
            this.Controls.Add(this.Amban);
            this.Controls.Add(this.NhiPhan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Anhxam);
            this.Name = "bieudo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anhxam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button NhiPhan;
        private System.Windows.Forms.Button Amban;
        private System.Windows.Forms.Button Locnhieu;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button Dobien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Htg;
        private System.Windows.Forms.Button log;
    }
}

