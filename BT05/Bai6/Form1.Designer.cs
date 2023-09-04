
namespace Bai6
{
    partial class frmQuocGia
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdVietNam = new System.Windows.Forms.RadioButton();
            this.rdUSA = new System.Windows.Forms.RadioButton();
            this.rdItalian = new System.Windows.Forms.RadioButton();
            this.rdPhilipinene = new System.Windows.Forms.RadioButton();
            this.pnlUSA = new System.Windows.Forms.Panel();
            this.pnlPhilip = new System.Windows.Forms.Panel();
            this.pnlItalic = new System.Windows.Forms.Panel();
            this.pnlVN = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPhilipinene);
            this.groupBox1.Controls.Add(this.rdItalian);
            this.groupBox1.Controls.Add(this.rdUSA);
            this.groupBox1.Controls.Add(this.rdVietNam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // rdVietNam
            // 
            this.rdVietNam.AutoSize = true;
            this.rdVietNam.Location = new System.Drawing.Point(7, 26);
            this.rdVietNam.Name = "rdVietNam";
            this.rdVietNam.Size = new System.Drawing.Size(88, 24);
            this.rdVietNam.TabIndex = 0;
            this.rdVietNam.TabStop = true;
            this.rdVietNam.Text = "VietNam";
            this.rdVietNam.UseVisualStyleBackColor = true;
            this.rdVietNam.CheckedChanged += new System.EventHandler(this.rdVietNam_CheckedChanged);
            // 
            // rdUSA
            // 
            this.rdUSA.AutoSize = true;
            this.rdUSA.Location = new System.Drawing.Point(7, 69);
            this.rdUSA.Name = "rdUSA";
            this.rdUSA.Size = new System.Drawing.Size(61, 24);
            this.rdUSA.TabIndex = 1;
            this.rdUSA.TabStop = true;
            this.rdUSA.Text = "USA";
            this.rdUSA.UseVisualStyleBackColor = true;
            this.rdUSA.CheckedChanged += new System.EventHandler(this.rdUSA_CheckedChanged);
            // 
            // rdItalian
            // 
            this.rdItalian.AutoSize = true;
            this.rdItalian.Location = new System.Drawing.Point(7, 111);
            this.rdItalian.Name = "rdItalian";
            this.rdItalian.Size = new System.Drawing.Size(70, 24);
            this.rdItalian.TabIndex = 2;
            this.rdItalian.TabStop = true;
            this.rdItalian.Text = "Italian";
            this.rdItalian.UseVisualStyleBackColor = true;
            this.rdItalian.CheckedChanged += new System.EventHandler(this.rdItalian_CheckedChanged);
            // 
            // rdPhilipinene
            // 
            this.rdPhilipinene.AutoSize = true;
            this.rdPhilipinene.Location = new System.Drawing.Point(7, 150);
            this.rdPhilipinene.Name = "rdPhilipinene";
            this.rdPhilipinene.Size = new System.Drawing.Size(103, 24);
            this.rdPhilipinene.TabIndex = 3;
            this.rdPhilipinene.TabStop = true;
            this.rdPhilipinene.Text = "Philipinene";
            this.rdPhilipinene.UseVisualStyleBackColor = true;
            this.rdPhilipinene.CheckedChanged += new System.EventHandler(this.rdPhilipinene_CheckedChanged);
            // 
            // pnlUSA
            // 
            this.pnlUSA.BackgroundImage = global::Bai6.Properties.Resources._285px_Flag_of_the_United_States__Pantone__svg;
            this.pnlUSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUSA.Location = new System.Drawing.Point(272, 136);
            this.pnlUSA.Name = "pnlUSA";
            this.pnlUSA.Size = new System.Drawing.Size(317, 189);
            this.pnlUSA.TabIndex = 3;
            // 
            // pnlPhilip
            // 
            this.pnlPhilip.BackgroundImage = global::Bai6.Properties.Resources.tải_xuống__1_;
            this.pnlPhilip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPhilip.Location = new System.Drawing.Point(269, 136);
            this.pnlPhilip.Name = "pnlPhilip";
            this.pnlPhilip.Size = new System.Drawing.Size(320, 189);
            this.pnlPhilip.TabIndex = 4;
            // 
            // pnlItalic
            // 
            this.pnlItalic.BackgroundImage = global::Bai6.Properties.Resources.tải_xuống;
            this.pnlItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlItalic.Location = new System.Drawing.Point(272, 136);
            this.pnlItalic.Name = "pnlItalic";
            this.pnlItalic.Size = new System.Drawing.Size(317, 189);
            this.pnlItalic.TabIndex = 4;
            // 
            // pnlVN
            // 
            this.pnlVN.BackgroundImage = global::Bai6.Properties.Resources.vietnam;
            this.pnlVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVN.Location = new System.Drawing.Point(272, 136);
            this.pnlVN.Name = "pnlVN";
            this.pnlVN.Size = new System.Drawing.Size(317, 189);
            this.pnlVN.TabIndex = 2;
            // 
            // frmQuocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 430);
            this.Controls.Add(this.pnlPhilip);
            this.Controls.Add(this.pnlItalic);
            this.Controls.Add(this.pnlUSA);
            this.Controls.Add(this.pnlVN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmQuocGia";
            this.Text = "frmQuocGia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPhilipinene;
        private System.Windows.Forms.RadioButton rdItalian;
        private System.Windows.Forms.RadioButton rdUSA;
        private System.Windows.Forms.RadioButton rdVietNam;
        private System.Windows.Forms.Panel pnlUSA;
        private System.Windows.Forms.Panel pnlPhilip;
        private System.Windows.Forms.Panel pnlItalic;
        private System.Windows.Forms.Panel pnlVN;
    }
}

