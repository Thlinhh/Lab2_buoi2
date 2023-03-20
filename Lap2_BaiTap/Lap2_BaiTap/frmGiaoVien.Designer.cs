namespace Lap2_BaiTap
{
    partial class frmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbDanhSachMH = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMonHocDay = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linklbLienhe = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN GIÁO VIÊN KHOA CNTT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(421, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới Tính";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(73, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(73, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Sinh";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(177, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Danh sách môn học";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboMaSo
            // 
            this.cboMaSo.FormattingEnabled = true;
            this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.cboMaSo.Location = new System.Drawing.Point(180, 66);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(133, 21);
            this.cboMaSo.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(180, 94);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(196, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(180, 125);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(196, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // lbDanhSachMH
            // 
            this.lbDanhSachMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachMH.FormattingEnabled = true;
            this.lbDanhSachMH.ItemHeight = 16;
            this.lbDanhSachMH.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
            this.lbDanhSachMH.Location = new System.Drawing.Point(180, 301);
            this.lbDanhSachMH.Name = "lbDanhSachMH";
            this.lbDanhSachMH.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSachMH.Size = new System.Drawing.Size(175, 148);
            this.lbDanhSachMH.TabIndex = 5;
            this.lbDanhSachMH.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(421, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Môn học giáo viên dạy";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbMonHocDay
            // 
            this.lbMonHocDay.FormattingEnabled = true;
            this.lbMonHocDay.Location = new System.Drawing.Point(424, 301);
            this.lbMonHocDay.Name = "lbMonHocDay";
            this.lbMonHocDay.Size = new System.Drawing.Size(175, 147);
            this.lbMonHocDay.TabIndex = 5;
            this.lbMonHocDay.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(375, 324);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(33, 28);
            this.btnChon.TabIndex = 6;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(375, 368);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(33, 28);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(67, 464);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(85, 28);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(536, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Location = new System.Drawing.Point(171, 464);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 28);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(283, 464);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 28);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(398, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(73, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã Số";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(421, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số ĐT";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(421, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Địa chỉ mail";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(523, 70);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 7;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(593, 70);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 7;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(523, 124);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(196, 20);
            this.txtMail.TabIndex = 3;
            this.txtMail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(73, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ngoại ngữ";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // chklbNgoaiNgu
            // 
            this.chklbNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbNgoaiNgu.FormattingEnabled = true;
            this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.chklbNgoaiNgu.Location = new System.Drawing.Point(180, 158);
            this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            this.chklbNgoaiNgu.Size = new System.Drawing.Size(120, 94);
            this.chklbNgoaiNgu.TabIndex = 8;
            this.chklbNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSoDT.Location = new System.Drawing.Point(521, 98);
            this.mtxtSoDT.Mask = "(0633).000.000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(141, 23);
            this.mtxtSoDT.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(517, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "website";
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // linklbLienhe
            // 
            this.linklbLienhe.AutoSize = true;
            this.linklbLienhe.Location = new System.Drawing.Point(585, 511);
            this.linklbLienhe.Name = "linklbLienhe";
            this.linklbLienhe.Size = new System.Drawing.Size(42, 13);
            this.linklbLienhe.TabIndex = 10;
            this.linklbLienhe.TabStop = true;
            this.linklbLienhe.Text = "Liên hệ";
            this.linklbLienhe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbLienhe_LinkClicked);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.linklbLienhe);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.chklbNgoaiNgu);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbMonHocDay);
            this.Controls.Add(this.lbDanhSachMH);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ListBox lbDanhSachMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbMonHocDay;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linklbLienhe;
    }
}

