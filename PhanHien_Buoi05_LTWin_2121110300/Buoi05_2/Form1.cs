using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_2
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        String[] listKhoa = { "Cộng Nghệ Thông Tin", "Kế Toán", "Ngoại Ngữ", "Điện tử"};
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = listKhoa;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if(!txtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên 10 ký tự");
                }
                if(this.checkMaSV(txtMaSV.Text) == false)
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                }
                if(txtHoTen.Text.Length.Equals(10))
                {
                    throw new Exception("Họ tên không được để trống");
                }
                if(!double.TryParse(txtDTB.Text, out diemtb))
                {
                    throw new Exception("Điểm trung bình không phải số");
                }
                //Lấy thông tin
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
               
                string khoa = cbKhoa.Text;
                //Lưu dữ liệu vào lưới
                int row = dgvDanhSach.Rows.Add();//Add tạo mới 1 hàng, trả về vị trí thêm
                dgvDanhSach.Rows[row].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[row].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[row].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[row].Cells["Khoa"].Value = khoa;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");

            }
        }

        private bool checkMaSV(string masv)
        {
            if(dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for(int row = 1; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if(rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtDTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                string tenkhoa = dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while(i < listKhoa.Length && listKhoa[i] != tenkhoa)
                {
                    i++;
                }
                cbKhoa.SelectedIndex = i;
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần cập nhật");
                }
                if (!txtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên phải đúng 10 ký tự");
                }
                if (this.checkMaSV(txtMaSV.Text) == false && txtMaSV.Text!= dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString())
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên ít nhất 2 ký tự");
                }
                if (!double.TryParse(txtDTB.Text, out diemtb))
                {
                    throw new Exception("Điểm trung bình không phải số");
                }
                //Lấy thông tin
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                
                string khoa = cbKhoa.Text;
                //Lưu dữ liệu vào lưới
                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần xóa!");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có muốn thoát không",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
