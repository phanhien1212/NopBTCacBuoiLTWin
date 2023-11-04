using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_4
{
    public partial class Form1 : Form
    {
        private int stt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSach.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sách không để rỗng");
                }
                //Lấy thông tin
                string tensach = txtTenSach.Text;
                string masach = txtMaSach.Text;
                string gia  = txtGia.Text;
                string soluong = txtSoLuong.Text;


                lblThongBao.Text += stt + ".Tên sách:" + tensach + "Mã sách:" + masach + "Giá:" + gia + "Số lượng:" + soluong +  "\r\n";
                stt++;
            }
            catch (Exception ex)
            {
                lblThongBao.Text = "";
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
