
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doiMauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.doiMauToolStripMenuItem.CheckOnClick = true;
            this.doiMauToolStripMenuItem.Name = "doiMauToolStripMenuItem";
            this.doiMauToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.doiMauToolStripMenuItem.Text = "Đổi màu";
            this.doiMauToolStripMenuItem.Click += new System.EventHandler(this.doiMauToolStripMenuItem_Click);
            // 
            // doiFontToolStripMenuItem
            // 
            this.doiFontToolStripMenuItem.Name = "doiFontToolStripMenuItem";
            this.doiFontToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.doiFontToolStripMenuItem.Text = "Đổi Font";
            this.doiFontToolStripMenuItem.Click += new System.EventHandler(this.doiFontToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(238, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập a";
            // 
            // txtA
            // 
            this.txtA.ContextMenuStrip = this.contextMenuStrip1;
            this.txtA.Location = new System.Drawing.Point(316, 123);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(305, 20);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Location = new System.Drawing.Point(238, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b";
            // 
            // txtB
            // 
            this.txtB.ContextMenuStrip = this.contextMenuStrip1;
            this.txtB.Location = new System.Drawing.Point(316, 170);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(305, 20);
            this.txtB.TabIndex = 1;
            this.txtB.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Location = new System.Drawing.Point(238, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập c";
            // 
            // txtC
            // 
            this.txtC.ContextMenuStrip = this.contextMenuStrip1;
            this.txtC.Location = new System.Drawing.Point(316, 219);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(305, 20);
            this.txtC.TabIndex = 2;
            this.txtC.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // btnTinh
            // 
            this.btnTinh.ContextMenuStrip = this.contextMenuStrip1;
            this.btnTinh.Location = new System.Drawing.Point(546, 311);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Location = new System.Drawing.Point(238, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kết quả";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(316, 270);
            this.txtkq.Name = "txtkq";
            this.txtkq.ReadOnly = true;
            this.txtkq.Size = new System.Drawing.Size(305, 20);
            this.txtkq.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doiMauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiFontToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhuongTrinh;
    }
}

