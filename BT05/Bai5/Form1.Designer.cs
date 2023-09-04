
namespace Bai5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdTimeNewRoman = new System.Windows.Forms.RadioButton();
            this.rdArial = new System.Windows.Forms.RadioButton();
            this.rdTahoma = new System.Windows.Forms.RadioButton();
            this.rdCounrierNew = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(31)))), ((int)(((byte)(132)))));
            this.textBox1.Location = new System.Drawing.Point(49, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(111, 132);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "what is font ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập văn bản";
            // 
            // rdTimeNewRoman
            // 
            this.rdTimeNewRoman.AutoSize = true;
            this.rdTimeNewRoman.Location = new System.Drawing.Point(210, 41);
            this.rdTimeNewRoman.Name = "rdTimeNewRoman";
            this.rdTimeNewRoman.Size = new System.Drawing.Size(110, 17);
            this.rdTimeNewRoman.TabIndex = 2;
            this.rdTimeNewRoman.TabStop = true;
            this.rdTimeNewRoman.Text = "Time New Roman";
            this.rdTimeNewRoman.UseVisualStyleBackColor = true;
            this.rdTimeNewRoman.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdArial
            // 
            this.rdArial.AutoSize = true;
            this.rdArial.Location = new System.Drawing.Point(210, 75);
            this.rdArial.Name = "rdArial";
            this.rdArial.Size = new System.Drawing.Size(45, 17);
            this.rdArial.TabIndex = 3;
            this.rdArial.TabStop = true;
            this.rdArial.Text = "Arial";
            this.rdArial.UseVisualStyleBackColor = true;
            this.rdArial.CheckedChanged += new System.EventHandler(this.rdArial_CheckedChanged);
            // 
            // rdTahoma
            // 
            this.rdTahoma.AutoSize = true;
            this.rdTahoma.Location = new System.Drawing.Point(210, 109);
            this.rdTahoma.Name = "rdTahoma";
            this.rdTahoma.Size = new System.Drawing.Size(64, 17);
            this.rdTahoma.TabIndex = 4;
            this.rdTahoma.TabStop = true;
            this.rdTahoma.Text = "Tahoma";
            this.rdTahoma.UseVisualStyleBackColor = true;
            this.rdTahoma.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdCounrierNew
            // 
            this.rdCounrierNew.AutoSize = true;
            this.rdCounrierNew.Location = new System.Drawing.Point(210, 147);
            this.rdCounrierNew.Name = "rdCounrierNew";
            this.rdCounrierNew.Size = new System.Drawing.Size(89, 17);
            this.rdCounrierNew.TabIndex = 5;
            this.rdCounrierNew.TabStop = true;
            this.rdCounrierNew.Text = "Counrier New";
            this.rdCounrierNew.UseVisualStyleBackColor = true;
            this.rdCounrierNew.CheckedChanged += new System.EventHandler(this.rdCounrierNew_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 243);
            this.Controls.Add(this.rdCounrierNew);
            this.Controls.Add(this.rdTahoma);
            this.Controls.Add(this.rdArial);
            this.Controls.Add(this.rdTimeNewRoman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "frmFont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdTimeNewRoman;
        private System.Windows.Forms.RadioButton rdArial;
        private System.Windows.Forms.RadioButton rdTahoma;
        private System.Windows.Forms.RadioButton rdCounrierNew;
    }
}

