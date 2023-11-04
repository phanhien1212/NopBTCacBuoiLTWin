using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Main : Form
    {
        public static string tendangnhap = null;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(tendangnhap == null)
            {
                Form Login = new Login();
                Login.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            Label labelSinhVien = new Label();
            // Đặt văn bản của Label thành "Sinh viên"
            labelSinhVien.Text = "Sinh viên";          
            // Thêm Label vào Panel
            panel3.Controls.Add(labelSinhVien);
            
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            Label labelKhoa = new Label();
            labelKhoa.Text = "Khoa";
            panel3.Controls.Add(labelKhoa);
        }
    }
}
