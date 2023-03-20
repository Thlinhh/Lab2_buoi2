
namespace Lab2
{
    partial class frmTrungTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrungTam));
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.cboMaHV = new System.Windows.Forms.ComboBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblMaHocVien = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgayDK = new System.Windows.Forms.Label();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.chkTinHocA = new System.Windows.Forms.CheckBox();
            this.chkTinHocB = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhA = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhB = new System.Windows.Forms.CheckBox();
            this.lblTienTHA = new System.Windows.Forms.Label();
            this.lblTienTHB = new System.Windows.Forms.Label();
            this.lblTienTAA = new System.Windows.Forms.Label();
            this.lblTienTAB = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTienHocTrungTam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(377, 56);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(55, 21);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // cboMaHV
            // 
            this.cboMaHV.FormattingEnabled = true;
            this.cboMaHV.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.cboMaHV.Location = new System.Drawing.Point(141, 58);
            this.cboMaHV.Name = "cboMaHV";
            this.cboMaHV.Size = new System.Drawing.Size(121, 21);
            this.cboMaHV.TabIndex = 0;
            this.cboMaHV.Text = "`";
            this.cboMaHV.SelectedIndexChanged += new System.EventHandler(this.cboMaHV_SelectedIndexChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(451, 56);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(44, 21);
            this.rdNu.TabIndex = 2;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(141, 106);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(365, 20);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // lblMaHocVien
            // 
            this.lblMaHocVien.AutoSize = true;
            this.lblMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocVien.Location = new System.Drawing.Point(12, 60);
            this.lblMaHocVien.Name = "lblMaHocVien";
            this.lblMaHocVien.Size = new System.Drawing.Size(99, 17);
            this.lblMaHocVien.TabIndex = 2;
            this.lblMaHocVien.Text = "Mã Học Viên";
            this.lblMaHocVien.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(285, 58);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(74, 17);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(12, 109);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 17);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblNgayDK
            // 
            this.lblNgayDK.AutoSize = true;
            this.lblNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDK.Location = new System.Drawing.Point(12, 163);
            this.lblNgayDK.Name = "lblNgayDK";
            this.lblNgayDK.Size = new System.Drawing.Size(107, 17);
            this.lblNgayDK.TabIndex = 7;
            this.lblNgayDK.Text = "Ngày Đăng Kí";
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Location = new System.Drawing.Point(141, 159);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayDangKy.TabIndex = 4;
            // 
            // chkTinHocA
            // 
            this.chkTinHocA.AutoSize = true;
            this.chkTinHocA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTinHocA.Location = new System.Drawing.Point(75, 207);
            this.chkTinHocA.Name = "chkTinHocA";
            this.chkTinHocA.Size = new System.Drawing.Size(89, 21);
            this.chkTinHocA.TabIndex = 5;
            this.chkTinHocA.Text = "Tin Học A";
            this.chkTinHocA.UseVisualStyleBackColor = true;
            // 
            // chkTinHocB
            // 
            this.chkTinHocB.AutoSize = true;
            this.chkTinHocB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTinHocB.Location = new System.Drawing.Point(75, 234);
            this.chkTinHocB.Name = "chkTinHocB";
            this.chkTinHocB.Size = new System.Drawing.Size(89, 21);
            this.chkTinHocB.TabIndex = 6;
            this.chkTinHocB.Text = "Tin Học B";
            this.chkTinHocB.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhA
            // 
            this.chkTiengAnhA.AutoSize = true;
            this.chkTiengAnhA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTiengAnhA.Location = new System.Drawing.Point(75, 261);
            this.chkTiengAnhA.Name = "chkTiengAnhA";
            this.chkTiengAnhA.Size = new System.Drawing.Size(105, 21);
            this.chkTiengAnhA.TabIndex = 7;
            this.chkTiengAnhA.Text = "Tiếng Anh A";
            this.chkTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhB
            // 
            this.chkTiengAnhB.AutoSize = true;
            this.chkTiengAnhB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTiengAnhB.Location = new System.Drawing.Point(75, 288);
            this.chkTiengAnhB.Name = "chkTiengAnhB";
            this.chkTiengAnhB.Size = new System.Drawing.Size(105, 21);
            this.chkTiengAnhB.TabIndex = 8;
            this.chkTiengAnhB.Text = "Tiếng Anh B";
            this.chkTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // lblTienTHA
            // 
            this.lblTienTHA.AutoSize = true;
            this.lblTienTHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTHA.Location = new System.Drawing.Point(290, 208);
            this.lblTienTHA.Name = "lblTienTHA";
            this.lblTienTHA.Size = new System.Drawing.Size(96, 17);
            this.lblTienTHA.TabIndex = 14;
            this.lblTienTHA.Text = "300.000 đồng";
            // 
            // lblTienTHB
            // 
            this.lblTienTHB.AutoSize = true;
            this.lblTienTHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTHB.Location = new System.Drawing.Point(290, 235);
            this.lblTienTHB.Name = "lblTienTHB";
            this.lblTienTHB.Size = new System.Drawing.Size(96, 17);
            this.lblTienTHB.TabIndex = 15;
            this.lblTienTHB.Text = "500.000 đồng";
            // 
            // lblTienTAA
            // 
            this.lblTienTAA.AutoSize = true;
            this.lblTienTAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTAA.Location = new System.Drawing.Point(290, 262);
            this.lblTienTAA.Name = "lblTienTAA";
            this.lblTienTAA.Size = new System.Drawing.Size(96, 17);
            this.lblTienTAA.TabIndex = 16;
            this.lblTienTAA.Text = "400.000 đồng";
            this.lblTienTAA.Click += new System.EventHandler(this.lblTienTAA_Click);
            // 
            // lblTienTAB
            // 
            this.lblTienTAB.AutoSize = true;
            this.lblTienTAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTAB.Location = new System.Drawing.Point(290, 289);
            this.lblTienTAB.Name = "lblTienTAB";
            this.lblTienTAB.Size = new System.Drawing.Size(96, 17);
            this.lblTienTAB.TabIndex = 17;
            this.lblTienTAB.Text = "600.000 đồng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(222, 337);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 9;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(117, 338);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(82, 17);
            this.lblTongTien.TabIndex = 19;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTinhTien.Location = new System.Drawing.Point(75, 390);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(91, 23);
            this.btnTinhTien.TabIndex = 20;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(212, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(365, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTienHocTrungTam
            // 
            this.lblTienHocTrungTam.AutoSize = true;
            this.lblTienHocTrungTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienHocTrungTam.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTienHocTrungTam.Location = new System.Drawing.Point(116, 9);
            this.lblTienHocTrungTam.Name = "lblTienHocTrungTam";
            this.lblTienHocTrungTam.Size = new System.Drawing.Size(279, 22);
            this.lblTienHocTrungTam.TabIndex = 1;
            this.lblTienHocTrungTam.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            // 
            // frmTrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.lblTienHocTrungTam);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTienTAB);
            this.Controls.Add(this.lblTienTAA);
            this.Controls.Add(this.lblTienTHB);
            this.Controls.Add(this.lblTienTHA);
            this.Controls.Add(this.chkTiengAnhB);
            this.Controls.Add(this.chkTiengAnhA);
            this.Controls.Add(this.chkTinHocB);
            this.Controls.Add(this.chkTinHocA);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.lblNgayDK);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblMaHocVien);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.cboMaHV);
            this.Controls.Add(this.rdNam);
            this.Name = "frmTrungTam";
            this.Text = "Simple Drawing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.ComboBox cboMaHV;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgayDK;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.CheckBox chkTinHocA;
        private System.Windows.Forms.CheckBox chkTinHocB;
        private System.Windows.Forms.CheckBox chkTiengAnhA;
        private System.Windows.Forms.CheckBox chkTiengAnhB;
        private System.Windows.Forms.Label lblTienTHA;
        private System.Windows.Forms.Label lblTienTHB;
        private System.Windows.Forms.Label lblTienTAA;
        private System.Windows.Forms.Label lblTienTAB;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTienHocTrungTam;
    }
}

