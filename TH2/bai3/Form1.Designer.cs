
namespace bai3
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
            this.ketqua = new System.Windows.Forms.Label();
            this.grpheptinh1 = new System.Windows.Forms.GroupBox();
            this.chia = new System.Windows.Forms.RadioButton();
            this.nhan = new System.Windows.Forms.RadioButton();
            this.tru = new System.Windows.Forms.RadioButton();
            this.cong = new System.Windows.Forms.RadioButton();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpheptinh1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // so1
            // 
            this.so1.AutoSize = true;
            this.so1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so1.Location = new System.Drawing.Point(54, 42);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(33, 13);
            this.so1.TabIndex = 0;
            this.so1.Text = "Số 1";
            // 
            // so2
            // 
            this.so2.AutoSize = true;
            this.so2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so2.Location = new System.Drawing.Point(54, 86);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(33, 13);
            this.so2.TabIndex = 1;
            this.so2.Text = "Số 2";
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.Location = new System.Drawing.Point(33, 249);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(51, 13);
            this.ketqua.TabIndex = 3;
            this.ketqua.Text = "Kết quả";
            // 
            // grpheptinh1
            // 
            this.grpheptinh1.Controls.Add(this.chia);
            this.grpheptinh1.Controls.Add(this.nhan);
            this.grpheptinh1.Controls.Add(this.tru);
            this.grpheptinh1.Controls.Add(this.cong);
            this.grpheptinh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpheptinh1.Location = new System.Drawing.Point(57, 126);
            this.grpheptinh1.Name = "grpheptinh1";
            this.grpheptinh1.Size = new System.Drawing.Size(384, 100);
            this.grpheptinh1.TabIndex = 4;
            this.grpheptinh1.TabStop = false;
            this.grpheptinh1.Text = "Phép tính";
            // 
            // chia
            // 
            this.chia.AutoSize = true;
            this.chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chia.Location = new System.Drawing.Point(295, 33);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(50, 17);
            this.chia.TabIndex = 3;
            this.chia.TabStop = true;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.CheckedChanged += new System.EventHandler(this.chia_CheckedChanged);
            // 
            // nhan
            // 
            this.nhan.AutoSize = true;
            this.nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhan.Location = new System.Drawing.Point(197, 33);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(55, 17);
            this.nhan.TabIndex = 2;
            this.nhan.TabStop = true;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.CheckedChanged += new System.EventHandler(this.nhan_CheckedChanged);
            // 
            // tru
            // 
            this.tru.AutoSize = true;
            this.tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tru.Location = new System.Drawing.Point(93, 33);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(44, 17);
            this.tru.TabIndex = 1;
            this.tru.TabStop = true;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.CheckedChanged += new System.EventHandler(this.tru_CheckedChanged);
            // 
            // cong
            // 
            this.cong.AutoSize = true;
            this.cong.Checked = true;
            this.cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cong.Location = new System.Drawing.Point(7, 33);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(54, 17);
            this.cong.TabIndex = 0;
            this.cong.TabStop = true;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.CheckedChanged += new System.EventHandler(this.cong_CheckedChanged);
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(121, 42);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(320, 20);
            this.txtSo1.TabIndex = 5;
            this.txtSo1.Text = "40";
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(121, 86);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(320, 20);
            this.txtSo2.TabIndex = 6;
            this.txtSo2.Text = "5";
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo2_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(121, 249);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(320, 20);
            this.txtKetQua.TabIndex = 8;
            this.txtKetQua.Text = "45";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 333);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.grpheptinh1);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Name = "Form1";
            this.Text = "Phép tính";
            this.grpheptinh1.ResumeLayout(false);
            this.grpheptinh1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label so1;
        private System.Windows.Forms.Label so2;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.GroupBox grpheptinh1;
        private System.Windows.Forms.RadioButton chia;
        private System.Windows.Forms.RadioButton nhan;
        private System.Windows.Forms.RadioButton tru;
        private System.Windows.Forms.RadioButton cong;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

