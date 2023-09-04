
namespace BTform
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.btHienThi = new System.Windows.Forms.Button();
            this.lbSCP = new System.Windows.Forms.Label();
            this.lbSHC = new System.Windows.Forms.Label();
            this.lbSNT = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            label2.Location = new System.Drawing.Point(83, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 13);
            label2.TabIndex = 3;
            label2.Text = "Các số nguyên tố nhỏ hơn n:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            label3.Location = new System.Drawing.Point(83, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(164, 13);
            label3.TabIndex = 4;
            label3.Text = "Các số chính phương nhỏ hơn n:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            label4.Location = new System.Drawing.Point(83, 167);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(130, 13);
            label4.TabIndex = 5;
            label4.Text = "Số hoàn chỉnh nhỏ hơn n:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số n";
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(155, 33);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(100, 20);
            this.txtNhapN.TabIndex = 1;
            this.txtNhapN.TextChanged += new System.EventHandler(this.txtNhapN_TextChanged);
            this.txtNhapN.Leave += new System.EventHandler(this.txtNhapN_Leave);
            // 
            // btHienThi
            // 
            this.btHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btHienThi.Location = new System.Drawing.Point(297, 24);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(79, 36);
            this.btHienThi.TabIndex = 2;
            this.btHienThi.Text = "Hiển thị";
            this.btHienThi.UseVisualStyleBackColor = false;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // lbSCP
            // 
            this.lbSCP.AutoSize = true;
            this.lbSCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.lbSCP.Location = new System.Drawing.Point(256, 128);
            this.lbSCP.Name = "lbSCP";
            this.lbSCP.Size = new System.Drawing.Size(0, 13);
            this.lbSCP.TabIndex = 7;
            // 
            // lbSHC
            // 
            this.lbSHC.AutoSize = true;
            this.lbSHC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.lbSHC.Location = new System.Drawing.Point(220, 167);
            this.lbSHC.Name = "lbSHC";
            this.lbSHC.Size = new System.Drawing.Size(0, 13);
            this.lbSHC.TabIndex = 8;
            // 
            // lbSNT
            // 
            this.lbSNT.AutoSize = true;
            this.lbSNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSNT.Location = new System.Drawing.Point(247, 86);
            this.lbSNT.Name = "lbSNT";
            this.lbSNT.Size = new System.Drawing.Size(0, 13);
            this.lbSNT.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btHienThi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 254);
            this.Controls.Add(this.lbSNT);
            this.Controls.Add(this.lbSHC);
            this.Controls.Add(this.lbSCP);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Label lbSCP;
        private System.Windows.Forms.Label lbSHC;
        private System.Windows.Forms.Label lbSNT;
    }
}

