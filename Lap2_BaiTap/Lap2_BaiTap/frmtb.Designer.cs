namespace Lap2_BaiTap
{
    partial class frmtb
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdSoDT);
            this.groupBox1.Controls.Add(this.rdMa);
            this.groupBox1.Location = new System.Drawing.Point(34, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Checked = true;
            this.rdMa.Location = new System.Drawing.Point(6, 19);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(58, 17);
            this.rdMa.TabIndex = 0;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Mã GV";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Location = new System.Drawing.Point(208, 19);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(88, 17);
            this.rdSoDT.TabIndex = 0;
            this.rdSoDT.Text = "Số điện thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(107, 19);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(61, 17);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã GV";
            // 
            // txtMaGV
            // 
            this.txtMaGV.AutoCompleteCustomSource.AddRange(new string[] {
            "001",
            "002",
            "003",
            "004"});
            this.txtMaGV.Location = new System.Drawing.Point(130, 107);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(146, 20);
            this.txtMaGV.TabIndex = 2;
            this.txtMaGV.TextChanged += new System.EventHandler(this.txtMaGV_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(282, 105);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // frmtb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 167);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmtb";
            this.Text = "frmtb";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdMa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Button btnOk;
    }
}