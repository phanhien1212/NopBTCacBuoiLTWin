
namespace Buoi03_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txtMSV = new System.Windows.Forms.MaskedTextBox();
            this.cbMuaSam = new System.Windows.Forms.CheckBox();
            this.cbDuLich = new System.Windows.Forms.CheckBox();
            this.cbTheThao = new System.Windows.Forms.CheckBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.sothich = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txx1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDanhSach = new System.Windows.Forms.GroupBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.txtDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(278, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Controls.Add(this.cbMuaSam);
            this.groupBox1.Controls.Add(this.cbDuLich);
            this.groupBox1.Controls.Add(this.cbTheThao);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.sothich);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txx1);
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Location = new System.Drawing.Point(35, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(116, 144);
            this.txtNgaySinh.Mask = "00/00/0000";
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(196, 22);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(116, 35);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(196, 22);
            this.txtMSV.TabIndex = 4;
            this.txtMSV.Text = "21";
            // 
            // cbMuaSam
            // 
            this.cbMuaSam.AutoSize = true;
            this.cbMuaSam.Location = new System.Drawing.Point(98, 345);
            this.cbMuaSam.Name = "cbMuaSam";
            this.cbMuaSam.Size = new System.Drawing.Size(87, 21);
            this.cbMuaSam.TabIndex = 3;
            this.cbMuaSam.Text = "Mua sắm";
            this.cbMuaSam.UseVisualStyleBackColor = true;
            // 
            // cbDuLich
            // 
            this.cbDuLich.AutoSize = true;
            this.cbDuLich.Location = new System.Drawing.Point(98, 301);
            this.cbDuLich.Name = "cbDuLich";
            this.cbDuLich.Size = new System.Drawing.Size(73, 21);
            this.cbDuLich.TabIndex = 3;
            this.cbDuLich.Text = "Du lịch";
            this.cbDuLich.UseVisualStyleBackColor = true;
            // 
            // cbTheThao
            // 
            this.cbTheThao.AutoSize = true;
            this.cbTheThao.Location = new System.Drawing.Point(98, 256);
            this.cbTheThao.Name = "cbTheThao";
            this.cbTheThao.Size = new System.Drawing.Size(87, 21);
            this.cbTheThao.TabIndex = 3;
            this.cbTheThao.Text = "Thể thao";
            this.cbTheThao.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(214, 204);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 2;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(98, 204);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 2;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(116, 87);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(196, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // sothich
            // 
            this.sothich.AutoSize = true;
            this.sothich.Location = new System.Drawing.Point(24, 256);
            this.sothich.Name = "sothich";
            this.sothich.Size = new System.Drawing.Size(59, 17);
            this.sothich.TabIndex = 0;
            this.sothich.Text = "Sở thích";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(23, 144);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(71, 17);
            this.txt2.TabIndex = 0;
            this.txt2.Text = "Ngày sinh";
            // 
            // txx1
            // 
            this.txx1.AutoSize = true;
            this.txx1.Location = new System.Drawing.Point(23, 87);
            this.txx1.Name = "txx1";
            this.txx1.Size = new System.Drawing.Size(50, 17);
            this.txx1.TabIndex = 0;
            this.txx1.Text = "Họ tên";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(23, 35);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(87, 17);
            this.txt.TabIndex = 0;
            this.txt.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(419, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(260, 48);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 33);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(152, 48);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 33);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa DS";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm vào DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Controls.Add(this.lblThongBao);
            this.txtDanhSach.Location = new System.Drawing.Point(419, 244);
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(365, 267);
            this.txtDanhSach.TabIndex = 3;
            this.txtDanhSach.TabStop = false;
            this.txtDanhSach.Text = "Danh sách";
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblThongBao.Location = new System.Drawing.Point(25, 31);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(322, 223);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 536);
            this.Controls.Add(this.txtDanhSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.txtDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label sothich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txx1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox txtDanhSach;
        private System.Windows.Forms.CheckBox cbMuaSam;
        private System.Windows.Forms.CheckBox cbDuLich;
        private System.Windows.Forms.CheckBox cbTheThao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.MaskedTextBox txtMSV;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
    }
}

