using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_3
{
    internal class Teacher : Person
    {
        public string MaGV;
        public string Khoa;
        public string ChucVu;

        public Teacher() { }

        public Teacher(string magv, string khoa, string chucvu)
        {
            this.MaGV = magv;
            this.Khoa = khoa;
            this.ChucVu = chucvu;
        }
        public void NhapGV()
        {
            Console.Write("Nhap MaGV: ");
            MaGV = Console.ReadLine();
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhap ChucVu: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiaChi: ");
            DiaChi = Console.ReadLine();
        }
        public void XuatGV()
        {
            Console.WriteLine("MaSV:{0} \t Khoa:{1} \t ChucVu:{2} \t CMND:{3} \t HoTen:{4} \t DiaChi:{4}", MaGV, Khoa, ChucVu, CMND, HoTen, DiaChi);
        }
    }
}
