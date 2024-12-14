namespace OnTap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvLoatThietBi = new DataGridView();
            gbLoaiThietBi = new GroupBox();
            gbThietBi = new GroupBox();
            tblThietBi = new DataGridView();
            cbDonVi = new ComboBox();
            lbDonVi = new Label();
            tbTenLoai = new TextBox();
            tbGhiChu = new TextBox();
            lbTenLoai = new Label();
            lbGhiChu = new Label();
            btnThemLTB = new Button();
            btnSuaLTB = new Button();
            btnXoaLTB = new Button();
            btnClearLTB = new Button();
            lbLoaiThietBi = new Label();
            cbLoaiThietBi = new ComboBox();
            btnThemTB = new Button();
            lbTenThietBi = new Label();
            tbTenThietBi = new TextBox();
            lbNuocSX = new Label();
            tbNuocSX = new TextBox();
            label3 = new Label();
            tbNamSX = new TextBox();
            label4 = new Label();
            tbNgaySD = new TextBox();
            label5 = new Label();
            tbGhiChuTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLoatThietBi).BeginInit();
            gbLoaiThietBi.SuspendLayout();
            gbThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblThietBi).BeginInit();
            SuspendLayout();
            // 
            // dgvLoatThietBi
            // 
            dgvLoatThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoatThietBi.Location = new Point(0, 26);
            dgvLoatThietBi.Name = "dgvLoatThietBi";
            dgvLoatThietBi.RowHeadersWidth = 51;
            dgvLoatThietBi.Size = new Size(629, 146);
            dgvLoatThietBi.TabIndex = 0;
            // 
            // gbLoaiThietBi
            // 
            gbLoaiThietBi.Controls.Add(dgvLoatThietBi);
            gbLoaiThietBi.Location = new Point(465, 22);
            gbLoaiThietBi.Name = "gbLoaiThietBi";
            gbLoaiThietBi.Size = new Size(629, 172);
            gbLoaiThietBi.TabIndex = 1;
            gbLoaiThietBi.TabStop = false;
            gbLoaiThietBi.Text = "Loai Thiet Bi";
            // 
            // gbThietBi
            // 
            gbThietBi.Controls.Add(tblThietBi);
            gbThietBi.Location = new Point(465, 214);
            gbThietBi.Name = "gbThietBi";
            gbThietBi.Size = new Size(629, 400);
            gbThietBi.TabIndex = 2;
            gbThietBi.TabStop = false;
            gbThietBi.Text = "ThietBi";
            // 
            // tblThietBi
            // 
            tblThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblThietBi.Location = new Point(0, 26);
            tblThietBi.Name = "tblThietBi";
            tblThietBi.RowHeadersWidth = 51;
            tblThietBi.Size = new Size(629, 374);
            tblThietBi.TabIndex = 0;
            // 
            // cbDonVi
            // 
            cbDonVi.FormattingEnabled = true;
            cbDonVi.Location = new Point(124, 240);
            cbDonVi.Name = "cbDonVi";
            cbDonVi.Size = new Size(316, 28);
            cbDonVi.TabIndex = 3;
            // 
            // lbDonVi
            // 
            lbDonVi.AutoSize = true;
            lbDonVi.Location = new Point(51, 243);
            lbDonVi.Name = "lbDonVi";
            lbDonVi.Size = new Size(55, 20);
            lbDonVi.TabIndex = 4;
            lbDonVi.Text = "Don vi:";
            // 
            // tbTenLoai
            // 
            tbTenLoai.Location = new Point(124, 48);
            tbTenLoai.Name = "tbTenLoai";
            tbTenLoai.Size = new Size(316, 27);
            tbTenLoai.TabIndex = 5;
            // 
            // tbGhiChu
            // 
            tbGhiChu.Location = new Point(124, 81);
            tbGhiChu.Name = "tbGhiChu";
            tbGhiChu.Size = new Size(316, 27);
            tbGhiChu.TabIndex = 6;
            // 
            // lbTenLoai
            // 
            lbTenLoai.AutoSize = true;
            lbTenLoai.Location = new Point(39, 51);
            lbTenLoai.Name = "lbTenLoai";
            lbTenLoai.Size = new Size(67, 20);
            lbTenLoai.TabIndex = 7;
            lbTenLoai.Text = "Ten Loai:";
            // 
            // lbGhiChu
            // 
            lbGhiChu.AutoSize = true;
            lbGhiChu.Location = new Point(45, 81);
            lbGhiChu.Name = "lbGhiChu";
            lbGhiChu.Size = new Size(61, 20);
            lbGhiChu.TabIndex = 8;
            lbGhiChu.Text = "Ghi chu:";
            // 
            // btnThemLTB
            // 
            btnThemLTB.Location = new Point(13, 126);
            btnThemLTB.Name = "btnThemLTB";
            btnThemLTB.Size = new Size(94, 29);
            btnThemLTB.TabIndex = 9;
            btnThemLTB.Text = "Them";
            btnThemLTB.UseVisualStyleBackColor = true;
            btnThemLTB.Click += btnThemLTB_Click;
            // 
            // btnSuaLTB
            // 
            btnSuaLTB.Location = new Point(125, 126);
            btnSuaLTB.Name = "btnSuaLTB";
            btnSuaLTB.Size = new Size(94, 29);
            btnSuaLTB.TabIndex = 10;
            btnSuaLTB.Text = "Sua";
            btnSuaLTB.UseVisualStyleBackColor = true;
            btnSuaLTB.Click += btnSuaLTB_Click;
            // 
            // btnXoaLTB
            // 
            btnXoaLTB.Location = new Point(237, 126);
            btnXoaLTB.Name = "btnXoaLTB";
            btnXoaLTB.Size = new Size(94, 29);
            btnXoaLTB.TabIndex = 11;
            btnXoaLTB.Text = "Xoa";
            btnXoaLTB.UseVisualStyleBackColor = true;
            btnXoaLTB.Click += btnXoaLTB_Click;
            // 
            // btnClearLTB
            // 
            btnClearLTB.Location = new Point(347, 126);
            btnClearLTB.Name = "btnClearLTB";
            btnClearLTB.Size = new Size(94, 29);
            btnClearLTB.TabIndex = 12;
            btnClearLTB.Text = "Clear";
            btnClearLTB.UseVisualStyleBackColor = true;
            btnClearLTB.Click += btnClearLTB_Click;
            // 
            // lbLoaiThietBi
            // 
            lbLoaiThietBi.AutoSize = true;
            lbLoaiThietBi.Location = new Point(12, 280);
            lbLoaiThietBi.Name = "lbLoaiThietBi";
            lbLoaiThietBi.Size = new Size(94, 20);
            lbLoaiThietBi.TabIndex = 13;
            lbLoaiThietBi.Text = "Loai Thiet Bi:";
            // 
            // cbLoaiThietBi
            // 
            cbLoaiThietBi.FormattingEnabled = true;
            cbLoaiThietBi.Location = new Point(124, 277);
            cbLoaiThietBi.Name = "cbLoaiThietBi";
            cbLoaiThietBi.Size = new Size(316, 28);
            cbLoaiThietBi.TabIndex = 14;
            // 
            // btnThemTB
            // 
            btnThemTB.Location = new Point(12, 488);
            btnThemTB.Name = "btnThemTB";
            btnThemTB.Size = new Size(94, 29);
            btnThemTB.TabIndex = 15;
            btnThemTB.Text = "Them";
            btnThemTB.UseVisualStyleBackColor = true;
            btnThemTB.Click += btnThemTB_Click;
            // 
            // lbTenThietBi
            // 
            lbTenThietBi.AutoSize = true;
            lbTenThietBi.Location = new Point(20, 315);
            lbTenThietBi.Name = "lbTenThietBi";
            lbTenThietBi.Size = new Size(86, 20);
            lbTenThietBi.TabIndex = 17;
            lbTenThietBi.Text = "Ten thiet bi:";
            // 
            // tbTenThietBi
            // 
            tbTenThietBi.Location = new Point(124, 312);
            tbTenThietBi.Name = "tbTenThietBi";
            tbTenThietBi.Size = new Size(316, 27);
            tbTenThietBi.TabIndex = 16;
            // 
            // lbNuocSX
            // 
            lbNuocSX.AutoSize = true;
            lbNuocSX.Location = new Point(43, 351);
            lbNuocSX.Name = "lbNuocSX";
            lbNuocSX.Size = new Size(64, 20);
            lbNuocSX.TabIndex = 19;
            lbNuocSX.Text = "Nuoc sx:";
            // 
            // tbNuocSX
            // 
            tbNuocSX.Location = new Point(125, 348);
            tbNuocSX.Name = "tbNuocSX";
            tbNuocSX.Size = new Size(316, 27);
            tbNuocSX.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 384);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 21;
            label3.Text = "Nam sx:";
            // 
            // tbNamSX
            // 
            tbNamSX.Location = new Point(124, 381);
            tbNamSX.Name = "tbNamSX";
            tbNamSX.Size = new Size(316, 27);
            tbNamSX.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 417);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 23;
            label4.Text = "Ngay sd:";
            // 
            // tbNgaySD
            // 
            tbNgaySD.Location = new Point(124, 414);
            tbNgaySD.Name = "tbNgaySD";
            tbNgaySD.Size = new Size(316, 27);
            tbNgaySD.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 454);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 25;
            label5.Text = "Ghi chu:";
            // 
            // tbGhiChuTB
            // 
            tbGhiChuTB.Location = new Point(124, 447);
            tbGhiChuTB.Name = "tbGhiChuTB";
            tbGhiChuTB.Size = new Size(316, 27);
            tbGhiChuTB.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 651);
            Controls.Add(label5);
            Controls.Add(tbGhiChuTB);
            Controls.Add(label4);
            Controls.Add(tbNgaySD);
            Controls.Add(label3);
            Controls.Add(tbNamSX);
            Controls.Add(lbNuocSX);
            Controls.Add(tbNuocSX);
            Controls.Add(lbTenThietBi);
            Controls.Add(tbTenThietBi);
            Controls.Add(btnThemTB);
            Controls.Add(cbLoaiThietBi);
            Controls.Add(lbLoaiThietBi);
            Controls.Add(btnClearLTB);
            Controls.Add(btnXoaLTB);
            Controls.Add(btnSuaLTB);
            Controls.Add(btnThemLTB);
            Controls.Add(lbGhiChu);
            Controls.Add(lbTenLoai);
            Controls.Add(tbGhiChu);
            Controls.Add(tbTenLoai);
            Controls.Add(lbDonVi);
            Controls.Add(cbDonVi);
            Controls.Add(gbThietBi);
            Controls.Add(gbLoaiThietBi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoatThietBi).EndInit();
            gbLoaiThietBi.ResumeLayout(false);
            gbThietBi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblLoatThietBi;
        private GroupBox gbLoaiThietBi;
        private GroupBox gbThietBi;
        private DataGridView tblThietBi;
        private ComboBox cbDonVi;
        private Label lbDonVi;
        private TextBox tbTenLoai;
        private TextBox tbGhiChu;
        private Label lbTenLoai;
        private Label lbGhiChu;
        private Button btnThemLTB;
        private Button btnSuaLTB;
        private Button btnXoaLTB;
        private Button btnClearLTB;
        private Label lbLoaiThietBi;
        private ComboBox cbLoaiThietBi;
        private Button btnThemTB;
        private Label lbTenThietBi;
        private TextBox tbTenThietBi;
        private Label lbNuocSX;
        private TextBox tbNuocSX;
        private Label label3;
        private TextBox tbNamSX;
        private Label label4;
        private TextBox tbNgaySD;
        private Label label5;
        private TextBox tbGhiChuTB;
        private DataGridView dgvLoatThietBi;
    }
}
