using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_3
{
    public partial class frmNhaXuatBan : Form
    {
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }
        NhaXuatBanDao nxbDao = new NhaXuatBanDao();
        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            loadDSNhaXuatBan();
        }
        private void loadDSNhaXuatBan()
        {
            dgvDanhSach.DataSource = nxbDao.getList();
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if(rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn loại sách");
                }
                txtMaNXB.Text = dgvDanhSach.Rows[rowindex].Cells["MaNXB"].Value.ToString();
                txtTenNXB.Text = dgvDanhSach.Rows[rowindex].Cells["TenNXB"].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[rowindex].Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = dgvDanhSach.Rows[rowindex].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dgvDanhSach.Rows[rowindex].Cells["Email"].Value.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
