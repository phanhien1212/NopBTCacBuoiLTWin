using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Buoi05_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpg|*.jpg|png|*.png| gif|*.gif|bmp|*.bmp | Tất cả |*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                String pathFile = openFile.FileName;
                pbHinh.Image = new Bitmap(pathFile);
            }
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Document|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open);
                StreamReader stream = new StreamReader(fs, Encoding.UTF8);
                txtNoiDung.Text = stream.ReadToEnd();
            }
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "Text Document | * .txt";
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;
            saveFile.Title = "Where do you want to save the file?";
            saveFile.InitialDirectory = @"c:/";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFile.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
                writer.WriteLine(txtNoiDung.Text);
                writer.Flush();
                fs.Close();
            }
        }

       
    }
}
