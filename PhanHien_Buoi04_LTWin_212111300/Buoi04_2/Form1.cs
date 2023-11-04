using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_2
{
    public partial class Form1 : Form
    {
        List<MonAn> monAns;
        List<Ban> bans;
        ListView listViewDanhSachDatMon;

        public Form1()
        {
            InitializeComponent();

            // Initialize the lists of dishes and tables
            monAns = new List<MonAn>
        {
            new MonAn("Cà phê đen", 15000),
            new MonAn("Cà phê sữa", 18000),
            new MonAn("Nước cơm", 30000)
        };

            bans = new List<Ban>();
            for (int i = 1; i <= 10; i++)
            {
                bans.Add(new Ban(i));
            }

            // Display the list of dishes and tables
            foreach (var monAn in monAns)
            {
                lvDSMon.Items.Add(monAn.TenMonAn);
            }

            foreach (var ban in bans)
            {
                lvDSDatMon.Items.Add("Bàn " + ban.SoBan);
            }

            // Set the default quantity to 1
            nmrSoLuong.Text = "1";

            // Set the minimum and maximum values for quantity
            nmrSoLuong.Minimum = 1;
            nmrSoLuong.Maximum = 20;

            // Display the order list
            listViewDanhSachDatMon = new ListView();
            listViewDanhSachDatMon.Location = new System.Drawing.Point(300, 100);
            listViewDanhSachDatMon.Size = new System.Drawing.Size(200, 200);
            this.Controls.Add(listViewDanhSachDatMon);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (lvDSMon.SelectedItems.Count > 0)
            {
                string tenMonAn = lvDSMon.SelectedItems[0].Text;
                int soLuong = Convert.ToInt32(nmrSoLuong.Text);
                listViewDanhSachDatMon.Items.Add(new ListViewItem(new string[] { tenMonAn, soLuong.ToString() }));
            }
            else
            {
                MessageBox.Show("Please select a dish!");
            }
        }
    }

    public class MonAn
    {
        public string TenMonAn { get; set; }
        public int Gia { get; set; }

        public MonAn(string tenMonAn, int gia)
        {
            TenMonAn = tenMonAn;
            Gia = gia;
        }
    }

    public class Ban
    {
        public int SoBan { get; set; }

        public Ban(int soBan)
        {
            SoBan = soBan;
        }
    }
}
