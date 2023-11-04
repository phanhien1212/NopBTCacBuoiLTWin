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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        KhoaDao khDao = new KhoaDao();
        string insertupdate = "";
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaKhoa.Enabled = false;
            btnXoa.Enabled = false;

            loadDSKhoa();
        }
        private void loadDSKhoa()
        {
            dgvDanhSach.DataSource = khDao.getList();
            cbTenKhoa.DisplayMember = "TenKhoa";
            cbTenKhoa.ValueMember = "MaKhoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaKhoa.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaKhoa.Enabled = true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if(rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn khoa");
                }
                txtMaKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["MaKhoa"].Value.ToString();
                cbTenKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.Rows[rowindex].Cells["GhiChu"].Value.ToString();
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

                if(txtMaKhoa.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên 10 ký tự số");
                }

                string makhoa = txtMaKhoa.Text;
                string tenkhoa = cbTenKhoa.Text;
                string ghichu = txtGhiChu.Text;
                int makhoa1 = int.Parse(cbTenKhoa.SelectedValue.ToString());
                Khoa kh = new Khoa(makhoa, tenkhoa, ghichu);
                switch(insertupdate)
                {
                    case "insert":
                        {
                            khDao.InsertOne(kh);
                            loadDSKhoa();

                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            khDao.InsertOne(kh);
                            loadDSKhoa();

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
                if(txtMaKhoa.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không đúng");
                }
                string makhoa = txtMaKhoa.Text;
                khDao.DeleteOne(makhoa);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}

