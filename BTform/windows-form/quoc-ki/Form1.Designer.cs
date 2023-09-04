namespace quoc_ki
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPhilippines = new System.Windows.Forms.RadioButton();
            this.radVietnam = new System.Windows.Forms.RadioButton();
            this.radItaly = new System.Windows.Forms.RadioButton();
            this.radUSA = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radPhilippines);
            this.groupBox1.Controls.Add(this.radVietnam);
            this.groupBox1.Controls.Add(this.radItaly);
            this.groupBox1.Controls.Add(this.radUSA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quốc gia";
            // 
            // radPhilippines
            // 
            this.radPhilippines.AutoSize = true;
            this.radPhilippines.Location = new System.Drawing.Point(41, 164);
            this.radPhilippines.Name = "radPhilippines";
            this.radPhilippines.Size = new System.Drawing.Size(118, 26);
            this.radPhilippines.TabIndex = 3;
            this.radPhilippines.TabStop = true;
            this.radPhilippines.Text = "Philippines";
            this.radPhilippines.UseVisualStyleBackColor = true;
            this.radPhilippines.CheckedChanged += new System.EventHandler(this.radPhilippines_CheckedChanged);
            // 
            // radVietnam
            // 
            this.radVietnam.AutoSize = true;
            this.radVietnam.Location = new System.Drawing.Point(41, 27);
            this.radVietnam.Name = "radVietnam";
            this.radVietnam.Size = new System.Drawing.Size(96, 26);
            this.radVietnam.TabIndex = 0;
            this.radVietnam.TabStop = true;
            this.radVietnam.Text = "Vietnam";
            this.radVietnam.UseVisualStyleBackColor = true;
            this.radVietnam.CheckedChanged += new System.EventHandler(this.radVietnam_CheckedChanged);
            // 
            // radItaly
            // 
            this.radItaly.AutoSize = true;
            this.radItaly.Location = new System.Drawing.Point(41, 118);
            this.radItaly.Name = "radItaly";
            this.radItaly.Size = new System.Drawing.Size(63, 26);
            this.radItaly.TabIndex = 2;
            this.radItaly.TabStop = true;
            this.radItaly.Text = "Italy";
            this.radItaly.UseVisualStyleBackColor = true;
            this.radItaly.CheckedChanged += new System.EventHandler(this.radItalia_CheckedChanged);
            // 
            // radUSA
            // 
            this.radUSA.AutoSize = true;
            this.radUSA.Location = new System.Drawing.Point(41, 72);
            this.radUSA.Name = "radUSA";
            this.radUSA.Size = new System.Drawing.Size(68, 26);
            this.radUSA.TabIndex = 1;
            this.radUSA.TabStop = true;
            this.radUSA.Text = "USA";
            this.radUSA.UseVisualStyleBackColor = true;
            this.radUSA.CheckedChanged += new System.EventHandler(this.radUSA_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(353, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quốc kì";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPhilippines;
        private System.Windows.Forms.RadioButton radItaly;
        private System.Windows.Forms.RadioButton radUSA;
        private System.Windows.Forms.RadioButton radVietnam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

