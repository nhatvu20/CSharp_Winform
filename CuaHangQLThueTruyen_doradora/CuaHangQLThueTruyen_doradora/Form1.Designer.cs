
namespace CuaHangQLThueTruyen_doradora
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbxTenT = new System.Windows.Forms.ComboBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.dateTimePicker1Muon = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2Tra = new System.Windows.Forms.DateTimePicker();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CuaHangQLThueTruyen_doradora.Properties.Resources._266182312_612433389997699_1301983976303569916_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên truyện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn giá/ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày trả";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(472, 46);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(292, 20);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // cbxTenT
            // 
            this.cbxTenT.FormattingEnabled = true;
            this.cbxTenT.Location = new System.Drawing.Point(472, 80);
            this.cbxTenT.Name = "cbxTenT";
            this.cbxTenT.Size = new System.Drawing.Size(292, 21);
            this.cbxTenT.TabIndex = 10;
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(472, 110);
            this.txtDG.Name = "txtDG";
            this.txtDG.ReadOnly = true;
            this.txtDG.Size = new System.Drawing.Size(292, 20);
            this.txtDG.TabIndex = 11;
            // 
            // dateTimePicker1Muon
            // 
            this.dateTimePicker1Muon.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1Muon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1Muon.Location = new System.Drawing.Point(458, 136);
            this.dateTimePicker1Muon.Name = "dateTimePicker1Muon";
            this.dateTimePicker1Muon.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker1Muon.TabIndex = 12;
            // 
            // dateTimePicker2Tra
            // 
            this.dateTimePicker2Tra.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2Tra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2Tra.Location = new System.Drawing.Point(458, 165);
            this.dateTimePicker2Tra.Name = "dateTimePicker2Tra";
            this.dateTimePicker2Tra.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker2Tra.TabIndex = 13;
            // 
            // btnMuon
            // 
            this.btnMuon.Location = new System.Drawing.Point(689, 137);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(75, 23);
            this.btnMuon.TabIndex = 14;
            this.btnMuon.Text = "Mượn truyện";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(689, 165);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(75, 23);
            this.btnTra.TabIndex = 15;
            this.btnTra.Text = "Trả truyện";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(472, 17);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(292, 20);
            this.txtKH.TabIndex = 16;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelID.Location = new System.Drawing.Point(377, 198);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "label7";
            this.labelID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.dateTimePicker2Tra);
            this.Controls.Add(this.dateTimePicker1Muon);
            this.Controls.Add(this.txtDG);
            this.Controls.Add(this.cbxTenT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý truyện tranh _ Nguyễn Như Nhất Vũ - 2151060242";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cbxTenT;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Muon;
        private System.Windows.Forms.DateTimePicker dateTimePicker2Tra;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label labelID;
    }
}

