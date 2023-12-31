﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_2
{
    public partial class frmChiTietDH : Form
    {
        public frmChiTietDH()
        {
            InitializeComponent();
        }
        ChiTietDonHangDAO ctDAO = new ChiTietDonHangDAO();
        string insertupdate = "";
        private void frmChiTietDH_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSP.Enabled = false;
            btnXoa.Enabled = false;
            loadDSCTDH();
        }
        private void loadDSCTDH()
        {
            dgvDanhSach.DataSource = ctDAO.getList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaSP.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSP.Enabled = false;
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
