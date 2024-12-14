namespace OnTap2
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
            this.tbTenLoaiLTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiThietBi = new System.Windows.Forms.DataGridView();
            this.tbGhiChuLTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemLTB = new System.Windows.Forms.Button();
            this.btnSuaLTB = new System.Windows.Forms.Button();
            this.btnXoaLTB = new System.Windows.Forms.Button();
            this.btnClearLTB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDonViTB = new System.Windows.Forms.ComboBox();
            this.cbLoaiThietBiTB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNuocSXTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNamSXTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNgaySDTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGhiChuTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.cbDonViTBTimKiem = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTimKiemTheoDonVi = new System.Windows.Forms.Button();
            this.tbThietBiTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThietBi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Loai:";
            // 
            // tbTenLoaiLTB
            // 
            this.tbTenLoaiLTB.Location = new System.Drawing.Point(94, 45);
            this.tbTenLoaiLTB.Name = "tbTenLoaiLTB";
            this.tbTenLoaiLTB.Size = new System.Drawing.Size(237, 22);
            this.tbTenLoaiLTB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLoaiThietBi);
            this.groupBox1.Location = new System.Drawing.Point(353, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loai Thiet Bi";
            // 
            // dgvLoaiThietBi
            // 
            this.dgvLoaiThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiThietBi.Location = new System.Drawing.Point(0, 21);
            this.dgvLoaiThietBi.Name = "dgvLoaiThietBi";
            this.dgvLoaiThietBi.RowHeadersWidth = 51;
            this.dgvLoaiThietBi.RowTemplate.Height = 24;
            this.dgvLoaiThietBi.Size = new System.Drawing.Size(758, 105);
            this.dgvLoaiThietBi.TabIndex = 3;
            // 
            // tbGhiChuLTB
            // 
            this.tbGhiChuLTB.Location = new System.Drawing.Point(94, 73);
            this.tbGhiChuLTB.Name = "tbGhiChuLTB";
            this.tbGhiChuLTB.Size = new System.Drawing.Size(237, 22);
            this.tbGhiChuLTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ghi Chu:";
            // 
            // btnThemLTB
            // 
            this.btnThemLTB.Location = new System.Drawing.Point(13, 127);
            this.btnThemLTB.Name = "btnThemLTB";
            this.btnThemLTB.Size = new System.Drawing.Size(75, 23);
            this.btnThemLTB.TabIndex = 3;
            this.btnThemLTB.Text = "Them";
            this.btnThemLTB.UseVisualStyleBackColor = true;
            this.btnThemLTB.Click += new System.EventHandler(this.btnThemLTB_Click);
            // 
            // btnSuaLTB
            // 
            this.btnSuaLTB.Location = new System.Drawing.Point(94, 127);
            this.btnSuaLTB.Name = "btnSuaLTB";
            this.btnSuaLTB.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLTB.TabIndex = 4;
            this.btnSuaLTB.Text = "Sua";
            this.btnSuaLTB.UseVisualStyleBackColor = true;
            this.btnSuaLTB.Click += new System.EventHandler(this.btnSuaLTB_Click);
            // 
            // btnXoaLTB
            // 
            this.btnXoaLTB.Location = new System.Drawing.Point(175, 127);
            this.btnXoaLTB.Name = "btnXoaLTB";
            this.btnXoaLTB.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLTB.TabIndex = 5;
            this.btnXoaLTB.Text = "Xoa";
            this.btnXoaLTB.UseVisualStyleBackColor = true;
            this.btnXoaLTB.Click += new System.EventHandler(this.btnXoaLTB_Click);
            // 
            // btnClearLTB
            // 
            this.btnClearLTB.Location = new System.Drawing.Point(256, 127);
            this.btnClearLTB.Name = "btnClearLTB";
            this.btnClearLTB.Size = new System.Drawing.Size(75, 23);
            this.btnClearLTB.TabIndex = 6;
            this.btnClearLTB.Text = "Clear";
            this.btnClearLTB.UseVisualStyleBackColor = true;
            this.btnClearLTB.Click += new System.EventHandler(this.btnClearLTB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThietBi);
            this.groupBox2.Location = new System.Drawing.Point(353, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 390);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiet Bi";
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Location = new System.Drawing.Point(0, 21);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.Size = new System.Drawing.Size(758, 363);
            this.dgvThietBi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Don vi:";
            // 
            // cbDonViTB
            // 
            this.cbDonViTB.FormattingEnabled = true;
            this.cbDonViTB.Location = new System.Drawing.Point(94, 190);
            this.cbDonViTB.Name = "cbDonViTB";
            this.cbDonViTB.Size = new System.Drawing.Size(237, 24);
            this.cbDonViTB.TabIndex = 10;
            // 
            // cbLoaiThietBiTB
            // 
            this.cbLoaiThietBiTB.FormattingEnabled = true;
            this.cbLoaiThietBiTB.Location = new System.Drawing.Point(94, 220);
            this.cbLoaiThietBiTB.Name = "cbLoaiThietBiTB";
            this.cbLoaiThietBiTB.Size = new System.Drawing.Size(237, 24);
            this.cbLoaiThietBiTB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loai Thiet Bi:";
            // 
            // tbTenTB
            // 
            this.tbTenTB.Location = new System.Drawing.Point(94, 250);
            this.tbTenTB.Name = "tbTenTB";
            this.tbTenTB.Size = new System.Drawing.Size(237, 22);
            this.tbTenTB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ten Thiet Bi:";
            // 
            // tbNuocSXTB
            // 
            this.tbNuocSXTB.Location = new System.Drawing.Point(94, 278);
            this.tbNuocSXTB.Name = "tbNuocSXTB";
            this.tbNuocSXTB.Size = new System.Drawing.Size(237, 22);
            this.tbNuocSXTB.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nuoc sx:";
            // 
            // tbNamSXTB
            // 
            this.tbNamSXTB.Location = new System.Drawing.Point(94, 306);
            this.tbNamSXTB.Name = "tbNamSXTB";
            this.tbNamSXTB.Size = new System.Drawing.Size(237, 22);
            this.tbNamSXTB.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nam sx:";
            // 
            // tbNgaySDTB
            // 
            this.tbNgaySDTB.Location = new System.Drawing.Point(94, 334);
            this.tbNgaySDTB.Name = "tbNgaySDTB";
            this.tbNgaySDTB.Size = new System.Drawing.Size(237, 22);
            this.tbNgaySDTB.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ngay sd:";
            // 
            // tbGhiChuTB
            // 
            this.tbGhiChuTB.Location = new System.Drawing.Point(94, 362);
            this.tbGhiChuTB.Name = "tbGhiChuTB";
            this.tbGhiChuTB.Size = new System.Drawing.Size(237, 22);
            this.tbGhiChuTB.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ghi chu:";
            // 
            // btnThemTB
            // 
            this.btnThemTB.Location = new System.Drawing.Point(15, 393);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(75, 23);
            this.btnThemTB.TabIndex = 23;
            this.btnThemTB.Text = "Them";
            this.btnThemTB.UseVisualStyleBackColor = true;
            // 
            // cbDonViTBTimKiem
            // 
            this.cbDonViTBTimKiem.FormattingEnabled = true;
            this.cbDonViTBTimKiem.Location = new System.Drawing.Point(69, 452);
            this.cbDonViTBTimKiem.Name = "cbDonViTBTimKiem";
            this.cbDonViTBTimKiem.Size = new System.Drawing.Size(181, 24);
            this.cbDonViTBTimKiem.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Don vi:";
            // 
            // btnTimKiemTheoDonVi
            // 
            this.btnTimKiemTheoDonVi.Location = new System.Drawing.Point(256, 452);
            this.btnTimKiemTheoDonVi.Name = "btnTimKiemTheoDonVi";
            this.btnTimKiemTheoDonVi.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemTheoDonVi.TabIndex = 26;
            this.btnTimKiemTheoDonVi.Text = "Tim";
            this.btnTimKiemTheoDonVi.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoDonVi.Click += new System.EventHandler(this.btnTimKiemTheoDonVi_Click);
            // 
            // tbThietBiTimKiem
            // 
            this.tbThietBiTimKiem.Location = new System.Drawing.Point(69, 482);
            this.tbThietBiTimKiem.Name = "tbThietBiTimKiem";
            this.tbThietBiTimKiem.Size = new System.Drawing.Size(181, 22);
            this.tbThietBiTimKiem.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ten TB:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(256, 481);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.Text = "Tim";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(256, 510);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 571);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbThietBiTimKiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnTimKiemTheoDonVi);
            this.Controls.Add(this.cbDonViTBTimKiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnThemTB);
            this.Controls.Add(this.tbGhiChuTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNgaySDTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNamSXTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNuocSXTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTenTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLoaiThietBiTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDonViTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClearLTB);
            this.Controls.Add(this.btnXoaLTB);
            this.Controls.Add(this.btnSuaLTB);
            this.Controls.Add(this.btnThemLTB);
            this.Controls.Add(this.tbGhiChuLTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTenLoaiLTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThietBi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenLoaiLTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLoaiThietBi;
        private System.Windows.Forms.TextBox tbGhiChuLTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemLTB;
        private System.Windows.Forms.Button btnSuaLTB;
        private System.Windows.Forms.Button btnXoaLTB;
        private System.Windows.Forms.Button btnClearLTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDonViTB;
        private System.Windows.Forms.ComboBox cbLoaiThietBiTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNuocSXTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNamSXTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNgaySDTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGhiChuTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.ComboBox cbDonViTBTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTimKiemTheoDonVi;
        private System.Windows.Forms.TextBox tbThietBiTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReset;
    }
}