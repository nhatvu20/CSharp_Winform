
namespace Bai6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtSoLanXH = new System.Windows.Forms.TextBox();
            this.txtCNDA = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doiMauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEX = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCNDB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nhập b";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuỗi nghịch đảo dài";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lần xuất hiện";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(184, 64);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(378, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(184, 101);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(378, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtSoLanXH
            // 
            this.txtSoLanXH.Location = new System.Drawing.Point(184, 137);
            this.txtSoLanXH.Name = "txtSoLanXH";
            this.txtSoLanXH.Size = new System.Drawing.Size(378, 20);
            this.txtSoLanXH.TabIndex = 3;
            // 
            // txtCNDA
            // 
            this.txtCNDA.Location = new System.Drawing.Point(184, 176);
            this.txtCNDA.Name = "txtCNDA";
            this.txtCNDA.Size = new System.Drawing.Size(378, 20);
            this.txtCNDA.TabIndex = 4;
            this.txtCNDA.TextChanged += new System.EventHandler(this.txtCND_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMauToolStripMenuItem,
            this.doiFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // doiMauToolStripMenuItem
            // 
            this.doiMauToolStripMenuItem.Name = "doiMauToolStripMenuItem";
            this.doiMauToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doiMauToolStripMenuItem.Text = "Đổi màu";
            this.doiMauToolStripMenuItem.Click += new System.EventHandler(this.doiMauToolStripMenuItem_Click);
            // 
            // doiFontToolStripMenuItem
            // 
            this.doiFontToolStripMenuItem.Name = "doiFontToolStripMenuItem";
            this.doiFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doiFontToolStripMenuItem.Text = "Đổi Font";
            // 
            // btnEX
            // 
            this.btnEX.Location = new System.Drawing.Point(209, 253);
            this.btnEX.Name = "btnEX";
            this.btnEX.Size = new System.Drawing.Size(75, 23);
            this.btnEX.TabIndex = 4;
            this.btnEX.Text = "Excute";
            this.btnEX.UseVisualStyleBackColor = true;
            this.btnEX.Click += new System.EventHandler(this.btnEX_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chuỗi nghịch đảo ngắn";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCNDB
            // 
            this.txtCNDB.Location = new System.Drawing.Point(184, 211);
            this.txtCNDB.Name = "txtCNDB";
            this.txtCNDB.Size = new System.Drawing.Size(378, 20);
            this.txtCNDB.TabIndex = 5;
            this.txtCNDB.TextChanged += new System.EventHandler(this.txtCND_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEX;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEX);
            this.Controls.Add(this.txtCNDB);
            this.Controls.Add(this.txtCNDA);
            this.Controls.Add(this.txtSoLanXH);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtSoLanXH;
        private System.Windows.Forms.TextBox txtCNDA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doiMauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiFontToolStripMenuItem;
        private System.Windows.Forms.Button btnEX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCNDB;
    }
}

