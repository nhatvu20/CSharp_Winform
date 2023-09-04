namespace may_tinh
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
            this.components = new System.ComponentModel.Container();
            this.so1 = new System.Windows.Forms.Label();
            this.so2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chia = new System.Windows.Forms.RadioButton();
            this.nhan = new System.Windows.Forms.RadioButton();
            this.tru = new System.Windows.Forms.RadioButton();
            this.cong = new System.Windows.Forms.RadioButton();
            this.ketQua = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // so1
            // 
            this.so1.AutoSize = true;
            this.so1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so1.Location = new System.Drawing.Point(105, 32);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(47, 22);
            this.so1.TabIndex = 0;
            this.so1.Text = "Số 1";
            // 
            // so2
            // 
            this.so2.AutoSize = true;
            this.so2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so2.Location = new System.Drawing.Point(105, 75);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(47, 22);
            this.so2.TabIndex = 1;
            this.so2.Text = "Số 2";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(158, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 28);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chia);
            this.groupBox1.Controls.Add(this.nhan);
            this.groupBox1.Controls.Add(this.tru);
            this.groupBox1.Controls.Add(this.cong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // chia
            // 
            this.chia.AutoSize = true;
            this.chia.Location = new System.Drawing.Point(348, 42);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(68, 26);
            this.chia.TabIndex = 3;
            this.chia.TabStop = true;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.CheckedChanged += new System.EventHandler(this.chia_CheckedChanged);
            // 
            // nhan
            // 
            this.nhan.AutoSize = true;
            this.nhan.Location = new System.Drawing.Point(237, 42);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(74, 26);
            this.nhan.TabIndex = 2;
            this.nhan.TabStop = true;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.CheckedChanged += new System.EventHandler(this.nhan_CheckedChanged);
            // 
            // tru
            // 
            this.tru.AutoSize = true;
            this.tru.Location = new System.Drawing.Point(132, 42);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(59, 26);
            this.tru.TabIndex = 1;
            this.tru.TabStop = true;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.CheckedChanged += new System.EventHandler(this.tru_CheckedChanged);
            // 
            // cong
            // 
            this.cong.AutoSize = true;
            this.cong.Location = new System.Drawing.Point(15, 42);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(74, 26);
            this.cong.TabIndex = 0;
            this.cong.TabStop = true;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.CheckedChanged += new System.EventHandler(this.cong_CheckedChanged);
            // 
            // ketQua
            // 
            this.ketQua.AutoSize = true;
            this.ketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketQua.Location = new System.Drawing.Point(80, 277);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(72, 22);
            this.ketQua.TabIndex = 5;
            this.ketQua.Text = "Kết quả";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(158, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(296, 28);
            this.textBox3.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 344);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy tính";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label so1;
        private System.Windows.Forms.Label so2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chia;
        private System.Windows.Forms.RadioButton nhan;
        private System.Windows.Forms.RadioButton tru;
        private System.Windows.Forms.RadioButton cong;
        private System.Windows.Forms.Label ketQua;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

