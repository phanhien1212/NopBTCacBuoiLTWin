using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SinhVienDao svDao = new SinhVienDao();
        KhoaDao khDao = new KhoaDao();
        string insertupdate = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            btnXoa.Enabled = false;
            loadDSSinhVien();
            loadDSKhoa();
            TongSinhVien();

        }

        private void TongSinhVien()
        {
            txtTongSV.Text = svDao.getCount().ToString();
            
        }

        private void loadDSKhoa()
        {
            cbKhoa.DataSource = khDao.getList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void loadDSSinhVien()
        {
            dgvDanhSach.DataSource = svDao.getList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaSV.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSV.Enabled = true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                txtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;
                if(txtMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã sinh viên 10 ký tự số");
                }
                if(!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Điểm sinh viên số");
                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
                SinhVien sv = new SinhVien(masv, hoten, makhoa, diemtb);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            svDao.InsertOne(sv);
                            loadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            svDao.UpdateOne(sv);
                            loadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                            break;
                        }
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã sinh viên không đúng");
                }
                string masv = txtMaSV.Text;
                svDao.DeleteOne(masv);
                loadDSSinhVien();
                TongSinhVien();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
            dgvDanhSach.DataSource = svDao.getList(makhoa);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_FromClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
