using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_2
{
    public partial class Form1 : Form
    {
        private int stt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên không để rỗng");
                }
                //Lấy thông tin
                string hoten = txtHoTen.Text;
                string masv = txtMSV.Text;
                string ngaysinh = txtNgaySinh.Text;
                string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                if (cbDuLich.Checked)
                {
                    sothich += "Du Lịch";
                }
                if (cbTheThao.Checked)
                {
                    sothich += "Thể Thao";
                }
                if (cbMuaSam.Checked)
                {
                    sothich += "Mua Sắm";
                }
                if (sothich!=null)
                {
                    sothich = "Sở thích:" + sothich;
                }
                lblThongBao.Text += stt + ".Họ tên:" + hoten + "Ngày sinh:" + ngaysinh + "Giới tính:" + gioitinh + sothich + "\r\n";
                stt++;
            }
            catch(Exception ex)
            {
                lblThongBao.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
