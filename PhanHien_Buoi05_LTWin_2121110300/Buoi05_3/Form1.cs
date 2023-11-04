using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_3
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        String[] listLoaiSP = { "Áo nam", "Áo nữ", "Quần nam", "Quần nam" };
        String[] listdonvitinh = { "Cái", "Chiếc", "Thùng"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = listLoaiSP;
            cbDonViTinh.DataSource = listdonvitinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double gia;
            try
            {
                if (!txtMaSP.Text.Length.Equals(3))
                {
                    throw new Exception("Mã sản phẩm phải có 3 ký tự");
                }
                if (this.checkMaSP(txtMaSP.Text) == false)
                {
                    throw new Exception("Mã sản phẩm đã tồn tại");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sản phẩm không được để trống");
                }

                if (txtSoLuong.Text.Length.Equals(0))
                {
                    throw new Exception("Số lượng sản phẩm phải có");
                }
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Giá sản phẩm không phải là số");
                }

                // Lấy thông tin
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string soluong = txtSoLuong.Text;
                string loaisp = cbLoaiSP.Text;
                string donvitinh = cbDonViTinh.Text;

                // Tính thành tiền
                double thanhTien = gia * Convert.ToDouble(soluong);

                // Lưu dữ liệu vào lưới
                int row = dgvDanhSach.Rows.Add();//Add tạo mới 1 hàng, trả về vị trí thêm
                dgvDanhSach.Rows[row].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[row].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[row].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[row].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[row].Cells["LoaiSP"].Value = loaisp;
                dgvDanhSach.Rows[row].Cells["DonViTinh"].Value = donvitinh;
                dgvDanhSach.Rows[row].Cells["ThanhTien"].Value = thanhTien; // Thêm thành tiền vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }


        }

        private bool checkMaSP(string masp)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 1; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSP"].Value.ToString() == masp)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            double gia;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm cần cập nhật");
                }
                if (!txtMaSP.Text.Length.Equals(3))
                {
                    throw new Exception("Mã sản phẩm phải đúng 3 ký tự");
                }
                if (this.checkMaSP(txtMaSP.Text) == false && txtMaSP.Text != dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString())
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sản phẩm ít nhất 2 ký tự");
                }
                if (txtSoLuong.Text.Length.Equals(0))
                {
                    throw new Exception("Số lượng sản phẩm phải có");
                }
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Giá sản phẩm không phải là số");
                }
                //Lấy thông tin
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string soluong = txtSoLuong.Text;
                string loaisp = cbLoaiSP.Text;
                string donvitinh = cbDonViTinh.Text;

                double thanhTien = gia * Convert.ToDouble(soluong);
                //Lưu dữ liệu vào lưới
                dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[rowindex].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value = loaisp;
                dgvDanhSach.Rows[rowindex].Cells["DonViTinh"].Value = donvitinh;
                dgvDanhSach.Rows[rowindex].Cells["ThanhTien"].Value = thanhTien;
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
                    throw new Exception("Chưa chọn sản phẩm cần xóa!");
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

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[rowindex].Cells["Gia"].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                string tenloaisp = dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value.ToString();
                int i = 0;
                while (i < listLoaiSP.Length && listLoaiSP[i] != tenloaisp)
                {
                    i++;
                }
                cbLoaiSP.SelectedIndex = i;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loaiSPChon = cbLoaiSP.Text;

            // Xóa các hàng hiện tại trong DataGridView
            dgvDanhSach.Rows.Clear();

            // Duyệt qua danh sách sản phẩm và thêm các sản phẩm có loại sản phẩm trùng khớp vào DataGridView
            foreach (var product in loaiSPChon)
            {
                if (product.LoaiSP.Equals(loaiSPChon))
                {
                    // Thêm sản phẩm vào DataGridView
                    int row = dgvDanhSach.Rows.Add();
                    dgvDanhSach.Rows[row].Cells["MaSP"].Value = product.MaSP;
                    dgvDanhSach.Rows[row].Cells["TenSP"].Value = product.TenSP;
                    dgvDanhSach.Rows[row].Cells["Gia"].Value = product.Gia;
                    dgvDanhSach.Rows[row].Cells["SoLuong"].Value = product.SoLuong;
                    dgvDanhSach.Rows[row].Cells["LoaiSP"].Value = product.LoaiSP;
                    dgvDanhSach.Rows[row].Cells["DonViTinh"].Value = product.DonViTinh;
                }
            }
        }
    }
}
