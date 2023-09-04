namespace font
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.radArial = new System.Windows.Forms.RadioButton();
            this.radTahoma = new System.Windows.Forms.RadioButton();
            this.radCourierNew = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 234);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radTimesNewRoman
            // 
            this.radTimesNewRoman.AutoSize = true;
            this.radTimesNewRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimesNewRoman.Location = new System.Drawing.Point(302, 60);
            this.radTimesNewRoman.Name = "radTimesNewRoman";
            this.radTimesNewRoman.Size = new System.Drawing.Size(183, 26);
            this.radTimesNewRoman.TabIndex = 2;
            this.radTimesNewRoman.TabStop = true;
            this.radTimesNewRoman.Text = "Times New Roman";
            this.radTimesNewRoman.UseVisualStyleBackColor = true;
            this.radTimesNewRoman.CheckedChanged += new System.EventHandler(this.radTimesNewRoman_CheckedChanged);
            // 
            // radArial
            // 
            this.radArial.AutoSize = true;
            this.radArial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radArial.Location = new System.Drawing.Point(302, 92);
            this.radArial.Name = "radArial";
            this.radArial.Size = new System.Drawing.Size(67, 26);
            this.radArial.TabIndex = 3;
            this.radArial.TabStop = true;
            this.radArial.Text = "Arial";
            this.radArial.UseVisualStyleBackColor = true;
            this.radArial.CheckedChanged += new System.EventHandler(this.radArial_CheckedChanged);
            // 
            // radTahoma
            // 
            this.radTahoma.AutoSize = true;
            this.radTahoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTahoma.Location = new System.Drawing.Point(302, 124);
            this.radTahoma.Name = "radTahoma";
            this.radTahoma.Size = new System.Drawing.Size(97, 26);
            this.radTahoma.TabIndex = 4;
            this.radTahoma.TabStop = true;
            this.radTahoma.Text = "Tahoma";
            this.radTahoma.UseVisualStyleBackColor = true;
            this.radTahoma.CheckedChanged += new System.EventHandler(this.radTahoma_CheckedChanged);
            // 
            // radCourierNew
            // 
            this.radCourierNew.AutoSize = true;
            this.radCourierNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCourierNew.Location = new System.Drawing.Point(302, 156);
            this.radCourierNew.Name = "radCourierNew";
            this.radCourierNew.Size = new System.Drawing.Size(131, 26);
            this.radCourierNew.TabIndex = 5;
            this.radCourierNew.TabStop = true;
            this.radCourierNew.Text = "Courier New";
            this.radCourierNew.UseVisualStyleBackColor = true;
            this.radCourierNew.CheckedChanged += new System.EventHandler(this.radCourierNew_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(181, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radCourierNew);
            this.Controls.Add(this.radTahoma);
            this.Controls.Add(this.radArial);
            this.Controls.Add(this.radTimesNewRoman);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radTimesNewRoman;
        private System.Windows.Forms.RadioButton radArial;
        private System.Windows.Forms.RadioButton radTahoma;
        private System.Windows.Forms.RadioButton radCourierNew;
        private System.Windows.Forms.Button button1;
    }
}

